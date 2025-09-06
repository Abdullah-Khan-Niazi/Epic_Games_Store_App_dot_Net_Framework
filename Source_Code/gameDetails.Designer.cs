namespace DB_LAB_PROJECT_GunaUI
{
    partial class gameDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameDetailPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.gameDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gamePriceLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gameNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addToCartButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.genre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Platform = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.playGameButton = new Guna.UI2.WinForms.Guna2Button();
            this.gameRating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gamePicBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gameDetailPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDetailPanel
            // 
            this.gameDetailPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameDetailPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameDetailPanel.BorderRadius = 10;
            this.gameDetailPanel.BorderThickness = 2;
            this.gameDetailPanel.Controls.Add(this.guna2Panel1);
            this.gameDetailPanel.Controls.Add(this.gameRating);
            this.gameDetailPanel.Controls.Add(this.playGameButton);
            this.gameDetailPanel.Controls.Add(this.guna2HtmlLabel1);
            this.gameDetailPanel.Controls.Add(this.gameDescription);
            this.gameDetailPanel.Controls.Add(this.gamePriceLabel);
            this.gameDetailPanel.Controls.Add(this.gameNameLabel);
            this.gameDetailPanel.Controls.Add(this.addToCartButton);
            this.gameDetailPanel.Controls.Add(this.gamePicBox);
            this.gameDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameDetailPanel.FillColor = System.Drawing.Color.Black;
            this.gameDetailPanel.Location = new System.Drawing.Point(0, 0);
            this.gameDetailPanel.Name = "gameDetailPanel";
            this.gameDetailPanel.Size = new System.Drawing.Size(584, 425);
            this.gameDetailPanel.TabIndex = 0;
            // 
            // gameDescription
            // 
            this.gameDescription.AutoSize = false;
            this.gameDescription.BackColor = System.Drawing.Color.Transparent;
            this.gameDescription.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDescription.ForeColor = System.Drawing.Color.White;
            this.gameDescription.Location = new System.Drawing.Point(331, 88);
            this.gameDescription.Name = "gameDescription";
            this.gameDescription.Size = new System.Drawing.Size(229, 173);
            this.gameDescription.TabIndex = 4;
            this.gameDescription.Text = "[Description]";
            // 
            // gamePriceLabel
            // 
            this.gamePriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.gamePriceLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePriceLabel.ForeColor = System.Drawing.Color.White;
            this.gamePriceLabel.Location = new System.Drawing.Point(331, 380);
            this.gamePriceLabel.Name = "gamePriceLabel";
            this.gamePriceLabel.Size = new System.Drawing.Size(58, 24);
            this.gamePriceLabel.TabIndex = 3;
            this.gamePriceLabel.Text = "[Price]";
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = false;
            this.gameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.White;
            this.gameNameLabel.Location = new System.Drawing.Point(331, 15);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(229, 67);
            this.gameNameLabel.TabIndex = 2;
            this.gameNameLabel.Text = "[Game Name]";
            this.gameNameLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Animated = true;
            this.addToCartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addToCartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addToCartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addToCartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addToCartButton.FillColor = System.Drawing.Color.Gray;
            this.addToCartButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(455, 380);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(116, 29);
            this.addToCartButton.TabIndex = 1;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(317, 380);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(13, 24);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "$";
            // 
            // genre
            // 
            this.genre.BackColor = System.Drawing.Color.Transparent;
            this.genre.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.Color.DarkGray;
            this.genre.Location = new System.Drawing.Point(77, 3);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(55, 21);
            this.genre.TabIndex = 6;
            this.genre.Text = "[Genre]";
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.Transparent;
            this.Platform.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Platform.ForeColor = System.Drawing.Color.DarkGray;
            this.Platform.Location = new System.Drawing.Point(77, 30);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(74, 21);
            this.Platform.TabIndex = 7;
            this.Platform.Text = "[Platform]";
            // 
            // playGameButton
            // 
            this.playGameButton.Animated = true;
            this.playGameButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.playGameButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.playGameButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.playGameButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.playGameButton.FillColor = System.Drawing.Color.Gray;
            this.playGameButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.playGameButton.ForeColor = System.Drawing.Color.White;
            this.playGameButton.Location = new System.Drawing.Point(455, 345);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(116, 29);
            this.playGameButton.TabIndex = 8;
            this.playGameButton.Text = "Play";
            // 
            // gameRating
            // 
            this.gameRating.Location = new System.Drawing.Point(317, 355);
            this.gameRating.Name = "gameRating";
            this.gameRating.Size = new System.Drawing.Size(101, 19);
            this.gameRating.TabIndex = 9;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(4, 30);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(70, 21);
            this.guna2HtmlLabel2.TabIndex = 10;
            this.guna2HtmlLabel2.Text = "Platform";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.genre);
            this.guna2Panel1.Controls.Add(this.Platform);
            this.guna2Panel1.Location = new System.Drawing.Point(317, 285);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(154, 54);
            this.guna2Panel1.TabIndex = 11;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(3, 3);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(50, 21);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Genre";
            // 
            // gamePicBox
            // 
            this.gamePicBox.BackColor = System.Drawing.Color.Black;
            this.gamePicBox.BorderRadius = 10;
            this.gamePicBox.ImageRotate = 0F;
            this.gamePicBox.Location = new System.Drawing.Point(12, 15);
            this.gamePicBox.Name = "gamePicBox";
            this.gamePicBox.Size = new System.Drawing.Size(299, 394);
            this.gamePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamePicBox.TabIndex = 0;
            this.gamePicBox.TabStop = false;
            // 
            // gameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gameDetailPanel);
            this.DoubleBuffered = true;
            this.Name = "gameDetails";
            this.Size = new System.Drawing.Size(584, 425);
            this.gameDetailPanel.ResumeLayout(false);
            this.gameDetailPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gameDetailPanel;
        private Guna.UI2.WinForms.Guna2Button addToCartButton;
        private Guna.UI2.WinForms.Guna2PictureBox gamePicBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel gamePriceLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel gameNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel gameDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel Platform;
        private Guna.UI2.WinForms.Guna2HtmlLabel genre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button playGameButton;
        private Guna.UI2.WinForms.Guna2RatingStar gameRating;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
