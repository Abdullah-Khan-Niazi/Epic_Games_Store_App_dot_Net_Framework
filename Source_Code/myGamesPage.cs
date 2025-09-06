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
    public partial class myGamesPage : UserControl
    {
        private int userID;
        public myGamesPage(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void myGamesPage_Load(object sender, EventArgs e)
        {
            string connectionString = Form1.connectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT G.GameId, G.Title, G.Price, G.ImagePath, G.Description,G.Rating,G.Genre,G.Platform
                FROM OwnedGames UG
                JOIN Games G ON UG.GameId = G.GameId
                WHERE UG.UserId = @UserId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", userID);
                SqlDataReader reader = cmd.ExecuteReader();
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                while (reader.Read())
                {
                    int gameId = Convert.ToInt32(reader["GameId"]);
                    gameCardHorizontal card = new gameCardHorizontal();
                    card.SetGameData(
                        gameId,
                        reader["Title"].ToString(),
                        reader["Price"].ToString(),
                        Image.FromFile(reader["ImagePath"].ToString()),
                        reader["Rating"].ToString(),
                        reader["Description"].ToString(),
                        reader["Genre"].ToString(),
                        reader["Platform"].ToString(),
                        true
                    );
                    // Optionally add click handler if needed
                    card.Click += mainForm.GameCard_Clicked;
                    card.Tag = card;

                    foreach (Control c in card.Controls)
                    {
                        c.Tag = card; // Let each child hold a reference to its parent card
                        c.Click += mainForm.GameCard_Clicked;
                    }

                    myGamesFlowPanel.Controls.Add(card);
                }
            }
        }
    }
}
