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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class gameDetails : UserControl
    {
        private int userId;
        private int gameId;
        public gameDetails()
        {
            InitializeComponent();
        }
        public void SetDetails(string title, string price, Image image, string Description,string Genre,string platform,string Rating,bool purchasedFlag = true,int userID = 0,int gid = 0)
        {
            gameId = gid;
            userId = userID;
            gameNameLabel.Text = title;
            gamePriceLabel.Text = price;
            gamePicBox.Image = image;
            gameDescription.Text = Description;
            genre.Text = Genre;
            Platform.Text = platform;
            gameRating.Value = Convert.ToSingle(Rating);
            if (purchasedFlag)
            {
                addToCartButton.Visible = false;
                playGameButton.Location = new Point(455, 380);
            }
            else
            { 
                addToCartButton.Visible = true;
                playGameButton.Visible = false;
            }
            if (userID == -1)
            {
                addToCartButton.Visible = false;
                playGameButton.Visible = false;
            } 
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            string connectionString = Form1.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the game is already in the user's cart
                    string checkQuery = "SELECT COUNT(*) FROM Cart WHERE UserId = @UserId AND GameId = @GameId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@UserId", userId);
                    checkCmd.Parameters.AddWithValue("@GameId", gameId);

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("This game is already in your cart.");
                        return;
                    }

                    string insertQuery = @"
                INSERT INTO Cart (UserId, GameId)
                VALUES (@UserId, @GameId)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@UserId", userId);
                    insertCmd.Parameters.AddWithValue("@GameId", gameId);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Game added to cart.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add game to cart.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                conn.Close();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
            }
        }
    }
}
