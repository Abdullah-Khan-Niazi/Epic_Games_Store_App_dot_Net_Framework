namespace DB_LAB_PROJECT_GunaUI
{
    partial class gameCardHorizontal
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
            this.gameRating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.gamePrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gameName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GameIMG = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gameCardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.gameDescriptionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Platform = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.genre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GameIMG)).BeginInit();
            this.gameCardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameRating
            // 
            this.gameRating.BackColor = System.Drawing.Color.Black;
            this.gameRating.Location = new System.Drawing.Point(139, 88);
            this.gameRating.Name = "gameRating";
            this.gameRating.Size = new System.Drawing.Size(93, 19);
            this.gameRating.TabIndex = 3;
            // 
            // gamePrice
            // 
            this.gamePrice.BackColor = System.Drawing.Color.Transparent;
            this.gamePrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePrice.ForeColor = System.Drawing.Color.White;
            this.gamePrice.Location = new System.Drawing.Point(400, 17);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(41, 17);
            this.gamePrice.TabIndex = 2;
            this.gamePrice.Text = "[Price]";
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.Location = new System.Drawing.Point(139, 17);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(76, 17);
            this.gameName.TabIndex = 1;
            this.gameName.Text = "[Game Name]";
            // 
            // GameIMG
            // 
            this.GameIMG.BackColor = System.Drawing.Color.Black;
            this.GameIMG.BorderRadius = 7;
            this.GameIMG.FillColor = System.Drawing.Color.DarkGray;
            this.GameIMG.ImageRotate = 0F;
            this.GameIMG.Location = new System.Drawing.Point(6, 7);
            this.GameIMG.Name = "GameIMG";
            this.GameIMG.Size = new System.Drawing.Size(106, 100);
            this.GameIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameIMG.TabIndex = 0;
            this.GameIMG.TabStop = false;
            this.GameIMG.Click += new System.EventHandler(this.GameIMG_Click);
            // 
            // gameCardPanel
            // 
            this.gameCardPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameCardPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameCardPanel.BorderRadius = 10;
            this.gameCardPanel.BorderThickness = 2;
            this.gameCardPanel.Controls.Add(this.guna2HtmlLabel1);
            this.gameCardPanel.Controls.Add(this.Platform);
            this.gameCardPanel.Controls.Add(this.genre);
            this.gameCardPanel.Controls.Add(this.gameDescriptionLabel);
            this.gameCardPanel.Controls.Add(this.gameRating);
            this.gameCardPanel.Controls.Add(this.gamePrice);
            this.gameCardPanel.Controls.Add(this.gameName);
            this.gameCardPanel.Controls.Add(this.GameIMG);
            this.gameCardPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameCardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCardPanel.FillColor = System.Drawing.Color.Black;
            this.gameCardPanel.Location = new System.Drawing.Point(0, 0);
            this.gameCardPanel.Name = "gameCardPanel";
            this.gameCardPanel.Size = new System.Drawing.Size(452, 116);
            this.gameCardPanel.TabIndex = 1;
            // 
            // gameDescriptionLabel
            // 
            this.gameDescriptionLabel.AutoSize = false;
            this.gameDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameDescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDescriptionLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.gameDescriptionLabel.Location = new System.Drawing.Point(139, 42);
            this.gameDescriptionLabel.Name = "gameDescriptionLabel";
            this.gameDescriptionLabel.Size = new System.Drawing.Size(305, 40);
            this.gameDescriptionLabel.TabIndex = 4;
            this.gameDescriptionLabel.Text = "[Description]";
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.Transparent;
            this.Platform.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Platform.ForeColor = System.Drawing.Color.DarkGray;
            this.Platform.Location = new System.Drawing.Point(308, 88);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(55, 17);
            this.Platform.TabIndex = 9;
            this.Platform.Text = "[Platform]";
            this.Platform.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Platform.Visible = false;
            // 
            // genre
            // 
            this.genre.BackColor = System.Drawing.Color.Transparent;
            this.genre.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.ForeColor = System.Drawing.Color.DarkGray;
            this.genre.Location = new System.Drawing.Point(369, 88);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(42, 17);
            this.genre.TabIndex = 8;
            this.genre.Text = "[Genre]";
            this.genre.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.genre.Visible = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(390, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(10, 17);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "$";
            // 
            // gameCardHorizontal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gameCardPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "gameCardHorizontal";
            this.Size = new System.Drawing.Size(452, 116);
            ((System.ComponentModel.ISupportInitialize)(this.GameIMG)).EndInit();
            this.gameCardPanel.ResumeLayout(false);
            this.gameCardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RatingStar gameRating;
        private Guna.UI2.WinForms.Guna2HtmlLabel gamePrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel gameName;
        private Guna.UI2.WinForms.Guna2PictureBox GameIMG;
        private Guna.UI2.WinForms.Guna2Panel gameCardPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel gameDescriptionLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Platform;
        private Guna.UI2.WinForms.Guna2HtmlLabel genre;
    }
}
