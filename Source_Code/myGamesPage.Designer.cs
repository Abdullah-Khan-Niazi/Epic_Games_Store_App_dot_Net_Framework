namespace DB_LAB_PROJECT_GunaUI
{
    partial class myGamesPage
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.myGamesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel1.Controls.Add(this.myGamesFlowPanel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(483, 550);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(182, 11);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(128, 33);
            this.guna2HtmlLabel8.TabIndex = 6;
            this.guna2HtmlLabel8.Text = "My Games";
            // 
            // myGamesFlowPanel
            // 
            this.myGamesFlowPanel.AutoScroll = true;
            this.myGamesFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.myGamesFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myGamesFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.myGamesFlowPanel.Location = new System.Drawing.Point(0, 52);
            this.myGamesFlowPanel.Name = "myGamesFlowPanel";
            this.myGamesFlowPanel.Size = new System.Drawing.Size(483, 498);
            this.myGamesFlowPanel.TabIndex = 0;
            this.myGamesFlowPanel.WrapContents = false;
            // 
            // myGamesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.Name = "myGamesPage";
            this.Size = new System.Drawing.Size(483, 550);
            this.Load += new System.EventHandler(this.myGamesPage_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel myGamesFlowPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
    }
}
