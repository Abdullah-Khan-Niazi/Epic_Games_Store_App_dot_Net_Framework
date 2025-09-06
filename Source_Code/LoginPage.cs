using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class LoginPage : UserControl
    {
        public event Action<int, string, string,string,string,string> LoginSuccess; // userId and username
        public LoginPage()
        {
            InitializeComponent();

        }
        public event EventHandler SignUpClicked;
        private void signupButton_Click(object sender, EventArgs e)
        {
            SignUpClicked?.Invoke(this, EventArgs.Empty);
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT UserId, FirstName, LastName, Username, Email, PasswordHash, Role, ProfileImagePath FROM Users WHERE Email = @Email AND PasswordHash = @PasswordHash";
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", emailAddressTextbox.Text);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordTextBox.Text); // Note: hashing recommended

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int userId = (int)reader["UserId"];
                    string username = reader["Username"].ToString();
                    string role = reader["Role"].ToString();
                    string fname = reader["FirstName"].ToString();
                    string lname = reader["LastName"].ToString();
                    string imgPath = reader["ProfileImagePath"].ToString();
                    LoginSuccess?.Invoke(userId, username, role, fname, lname, imgPath);
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials");
                }
                conn.Close();
            }

        }
    }
}
