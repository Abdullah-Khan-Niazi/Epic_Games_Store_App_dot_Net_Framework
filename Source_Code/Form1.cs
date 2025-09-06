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
using Guna.UI2.WinForms.Suite;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class Form1 : Form
    {
        //public static string connectionString = "Server=DESKTOP-6T27B6S;Database=GameStoreDB;Trusted_Connection=True;";
        public static string connectionString = "Server=DESKTOP-6T27B6S;Database=GameStoreDB;Trusted_Connection=True;MultipleActiveResultSets=True;";

        private int currentUserId = -1;
        private string currentUsername;
        private string currentUserFirstName;
        private string currentUserLastName;
        private string currentProfileIMG;
        private string currentRole;

       private bool isLoggedIn;
       private bool isAdmin;

        private LoginPage login_page;
        private myCartPage my_cart_page;
        private myGamesPage my_game_page;
        private SignUpPage sign_up_page;
        private gameDetails game_details;
        private addGamesPage add_games_page;
        private editUsersPage edit_users_page;
        private editGamesPage edit_games_page;
        private searchResultsPage search_results_page;

        public int getUserID()
        {
            return currentUserId;
        }

        private void clearControls()
        {
            if (login_page != null && formPanel.Controls.Contains(login_page))
            {
                formPanel.Controls.Remove(login_page);
                login_page.Dispose();
            }
            if (my_cart_page != null && formPanel.Controls.Contains(my_cart_page))
            {
                formPanel.Controls.Remove(my_cart_page);
                my_cart_page.Dispose();
            }
            if (my_game_page != null && formPanel.Controls.Contains(my_game_page))
            {
                formPanel.Controls.Remove(my_game_page);
                my_game_page.Dispose();
            }
            if (sign_up_page != null && formPanel.Controls.Contains(sign_up_page))
            {
                formPanel.Controls.Remove(sign_up_page);
                sign_up_page.Dispose();
            }
            if (game_details != null && formPanel.Controls.Contains(game_details))
            {
                formPanel.Controls.Remove(game_details);
                game_details.Dispose();
            }
            if (add_games_page != null && formPanel.Controls.Contains(add_games_page))
            {
                formPanel.Controls.Remove(add_games_page);
                add_games_page.Dispose();
            }
            if (edit_users_page != null && formPanel.Controls.Contains(edit_users_page))
            {
                formPanel.Controls.Remove(edit_users_page);
                edit_users_page.Dispose();
            }
            if (edit_games_page != null && formPanel.Controls.Contains(edit_games_page))
            {
                formPanel.Controls.Remove(edit_games_page);
                edit_games_page.Dispose();
            }
            if (search_results_page != null && formPanel.Controls.Contains(search_results_page))
            {
                formPanel.Controls.Remove(search_results_page);
                search_results_page.Dispose();
            }
        }
        private void rightButton_Click(object sender, EventArgs e)
        {
            horizontalFlowPanel.Visible = false;
            int scrollAmount = 1005;
            int newX = -horizontalFlowPanel.AutoScrollPosition.X + scrollAmount;

            horizontalFlowPanel.AutoScrollPosition = new Point(newX, 0);
            horizontalFlowPanel.Visible = true;
        }



        private void leftButton_Click(object sender, EventArgs e)
        {
            horizontalFlowPanel.Visible = false;
            int currentX = horizontalFlowPanel.AutoScrollPosition.X;
            int scrollAmount = 1005;

            // Scroll left
            horizontalFlowPanel.AutoScrollPosition = new Point(-(currentX + scrollAmount), 0);
            horizontalFlowPanel.Visible = true;
        }

        private void signINButton_Click(object sender, EventArgs e)
        {
            clearControls();

            dashBoardPanel.Visible = false;

            if (login_page == null || login_page.IsDisposed)
            {
                login_page = new LoginPage();
                login_page.LoginSuccess += OnLoginSuccess;
                login_page.SignUpClicked += SignUpClicked;
            }

            if (!formPanel.Controls.Contains(login_page))
            {
                formPanel.Controls.Add(login_page);
                login_page.Location = new System.Drawing.Point(520, 30);
                login_page.BringToFront(); // Optional: ensures it's visible above others
            }

           // lp.Show();
        }
        private void SignUpClicked(object sender, EventArgs e)
        {
            if (login_page != null)
            {
                // Detach the event handler before disposing
                login_page.SignUpClicked -= SignUpClicked;

                if (formPanel.Controls.Contains(login_page))
                    formPanel.Controls.Remove(login_page);

                login_page.Dispose();
                login_page = null;
            }

            if (sign_up_page == null || sign_up_page.IsDisposed)
                sign_up_page = new SignUpPage();

            if (!formPanel.Controls.Contains(sign_up_page))
            {
                formPanel.Controls.Add(sign_up_page);
                sign_up_page.Location = new Point(450, 30);
                sign_up_page.BringToFront();
            }
        }

        public void GameCard_Clicked(object sender, EventArgs e)
        {
            clearControls();
            dashBoardPanel.Visible = false;

            if (game_details == null || game_details.IsDisposed)
                game_details = new gameDetails();

            formPanel.Controls.Add(game_details);
            game_details.Location = new Point(450, 100);
            game_details.BringToFront();

            // ✅ Handle both GameCard and gameCardHorizontal
            string title = "";
            string price = "";
            string description = "";
            string Genre = "";
            string platform = "";
            string Rating = "";
            int gameId = 0;
            bool purchasedFlag = true;
            Image coverImage = null;

            if ((sender as Control)?.Tag is GameCard gc)
            {
                title = gc.GetGameTitle();
                price = gc.GetGamePrice();
                coverImage = gc.GetGameImage();
                description = gc.GetGameDescription();
                Genre = gc.GetGenre();
                platform = gc.GetPlatform();
                Rating = gc.GetGameRating().ToString();
                purchasedFlag = gc.IsOwned();
                gameId = gc.GetGameID();
            }
            else if ((sender as Control)?.Tag is gameCardHorizontal ghc)
            {
                title = ghc.GetGameTitle();
                price = ghc.GetGamePrice();
                coverImage = ghc.GetGameImage();
                description = ghc.GetGameDescription();
                Genre = ghc.GetGenre();
                platform = ghc.GetPlatform();
                Rating = ghc.GetGameRating().ToString();
                purchasedFlag = ghc.IsOwned();
                gameId = ghc.GetGameID();
            }

            if (!string.IsNullOrEmpty(title))
            {
                game_details.SetDetails(title, price, coverImage, description, Genre, platform, Rating, purchasedFlag, currentUserId, gameId);
            }
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            clearControls();
            horizontalFlowPanel.Controls.Clear();
            TopSellingPanel.Controls.Clear();
            TopRatedPanel.Controls.Clear();
            load_games();
            load_top_rated_games();
            load_top_selling_games();
            dashBoardPanel.Visible = true;
        }

        private void myGamesButton_Click(object sender, EventArgs e)
        {
            clearControls();
            dashBoardPanel.Visible = false;
            if (my_game_page == null || my_game_page.IsDisposed)
                my_game_page = new myGamesPage(currentUserId);

            if (!formPanel.Controls.Contains(my_game_page))
            {
                formPanel.Controls.Add(my_game_page);
                my_game_page.Location = new System.Drawing.Point(490, 30);
                my_game_page.BringToFront(); 
            }
        }

        private void myCartButton_Click(object sender, EventArgs e)
        {
            clearControls();
            dashBoardPanel.Visible = false;
            if (my_cart_page == null || my_cart_page.IsDisposed)
                my_cart_page = new myCartPage(currentUserId);

            if (!formPanel.Controls.Contains(my_cart_page))
            {
                formPanel.Controls.Add(my_cart_page);
                SetDoubleBuffered(my_cart_page);
                my_cart_page.Location = new System.Drawing.Point(380, 10);
                my_cart_page.BringToFront();
            }
        }

        private void OnLoginSuccess(int userId, string username,string role,string fname ,string lname ,string imgPath)
        {
            currentUserId = userId;
            currentUsername = username;
            currentUserFirstName = fname;
            currentUserLastName = lname;
            currentProfileIMG = imgPath;
            currentRole = role;

        MessageBox.Show($"Welcome, {username}!");
            clearControls();
            signINButton.Visible = false;
            currentUserNameLabel.Text = currentUsername;
            profilePanel.Visible = true;
            profilePanel.Location = new System.Drawing.Point(870, 8);
            userIcon.Image = Image.FromFile(imgPath);
            if (role == "Admin")
            {
                myCartButton.Visible = false;
                myGamesButton.Visible = false;
                editGamesButton.Visible = true;
                editUsersButton.Visible = true;
                addGamesButton.Visible = true;
                editGamesButton.Location = new System.Drawing.Point(0, 251);
                addGamesButton.Location = new System.Drawing.Point(0, 206);
                editUsersButton.Location = new System.Drawing.Point(0, 298);
            }
            else
            {
                myCartButton.Visible = true;
                myGamesButton.Visible = true;
            }
            horizontalFlowPanel.Controls.Clear();
            TopSellingPanel.Controls.Clear();
            TopRatedPanel.Controls.Clear();
            load_games();
            load_top_selling_games();
            load_top_rated_games();
            dashBoardPanel.Visible = true;
        }

        private void addGamesButton_Click(object sender, EventArgs e)
        {
            clearControls() ;
            dashBoardPanel.Visible = false;
            if (add_games_page == null || add_games_page.IsDisposed)
                add_games_page = new addGamesPage();

            if (!formPanel.Controls.Contains(add_games_page))
            {
                formPanel.Controls.Add(add_games_page);
                SetDoubleBuffered(add_games_page);
                add_games_page.Location = new System.Drawing.Point(430, 30);
                add_games_page.BringToFront();
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SetDoubleBuffered(horizontalFlowPanel);
            SetDoubleBuffered(verticalFlowPanel);

        }

        private void SetDoubleBuffered(Control control)
        {
            if (SystemInformation.TerminalServerSession) return;

            System.Reflection.PropertyInfo doubleBufferProperty = typeof(Control).GetProperty(
                "DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic
            );

            doubleBufferProperty?.SetValue(control, true, null);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            myCartButton.Visible = false;
            myGamesButton.Visible = false;
            addGamesButton.Visible = false;
            editGamesButton.Visible = false;
            editUsersButton.Visible = false;
            profilePanel.Visible = false;
            load_games();
            load_top_selling_games();
            load_top_rated_games();

            this.Refresh();
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

        private void load_games()
        {
            horizontalFlowPanel.Visible = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT GameId,Title, Price, ImagePath, Rating,Description,Platform,Genre FROM Games", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int gameId = Convert.ToInt32(reader["GameId"]);
                    bool flag = IsOwned(conn, currentUserId,gameId);
                    GameCard card = new GameCard();
                    card.SetGameData(
                        gameId,
                        reader["Title"].ToString(),
                        reader["Price"].ToString(),
                        Image.FromFile(reader["ImagePath"].ToString()),
                        reader["Rating"] .ToString(),// rating as dummy
                        reader["Description"].ToString(),
                        reader["Genre"].ToString(),
                        reader["Platform"].ToString(),
                        flag
                    );
                    card.GameClicked += GameCard_Clicked;
                    card.Tag = card;

                    foreach (Control c in card.Controls)
                    {
                        c.Tag = card; // Let each child hold a reference to its parent card
                        c.Click += GameCard_Clicked;
                    }
                    horizontalFlowPanel.Controls.Add(card);
                }
                conn.Close();
            }
            horizontalFlowPanel.Visible = true;
        }
        // Load Top Selling Games
        private void load_top_selling_games()
        {
            TopSellingPanel.Visible = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT GameId, Title, Price, ImagePath, Description,Rating,Genre,Platform
                FROM Top4SellingGames";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int gameId = Convert.ToInt32(reader["GameId"]);
                    bool flag = IsOwned(conn, currentUserId, gameId);
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
                    card.GameClicked += GameCard_Clicked;
                    card.Tag = card;

                    foreach (Control c in card.Controls)
                    {
                        c.Tag = card; // Let each child hold a reference to its parent card
                        c.Click += GameCard_Clicked;
                    }
                    TopSellingPanel.Controls.Add(card);

                }
                conn.Close();
            }
            TopSellingPanel.Visible = true;
        }

        // Load Top Rated Games
        private void load_top_rated_games()
        {
            TopRatedPanel.Visible = false;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT GameId, Title, Price, ImagePath, Description, Rating,Genre,Platform
            FROM Top4RatedGames";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int gameId = Convert.ToInt32(reader["GameId"]);
                    bool flag = IsOwned(conn, currentUserId, gameId);
                    gameCardHorizontal card = new gameCardHorizontal();
                    card.SetGameData(
                        gameId,
                        reader["Title"].ToString(),
                        reader["Price"].ToString(),
                        Image.FromFile(reader["ImagePath"].ToString()),
                        reader["Rating"].ToString(), // Display rating as a substitute for sales count
                        reader["Description"].ToString(),
                        reader["Genre"].ToString(),
                        reader["Platform"].ToString(),
                        flag
                    );
                    card.GameClicked += GameCard_Clicked;
                    card.Tag = card;

                    foreach (Control c in card.Controls)
                    {
                        c.Tag = card; // Let each child hold a reference to its parent card
                        c.Click += GameCard_Clicked;
                    }
                    TopRatedPanel.Controls.Add(card);
                }
                conn.Close();
            }
            TopRatedPanel.Visible = true;
        }


        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            //userPanel.Visible = true;
        }

        private void currentUserNameLabel_MouseEnter(object sender, EventArgs e)
        {
            currentUserNameLabel.ForeColor = Color.LightBlue; // Change text color
            currentUserNameLabel.Cursor = Cursors.Hand;  // Change cursor to hand
        }

        private void currentUserNameLabel_MouseLeave(object sender, EventArgs e)
        {
            currentUserNameLabel.ForeColor = Color.White; // Revert to original color
            currentUserNameLabel.Cursor = Cursors.Default; // Revert cursor
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            myCartButton.Visible = true;
            myGamesButton.Visible = true;
            addGamesButton.Visible = true;
            editGamesButton.Visible = true;
            editUsersButton.Visible = true;
            profilePanel.Visible = true;
        }

        private void editUsersButton_Click(object sender, EventArgs e)
        {
            clearControls();
            dashBoardPanel.Visible = false;
            if (edit_users_page == null || edit_users_page.IsDisposed)
                edit_users_page = new editUsersPage();
            if (!formPanel.Controls.Contains(edit_users_page))
            {
                edit_users_page.Location = new System.Drawing.Point(430, 30);
                formPanel.Controls.Add(edit_users_page);
                edit_users_page.BringToFront();
            }
        }

        private void editGamesButton_Click(object sender, EventArgs e)
        {
            clearControls();
            dashBoardPanel.Visible = false;
            if (edit_games_page == null || edit_games_page.IsDisposed)
                edit_games_page = new editGamesPage();
            if (!formPanel.Controls.Contains(edit_games_page))
            {
                edit_games_page.Location = new System.Drawing.Point(220, 30);
                formPanel.Controls.Add(edit_games_page);
                edit_games_page.BringToFront();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.Trim();
            searchBar.Clear();
            if (!string.IsNullOrEmpty(searchText)&&!string.IsNullOrWhiteSpace(searchText))
            {
                clearControls();
                dashBoardPanel.Visible = false;
                if (search_results_page == null || search_results_page.IsDisposed)
                    search_results_page = new searchResultsPage(searchText);
                if (!formPanel.Controls.Contains(search_results_page))
                {
                    search_results_page.Location = new System.Drawing.Point(500, 30);
                    formPanel.Controls.Add(search_results_page);
                    search_results_page.BringToFront();
                }
            }
        }
    }
}
