namespace DB_LAB_PROJECT_GunaUI
{
    partial class searchResultsPage
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
            this.a = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.searchFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.a);
            this.guna2Panel1.Controls.Add(this.searchFlowPanel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(480, 552);
            this.guna2Panel1.TabIndex = 2;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.White;
            this.a.Location = new System.Drawing.Point(155, 15);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(176, 33);
            this.a.TabIndex = 6;
            this.a.Text = "Search Results";
            // 
            // searchFlowPanel
            // 
            this.searchFlowPanel.AutoScroll = true;
            this.searchFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.searchFlowPanel.Location = new System.Drawing.Point(0, 54);
            this.searchFlowPanel.Name = "searchFlowPanel";
            this.searchFlowPanel.Size = new System.Drawing.Size(480, 498);
            this.searchFlowPanel.TabIndex = 0;
            this.searchFlowPanel.WrapContents = false;
            // 
            // searchResultsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "searchResultsPage";
            this.Size = new System.Drawing.Size(480, 552);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel a;
        private System.Windows.Forms.FlowLayoutPanel searchFlowPanel;
    }
}
