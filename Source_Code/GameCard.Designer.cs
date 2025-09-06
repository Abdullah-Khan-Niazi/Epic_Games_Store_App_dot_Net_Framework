using System;

namespace DB_LAB_PROJECT_GunaUI
{
    partial class GameCard
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
            this.gameCardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.gameRating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.gamePrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gameName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GameIMG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Platform = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.genre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gameCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // gameCardPanel
            // 
            this.gameCardPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameCardPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameCardPanel.BorderRadius = 10;
            this.gameCardPanel.BorderThickness = 2;
            this.gameCardPanel.Controls.Add(this.genre);
            this.gameCardPanel.Controls.Add(this.Platform);
            this.gameCardPanel.Controls.Add(this.guna2HtmlLabel1);
            this.gameCardPanel.Controls.Add(this.gameRating);
            this.gameCardPanel.Controls.Add(this.gamePrice);
            this.gameCardPanel.Controls.Add(this.gameName);
            this.gameCardPanel.Controls.Add(this.GameIMG);
            this.gameCardPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCardPanel.FillColor = System.Drawing.Color.Black;
            this.gameCardPanel.Location = new System.Drawing.Point(0, 0);
            this.gameCardPanel.Name = "gameCardPanel";
            this.gameCardPanel.Size = new System.Drawing.Size(245, 270);
            this.gameCardPanel.TabIndex = 0;
            this.gameCardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameCardPanel_Paint);
            // 
            // gameRating
            // 
            this.gameRating.BackColor = System.Drawing.Color.Black;
            this.gameRating.Location = new System.Drawing.Point(6, 245);
            this.gameRating.Name = "gameRating";
            this.gameRating.Size = new System.Drawing.Size(93, 19);
            this.gameRating.TabIndex = 3;
            // 
            // gamePrice
            // 
            this.gamePrice.BackColor = System.Drawing.Color.Transparent;
            this.gamePrice.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePrice.ForeColor = System.Drawing.Color.White;
            this.gamePrice.Location = new System.Drawing.Point(197, 206);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(42, 17);
            this.gamePrice.TabIndex = 2;
            this.gamePrice.Text = "[Price]";
            // 
            // gameName
            // 
            this.gameName.AutoSize = false;
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.Location = new System.Drawing.Point(6, 206);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(146, 38);
            this.gameName.TabIndex = 1;
            this.gameName.Text = "[Game Name]";
            // 
            // GameIMG
            // 
            this.GameIMG.BackColor = System.Drawing.Color.Black;
            this.GameIMG.BorderRadius = 7;
            this.GameIMG.FillColor = System.Drawing.Color.DarkGray;
            this.GameIMG.ImageRotate = 0F;
            this.GameIMG.Location = new System.Drawing.Point(6, 5);
            this.GameIMG.Name = "GameIMG";
            this.GameIMG.Size = new System.Drawing.Size(233, 193);
            this.GameIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameIMG.TabIndex = 0;
            this.GameIMG.TabStop = false;
            this.GameIMG.Click += new System.EventHandler(this.GameIMG_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(189, 206);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(10, 17);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "$";
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.Transparent;
            this.Platform.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Platform.ForeColor = System.Drawing.Color.DarkGray;
            this.Platform.Location = new System.Drawing.Point(184, 245);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(55, 17);
            this.Platform.TabIndex = 10;
            this.Platform.Text = "[Platform]";
            this.Platform.Visible = false;
            // 
            // genre
            // 
            this.genre.BackColor = System.Drawing.Color.Transparent;
            this.genre.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.Color.DarkGray;
            this.genre.Location = new System.Drawing.Point(119, 245);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(42, 17);
            this.genre.TabIndex = 11;
            this.genre.Text = "[Genre]";
            this.genre.Visible = false;
            // 
            // GameCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gameCardPanel);
            this.DoubleBuffered = true;
            this.Name = "GameCard";
            this.Size = new System.Drawing.Size(245, 270);
            this.gameCardPanel.ResumeLayout(false);
            this.gameCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gameCardPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel gameName;
        private Guna.UI2.WinForms.Guna2PictureBox GameIMG;
        private Guna.UI2.WinForms.Guna2RatingStar gameRating;
        private Guna.UI2.WinForms.Guna2HtmlLabel gamePrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel Platform;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel genre;
    }
}
