using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class addGamesPage : UserControl
    {
        public addGamesPage()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Example input controls: titleTextBox, descriptionTextBox, priceTextBox, genreTextBox, platformTextBox, imagePathTextBox, ratingTextBox
            string title = titleTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();
            string priceText = priceTextBox.Text.Trim();
            string genre = genreTextBox.Text.Trim();
            string platform = platFormTextBox.Text.Trim();
            string imagePath = imagePathTextBox.Text.Trim();
            string ratingText = ratingTextBox.Text.Trim();

            // Input validation
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(genre) ||
                string.IsNullOrEmpty(platform) || string.IsNullOrEmpty(imagePath) ||
                string.IsNullOrEmpty(ratingText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            if (!float.TryParse(ratingText, out float rating) || rating < 0 || rating > 5)
            {
                MessageBox.Show("Rating must be a number between 0 and 5.");
                return;
            }

            string connectionString = Form1.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Games (Title, Description, Price, Genre, Platform, ImagePath, Rating)
                             VALUES (@Title, @Description, @Price, @Genre, @Platform, @ImagePath, @Rating)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@Platform", platform);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                    cmd.Parameters.AddWithValue("@Rating", rating);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Game added successfully.");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the game.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                conn.Close();
            }
        }

        private void ClearFields()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
            priceTextBox.Clear();
            genreTextBox.Clear();
            platFormTextBox.Clear();
            imagePathTextBox.Clear();
            ratingTextBox.Clear();
        }

    }
}
