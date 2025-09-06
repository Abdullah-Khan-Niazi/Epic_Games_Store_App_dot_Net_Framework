using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class editGamesPage : UserControl
    {
        private int selectedGameId = -1;

        public editGamesPage()
        {
            InitializeComponent();
            this.dataGridViewGames.CellClick += dataGridViewGames_CellClick;
            dataGridViewGames.AllowUserToAddRows = false;
        }

        private void editGamesPage_Load(object sender, EventArgs e)
        {
            panelEditGame.Visible = false;
            LoadGames();
        }

        private void LoadGames()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Games";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewGames.DataSource = dt;

                // Set column headers
                dataGridViewGames.Columns["GameId"].HeaderText = "Game ID";
                dataGridViewGames.Columns["Title"].HeaderText = "Title";
                dataGridViewGames.Columns["Description"].HeaderText = "Description";
                dataGridViewGames.Columns["Price"].HeaderText = "Price";
                dataGridViewGames.Columns["Genre"].HeaderText = "Genre";
                dataGridViewGames.Columns["Platform"].HeaderText = "Platform";
                dataGridViewGames.Columns["ImagePath"].HeaderText = "Image";
                dataGridViewGames.Columns["Rating"].HeaderText = "Rating";

                // Add Edit/Delete buttons once
                if (!dataGridViewGames.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editButton = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewGames.Columns.Add(editButton);
                }

                if (!dataGridViewGames.Columns.Contains("Delete"))
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn
                    {
                        Name = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    dataGridViewGames.Columns.Add(deleteButton);
                }

                // Auto size columns
                dataGridViewGames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                conn.Close();
            }
        }

        private void dataGridViewGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string colName = dataGridViewGames.Columns[e.ColumnIndex].Name;

                if (colName == "Edit")
                {
                    selectedGameId = Convert.ToInt32(dataGridViewGames.Rows[e.RowIndex].Cells["GameId"].Value);
                    titleTextBox.Text = dataGridViewGames.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                    descriptionTextBox.Text = dataGridViewGames.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                    priceTextBox.Text = dataGridViewGames.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                    genreTextBox.Text = dataGridViewGames.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                    platFormTextBox.Text = dataGridViewGames.Rows[e.RowIndex].Cells["Platform"].Value.ToString();
                    imagePathTextBox.Text = dataGridViewGames.Rows[e.RowIndex].Cells["ImagePath"].Value.ToString();
                    ratingTextBox.Text = dataGridViewGames.Rows[e.RowIndex].Cells["Rating"].Value.ToString();

                    panelEditGame.Visible = true;
                }
                else if (colName == "Delete")
                {
                    int gameId = Convert.ToInt32(dataGridViewGames.Rows[e.RowIndex].Cells["GameId"].Value);
                    var confirm = MessageBox.Show("Are you sure you want to delete this game?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        DeleteGame(gameId);
                        LoadGames();
                    }
                }
            }
        }

        private void DeleteGame(int gameId)
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Games WHERE GameId = @GameId", conn);
                cmd.Parameters.AddWithValue("@GameId", gameId);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Games SET Title = @Title, Description = @Description, Price = @Price, Genre = @Genre, Platform = @Platform, ImagePath = @ImagePath, Rating = @Rating WHERE GameId = @GameId", conn);
                cmd.Parameters.AddWithValue("@Title", titleTextBox.Text);
                cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(priceTextBox.Text));
                cmd.Parameters.AddWithValue("@Genre", genreTextBox.Text);
                cmd.Parameters.AddWithValue("@Platform", platFormTextBox.Text);
                cmd.Parameters.AddWithValue("@ImagePath", imagePathTextBox.Text);
                cmd.Parameters.AddWithValue("@Rating", Convert.ToDouble(ratingTextBox.Text));
                cmd.Parameters.AddWithValue("@GameId", selectedGameId);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Game updated successfully!");
                panelEditGame.Visible = false;
                LoadGames();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelEditGame.Visible = false;
            selectedGameId = -1;
        }

    }
}
