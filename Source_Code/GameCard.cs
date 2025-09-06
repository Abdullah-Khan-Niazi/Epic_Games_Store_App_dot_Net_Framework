using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_LAB_PROJECT_GunaUI
{
    public partial class GameCard : UserControl
    {
        public event EventHandler GameClicked;
        private bool Owned;
        private int gId;
        public GameCard()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                c.Click += GameCard_Click;
            }

            this.Click += GameCard_Click;
        }
        private void GameCard_Click(object sender, EventArgs e)
        {
            GameClicked?.Invoke(this, EventArgs.Empty);
        }

        private string gameDescription;
        public void SetGameData(int gameId, string title, string price, Image coverImage, string rating, string description, string Genre, string platform, bool isOwned = false)
        {
            gId = gameId;
            gameName.Text = title;
            gamePrice.Text = $"{price}";
            GameIMG.Image = coverImage;
            gameRating.Value = Convert.ToSingle(rating);
            gameDescription = description;
            genre.Text = Genre;
            Platform.Text = platform;
            Owned = isOwned;
        }

        public int GetGameID()
        {
            return gId;
        }
        public string GetGameTitle()
        {
            return gameName.Text;
        }

        public string GetGamePrice()
        {
            return gamePrice.Text;
        }

        public Image GetGameImage()
        {
            return GameIMG.Image;
        }

        public float GetGameRating()
        {
            return gameRating.Value;
        }

        public string GetGameDescription()
        {
            return gameDescription; // Ensure you have declared and set this in SetGameData
        }

        public string GetGenre()
        {
            return genre.Text;
        }

        public string GetPlatform()
        {
            return Platform.Text;
        }

        public bool IsOwned()
        {
            return Owned;
        }
        private void gameCardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GameIMG_Click(object sender, EventArgs e)
        {
            GameClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
