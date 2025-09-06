using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class editUsersPage : UserControl
    {
        public editUsersPage()
        {
            InitializeComponent();
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.ColumnHeadersVisible = true;
        }

        private void editUsersPage_Load(object sender, EventArgs e)
        {
            panelEditUser.Visible = false;
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();
                string query = "SELECT UserID, FirstName, LastName, Username, Email, Role, ProfileImagePath FROM Users";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewUsers.DataSource = dt;

                // Set column headers for clarity
                dataGridViewUsers.Columns["UserID"].HeaderText = "User ID";
                dataGridViewUsers.Columns["FirstName"].HeaderText = "First Name";
                dataGridViewUsers.Columns["LastName"].HeaderText = "Last Name";
                dataGridViewUsers.Columns["Username"].HeaderText = "Username";
                dataGridViewUsers.Columns["Email"].HeaderText = "Email";
                dataGridViewUsers.Columns["Role"].HeaderText = "Role";
                dataGridViewUsers.Columns["ProfileImagePath"].HeaderText = "Profile Image";

                // Add Edit and Delete buttons if not added already
                if (!dataGridViewUsers.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewUsers.Columns.Add(editButton);
                }

                if (!dataGridViewUsers.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewUsers.Columns.Add(deleteButton);
                }

                // Set button sizes
                foreach (DataGridViewColumn col in dataGridViewUsers.Columns)
                {
                    if (col.Name == "Edit" || col.Name == "Delete")
                    {
                        col.Width = 80;
                    }
                }

                conn.Close();
            }
        }

        private int selectedUserId = -1;

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dataGridViewUsers.Columns[e.ColumnIndex].Name;

                if (columnName == "Edit")
                {
                    selectedUserId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["UserID"].Value);
                    UsernameTextBox.Text = dataGridViewUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                    EmailTextBox.Text = dataGridViewUsers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    FirstNameTextbox.Text = dataGridViewUsers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                    LastNameTextBox.Text = dataGridViewUsers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                    cmbRole.SelectedItem = dataGridViewUsers.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                    profileImagePathTextBox.Text = dataGridViewUsers.Rows[e.RowIndex].Cells["ProfileImagePath"].Value.ToString();

                    panelEditUser.Visible = true;
                }
                else if (columnName == "Delete")
                {
                    int userId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["UserID"].Value);

                    var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        DeleteUser(userId);
                        LoadUsers();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsUniqueUsernameEmail(UsernameTextBox.Text, EmailTextBox.Text))
            {
                using (SqlConnection conn = new SqlConnection(Form1.connectionString))
                {
                    string query = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Username = @Username, Email = @Email, Role = @Role, ProfileImagePath = @ProfileImage WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", FirstNameTextbox.Text);
                    cmd.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ProfileImage", profileImagePathTextBox.Text);
                    cmd.Parameters.AddWithValue("@UserID", selectedUserId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User updated successfully!");

                    panelEditUser.Visible = false;
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Username or Email is already in use. Please choose another.");
            }
        }

        private bool IsUniqueUsernameEmail(string username, string email)
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE (Username = @Username OR Email = @Email) AND UserID != @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@UserID", selectedUserId);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                return count == 0;
            }
        }

        private void DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEditUser.Visible = false;
            selectedUserId = -1;
        }
    }
}
