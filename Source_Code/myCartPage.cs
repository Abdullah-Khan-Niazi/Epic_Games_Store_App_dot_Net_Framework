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
    public partial class myCartPage : UserControl
    {
        private int userID;
        public myCartPage(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void myCartPage_Load(object sender, EventArgs e)
        {
            string connectionString = Form1.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT G.GameId,G.Title, G.Price, G.ImagePath, G.Description,G.Rating,G.Genre,G.Platform
                FROM Cart C
                JOIN Games G ON C.GameId = G.GameId
                WHERE C.UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", userID);
                SqlDataReader reader = cmd.ExecuteReader();
                double totalPrice = 0;
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
                        false
                    );
                    totalPrice += Convert.ToDouble(reader["Price"].ToString());
                    card.Click += mainForm.GameCard_Clicked;
                    card.Tag = card;

                    foreach (Control c in card.Controls)
                    {
                        c.Tag = card; // Let each child hold a reference to its parent card
                        c.Click += mainForm.GameCard_Clicked;
                    }
                    myCartFlowPanel.Controls.Add(card);
                }
                priceLabel.Text = totalPrice.ToString();
                conn.Close();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string connectionString = Form1.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Get all games in user's cart
                    string selectCartQuery = "SELECT GameId FROM Cart WHERE UserId = @UserId";
                    SqlCommand selectCmd = new SqlCommand(selectCartQuery, conn, transaction);
                    selectCmd.Parameters.AddWithValue("@UserId", userID);

                    List<int> gameIds = new List<int>();
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gameIds.Add(reader.GetInt32(0));
                        }
                    }

                    if (gameIds.Count == 0)
                    {
                        MessageBox.Show("Your cart is empty!", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        transaction.Rollback();
                        return;
                    }

                    // 2. Calculate total price
                    decimal totalPrice = 0;
                    foreach (int gameId in gameIds)
                    {
                        SqlCommand priceCmd = new SqlCommand("SELECT Price FROM Games WHERE GameId = @GameId", conn, transaction);
                        priceCmd.Parameters.AddWithValue("@GameId", gameId);
                        totalPrice += (decimal)priceCmd.ExecuteScalar();
                    }

                    // 3. Create Order
                    SqlCommand insertOrderCmd = new SqlCommand(
                        "INSERT INTO Orders (UserId, TotalAmount, Status) OUTPUT INSERTED.OrderId VALUES (@UserId, @TotalAmount, 'Completed')",
                        conn, transaction);
                    insertOrderCmd.Parameters.AddWithValue("@UserId", userID);
                    insertOrderCmd.Parameters.AddWithValue("@TotalAmount", totalPrice);
                    int orderId = (int)insertOrderCmd.ExecuteScalar();

                    // 4. Add to OrderDetails and OwnedGames
                    foreach (int gameId in gameIds)
                    {
                        SqlCommand insertOrderDetails = new SqlCommand(
                            "INSERT INTO OrderDetails (OrderId, GameId, Quantity) VALUES (@OrderId, @GameId, 1)",
                            conn, transaction);
                        insertOrderDetails.Parameters.AddWithValue("@OrderId", orderId);
                        insertOrderDetails.Parameters.AddWithValue("@GameId", gameId);
                        insertOrderDetails.ExecuteNonQuery();

                        SqlCommand insertOwned = new SqlCommand(
                            "IF NOT EXISTS (SELECT 1 FROM OwnedGames WHERE UserId = @UserId AND GameId = @GameId) " +
                            "INSERT INTO OwnedGames (UserId, GameId) VALUES (@UserId, @GameId)",
                            conn, transaction);
                        insertOwned.Parameters.AddWithValue("@UserId", userID);
                        insertOwned.Parameters.AddWithValue("@GameId", gameId);
                        insertOwned.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    // 5. Clear Cart
                    clearCart();

                    // Refresh cart view
                    myCartFlowPanel.Controls.Clear();
                    priceLabel.Text = "0";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Checkout failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void clearCart()
        {
            string connectionString = Form1.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM Cart WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                cmd.Parameters.AddWithValue("@UserId", userID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cart cleared successfully!", "Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the cart view
                myCartFlowPanel.Controls.Clear();
                priceLabel.Text = "0";
                conn.Close();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCart(); 
        }

    }

}
