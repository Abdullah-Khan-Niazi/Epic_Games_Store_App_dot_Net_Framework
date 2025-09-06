using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class searchResultsPage : UserControl
    {
        private string searchText;

        public searchResultsPage(string searchText)
        {
            InitializeComponent();
            this.searchText = searchText;
            this.Load += searchResultsPage_Load;
        }

        private void searchResultsPage_Load(object sender, EventArgs e)
        {
            LoadSearchResults();
        }

        private void LoadSearchResults()
        {
            searchFlowPanel.Controls.Clear();

            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT * FROM Games 
                    WHERE Title LIKE @search OR Description LIKE @search OR Genre LIKE @search OR Platform LIKE @search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                 // make sure this is accessible

                Form1 mainForm = (Form1)Application.OpenForms["Form1"];
                int currentUserId = mainForm.getUserID();
                while (reader.Read())
                {
                    int gameId = Convert.ToInt32(reader["GameId"]);
                    bool flag = IsOwned(conn, currentUserId, gameId);
                    if (currentUserId == -1) {
                        flag = false;;
                    }

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
                        flag
                    );

                    card.GameClicked += mainForm.GameCard_Clicked;
                    card.Tag = card;

                    foreach (Control c in card.Controls)
                    {
                        c.Tag = card;
                        c.Click += mainForm.GameCard_Clicked;
                    }

                    searchFlowPanel.Controls.Add(card);
                }

                reader.Close();
                conn.Close();
            }
        }
        private bool IsOwned(SqlConnection conn, int userId, int gameId)
        {
            string query = "SELECT COUNT(*) FROM OwnedGames WHERE UserID = @UserID AND GameID = @GameID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@GameID", gameId);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
