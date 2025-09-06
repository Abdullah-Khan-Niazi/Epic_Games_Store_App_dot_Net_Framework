using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace DB_LAB_PROJECT_GunaUI
{
    public class NoScrollFlowLayoutPanel : FlowLayoutPanel
    {
        private const int WS_HSCROLL = 0x00100000;
        private const int WS_VSCROLL = 0x00200000;

        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            HideScrollbars();
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            HideScrollbars();
        }

        private void HideScrollbars()
        {
            ShowScrollBar(this.Handle, SB_HORZ, false);
            ShowScrollBar(this.Handle, SB_VERT, false);
        }
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            // Do nothing: disables mouse wheel scrolling
        }
    }

    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.controlBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dashBoardPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.verticalFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.profilePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.userIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.currentUserNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.signINButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.horizontalCardsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.horizontalFlowPanel = new DB_LAB_PROJECT_GunaUI.NoScrollFlowLayoutPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rightButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.leftButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.topSellingTopRatedPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.TopRatedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TopSellingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.myCartButton = new Guna.UI2.WinForms.Guna2Button();
            this.myGamesButton = new Guna.UI2.WinForms.Guna2Button();
            this.homePageButton = new Guna.UI2.WinForms.Guna2Button();
            this.addGamesButton = new Guna.UI2.WinForms.Guna2Button();
            this.editGamesButton = new Guna.UI2.WinForms.Guna2Button();
            this.editUsersButton = new Guna.UI2.WinForms.Guna2Button();
            this.controlBarPanel.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.dashBoardPanel.SuspendLayout();
            this.verticalFlowPanel.SuspendLayout();
            this.searchBarPanel.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.horizontalCardsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.topSellingTopRatedPanel.SuspendLayout();
            this.menuBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.controlBarPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // controlBarPanel
            // 
            this.controlBarPanel.BackColor = System.Drawing.Color.DimGray;
            this.controlBarPanel.Controls.Add(this.guna2ControlBox3);
            this.controlBarPanel.Controls.Add(this.guna2HtmlLabel4);
            this.controlBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBarPanel.Location = new System.Drawing.Point(0, 0);
            this.controlBarPanel.Name = "controlBarPanel";
            this.controlBarPanel.Size = new System.Drawing.Size(1304, 29);
            this.controlBarPanel.TabIndex = 11;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2ControlBox3.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1216, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 8;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(435, 4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(423, 17);
            this.guna2HtmlLabel4.TabIndex = 19;
            this.guna2HtmlLabel4.Text = "GAME_STORE_DB_LAB_PROJECT_23F-0017_23F-0022_BSAI-4A";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1259, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.Transparent;
            this.formPanel.Controls.Add(this.dashBoardPanel);
            this.formPanel.Controls.Add(this.menuBarPanel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formPanel.Location = new System.Drawing.Point(0, 27);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1304, 653);
            this.formPanel.TabIndex = 12;
            // 
            // dashBoardPanel
            // 
            this.dashBoardPanel.BackColor = System.Drawing.Color.Transparent;
            this.dashBoardPanel.Controls.Add(this.verticalFlowPanel);
            this.dashBoardPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dashBoardPanel.Location = new System.Drawing.Point(200, 0);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.Size = new System.Drawing.Size(1104, 653);
            this.dashBoardPanel.TabIndex = 1;
            // 
            // verticalFlowPanel
            // 
            this.verticalFlowPanel.AutoScroll = true;
            this.verticalFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.verticalFlowPanel.Controls.Add(this.searchBarPanel);
            this.verticalFlowPanel.Controls.Add(this.horizontalCardsPanel);
            this.verticalFlowPanel.Controls.Add(this.topSellingTopRatedPanel);
            this.verticalFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.verticalFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.verticalFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.verticalFlowPanel.Name = "verticalFlowPanel";
            this.verticalFlowPanel.Size = new System.Drawing.Size(1104, 653);
            this.verticalFlowPanel.TabIndex = 0;
            this.verticalFlowPanel.WrapContents = false;
            // 
            // searchBarPanel
            // 
            this.searchBarPanel.BackColor = System.Drawing.Color.Transparent;
            this.searchBarPanel.Controls.Add(this.profilePanel);
            this.searchBarPanel.Controls.Add(this.guna2Separator1);
            this.searchBarPanel.Controls.Add(this.signINButton);
            this.searchBarPanel.Controls.Add(this.searchButton);
            this.searchBarPanel.Controls.Add(this.searchBar);
            this.searchBarPanel.Location = new System.Drawing.Point(3, 3);
            this.searchBarPanel.Name = "searchBarPanel";
            this.searchBarPanel.Size = new System.Drawing.Size(1080, 78);
            this.searchBarPanel.TabIndex = 0;
            // 
            // profilePanel
            // 
            this.profilePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePanel.AutoSize = true;
            this.profilePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profilePanel.BorderColor = System.Drawing.Color.Black;
            this.profilePanel.BorderRadius = 10;
            this.profilePanel.BorderThickness = 2;
            this.profilePanel.Controls.Add(this.userIcon);
            this.profilePanel.Controls.Add(this.currentUserNameLabel);
            this.profilePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePanel.FillColor = System.Drawing.Color.Black;
            this.profilePanel.Location = new System.Drawing.Point(756, 8);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(200, 55);
            this.profilePanel.TabIndex = 24;
            // 
            // userIcon
            // 
            this.userIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userIcon.ImageRotate = 0F;
            this.userIcon.Location = new System.Drawing.Point(3, 3);
            this.userIcon.Name = "userIcon";
            this.userIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userIcon.Size = new System.Drawing.Size(49, 49);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 2;
            this.userIcon.TabStop = false;
            // 
            // currentUserNameLabel
            // 
            this.currentUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentUserNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserNameLabel.ForeColor = System.Drawing.Color.White;
            this.currentUserNameLabel.Location = new System.Drawing.Point(64, 17);
            this.currentUserNameLabel.Name = "currentUserNameLabel";
            this.currentUserNameLabel.Size = new System.Drawing.Size(133, 21);
            this.currentUserNameLabel.TabIndex = 23;
            this.currentUserNameLabel.Text = "[currentUserName]";
            this.currentUserNameLabel.MouseEnter += new System.EventHandler(this.currentUserNameLabel_MouseEnter);
            this.currentUserNameLabel.MouseLeave += new System.EventHandler(this.currentUserNameLabel_MouseLeave);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 68);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1080, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // signINButton
            // 
            this.signINButton.Animated = true;
            this.signINButton.DefaultAutoSize = true;
            this.signINButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signINButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signINButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signINButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signINButton.FillColor = System.Drawing.Color.Gray;
            this.signINButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.signINButton.ForeColor = System.Drawing.Color.White;
            this.signINButton.Location = new System.Drawing.Point(962, 22);
            this.signINButton.Name = "signINButton";
            this.signINButton.Size = new System.Drawing.Size(68, 24);
            this.signINButton.TabIndex = 3;
            this.signINButton.Text = "Sign In";
            this.signINButton.Click += new System.EventHandler(this.signINButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Animated = true;
            this.searchButton.AutoRoundedCorners = true;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchButton.FillColor = System.Drawing.Color.Gray;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(498, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 33);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.Animated = true;
            this.searchBar.AutoRoundedCorners = true;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.DefaultText = "";
            this.searchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.searchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.Location = new System.Drawing.Point(20, 22);
            this.searchBar.Name = "searchBar";
            this.searchBar.PlaceholderText = "";
            this.searchBar.SelectedText = "";
            this.searchBar.Size = new System.Drawing.Size(449, 33);
            this.searchBar.TabIndex = 0;
            // 
            // horizontalCardsPanel
            // 
            this.horizontalCardsPanel.BackColor = System.Drawing.Color.Transparent;
            this.horizontalCardsPanel.Controls.Add(this.guna2PictureBox2);
            this.horizontalCardsPanel.Controls.Add(this.guna2HtmlLabel9);
            this.horizontalCardsPanel.Controls.Add(this.guna2HtmlLabel8);
            this.horizontalCardsPanel.Controls.Add(this.horizontalFlowPanel);
            this.horizontalCardsPanel.Controls.Add(this.guna2HtmlLabel1);
            this.horizontalCardsPanel.Controls.Add(this.rightButton);
            this.horizontalCardsPanel.Controls.Add(this.leftButton);
            this.horizontalCardsPanel.Location = new System.Drawing.Point(3, 87);
            this.horizontalCardsPanel.Name = "horizontalCardsPanel";
            this.horizontalCardsPanel.Size = new System.Drawing.Size(1080, 725);
            this.horizontalCardsPanel.TabIndex = 1;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 10;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(536, 21);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(494, 188);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(30, 60);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(478, 23);
            this.guna2HtmlLabel9.TabIndex = 6;
            this.guna2HtmlLabel9.Text = "Find your favorite games and discover exciting new adventures!";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(30, 21);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(400, 33);
            this.guna2HtmlLabel8.TabIndex = 5;
            this.guna2HtmlLabel8.Text = "  Welcome to the Epic Games Store";
            // 
            // horizontalFlowPanel
            // 
            this.horizontalFlowPanel.AutoScroll = true;
            this.horizontalFlowPanel.Location = new System.Drawing.Point(30, 264);
            this.horizontalFlowPanel.Name = "horizontalFlowPanel";
            this.horizontalFlowPanel.Size = new System.Drawing.Size(1000, 280);
            this.horizontalFlowPanel.TabIndex = 4;
            this.horizontalFlowPanel.WrapContents = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(30, 234);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(141, 24);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Available Games";
            // 
            // rightButton
            // 
            this.rightButton.Animated = true;
            this.rightButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.rightButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.rightButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rightButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.rightButton.FillColor = System.Drawing.Color.Gray;
            this.rightButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.rightButton.ForeColor = System.Drawing.Color.White;
            this.rightButton.Location = new System.Drawing.Point(997, 225);
            this.rightButton.Name = "rightButton";
            this.rightButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.rightButton.Size = new System.Drawing.Size(33, 33);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = ">";
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Animated = true;
            this.leftButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.leftButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.leftButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leftButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.leftButton.FillColor = System.Drawing.Color.Gray;
            this.leftButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.leftButton.ForeColor = System.Drawing.Color.White;
            this.leftButton.Location = new System.Drawing.Point(958, 225);
            this.leftButton.Name = "leftButton";
            this.leftButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.leftButton.Size = new System.Drawing.Size(33, 33);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "<";
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // topSellingTopRatedPanel
            // 
            this.topSellingTopRatedPanel.BackColor = System.Drawing.Color.Transparent;
            this.topSellingTopRatedPanel.Controls.Add(this.guna2VSeparator2);
            this.topSellingTopRatedPanel.Controls.Add(this.TopRatedPanel);
            this.topSellingTopRatedPanel.Controls.Add(this.guna2HtmlLabel3);
            this.topSellingTopRatedPanel.Controls.Add(this.guna2HtmlLabel2);
            this.topSellingTopRatedPanel.Controls.Add(this.TopSellingPanel);
            this.topSellingTopRatedPanel.Location = new System.Drawing.Point(3, 818);
            this.topSellingTopRatedPanel.Name = "topSellingTopRatedPanel";
            this.topSellingTopRatedPanel.Size = new System.Drawing.Size(1072, 622);
            this.topSellingTopRatedPanel.TabIndex = 2;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(526, 83);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 499);
            this.guna2VSeparator2.TabIndex = 11;
            // 
            // TopRatedPanel
            // 
            this.TopRatedPanel.Location = new System.Drawing.Point(572, 83);
            this.TopRatedPanel.Name = "TopRatedPanel";
            this.TopRatedPanel.Size = new System.Drawing.Size(458, 499);
            this.TopRatedPanel.TabIndex = 10;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(572, 44);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(90, 24);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Top Rated";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(30, 44);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(96, 24);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Top Selling";
            // 
            // TopSellingPanel
            // 
            this.TopSellingPanel.Location = new System.Drawing.Point(30, 83);
            this.TopSellingPanel.Name = "TopSellingPanel";
            this.TopSellingPanel.Size = new System.Drawing.Size(458, 499);
            this.TopSellingPanel.TabIndex = 7;
            // 
            // menuBarPanel
            // 
            this.menuBarPanel.BackColor = System.Drawing.Color.Black;
            this.menuBarPanel.Controls.Add(this.guna2HtmlLabel5);
            this.menuBarPanel.Controls.Add(this.guna2HtmlLabel6);
            this.menuBarPanel.Controls.Add(this.guna2HtmlLabel7);
            this.menuBarPanel.Controls.Add(this.guna2VSeparator1);
            this.menuBarPanel.Controls.Add(this.guna2PictureBox1);
            this.menuBarPanel.Controls.Add(this.myCartButton);
            this.menuBarPanel.Controls.Add(this.myGamesButton);
            this.menuBarPanel.Controls.Add(this.homePageButton);
            this.menuBarPanel.Controls.Add(this.addGamesButton);
            this.menuBarPanel.Controls.Add(this.editGamesButton);
            this.menuBarPanel.Controls.Add(this.editUsersButton);
            this.menuBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuBarPanel.Location = new System.Drawing.Point(0, 0);
            this.menuBarPanel.Name = "menuBarPanel";
            this.menuBarPanel.Size = new System.Drawing.Size(200, 653);
            this.menuBarPanel.TabIndex = 0;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(3, 568);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(103, 21);
            this.guna2HtmlLabel5.TabIndex = 24;
            this.guna2HtmlLabel5.Text = "Developed By:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(49, 596);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(140, 21);
            this.guna2HtmlLabel6.TabIndex = 25;
            this.guna2HtmlLabel6.Text = "Abdullah Khan Niazi";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(49, 623);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(134, 21);
            this.guna2HtmlLabel7.TabIndex = 26;
            this.guna2HtmlLabel7.Text = "Muhammed Ahmed";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2VSeparator1.Location = new System.Drawing.Point(190, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 653);
            this.guna2VSeparator1.TabIndex = 20;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(21, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(158, 133);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // myCartButton
            // 
            this.myCartButton.Animated = true;
            this.myCartButton.BackColor = System.Drawing.Color.Black;
            this.myCartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.myCartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.myCartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.myCartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.myCartButton.FillColor = System.Drawing.Color.Black;
            this.myCartButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.myCartButton.ForeColor = System.Drawing.Color.White;
            this.myCartButton.Location = new System.Drawing.Point(0, 251);
            this.myCartButton.Name = "myCartButton";
            this.myCartButton.Size = new System.Drawing.Size(200, 45);
            this.myCartButton.TabIndex = 18;
            this.myCartButton.Text = "My Cart";
            this.myCartButton.Click += new System.EventHandler(this.myCartButton_Click);
            // 
            // myGamesButton
            // 
            this.myGamesButton.Animated = true;
            this.myGamesButton.BackColor = System.Drawing.Color.Black;
            this.myGamesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.myGamesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.myGamesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.myGamesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.myGamesButton.FillColor = System.Drawing.Color.Black;
            this.myGamesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.myGamesButton.ForeColor = System.Drawing.Color.White;
            this.myGamesButton.Location = new System.Drawing.Point(0, 206);
            this.myGamesButton.Name = "myGamesButton";
            this.myGamesButton.Size = new System.Drawing.Size(200, 45);
            this.myGamesButton.TabIndex = 17;
            this.myGamesButton.Text = "My Games";
            this.myGamesButton.Click += new System.EventHandler(this.myGamesButton_Click);
            // 
            // homePageButton
            // 
            this.homePageButton.Animated = true;
            this.homePageButton.BackColor = System.Drawing.Color.Black;
            this.homePageButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homePageButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homePageButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homePageButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homePageButton.FillColor = System.Drawing.Color.Black;
            this.homePageButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.homePageButton.ForeColor = System.Drawing.Color.White;
            this.homePageButton.Location = new System.Drawing.Point(0, 161);
            this.homePageButton.Name = "homePageButton";
            this.homePageButton.Size = new System.Drawing.Size(200, 45);
            this.homePageButton.TabIndex = 16;
            this.homePageButton.Text = "Home";
            this.homePageButton.Click += new System.EventHandler(this.homePageButton_Click);
            // 
            // addGamesButton
            // 
            this.addGamesButton.Animated = true;
            this.addGamesButton.BackColor = System.Drawing.Color.Black;
            this.addGamesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addGamesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addGamesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addGamesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addGamesButton.FillColor = System.Drawing.Color.Black;
            this.addGamesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.addGamesButton.ForeColor = System.Drawing.Color.White;
            this.addGamesButton.Location = new System.Drawing.Point(0, 298);
            this.addGamesButton.Name = "addGamesButton";
            this.addGamesButton.Size = new System.Drawing.Size(200, 45);
            this.addGamesButton.TabIndex = 21;
            this.addGamesButton.Text = "Add Games";
            this.addGamesButton.Click += new System.EventHandler(this.addGamesButton_Click);
            // 
            // editGamesButton
            // 
            this.editGamesButton.Animated = true;
            this.editGamesButton.BackColor = System.Drawing.Color.Black;
            this.editGamesButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editGamesButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editGamesButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editGamesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editGamesButton.FillColor = System.Drawing.Color.Black;
            this.editGamesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.editGamesButton.ForeColor = System.Drawing.Color.White;
            this.editGamesButton.Location = new System.Drawing.Point(-3, 346);
            this.editGamesButton.Name = "editGamesButton";
            this.editGamesButton.Size = new System.Drawing.Size(200, 45);
            this.editGamesButton.TabIndex = 22;
            this.editGamesButton.Text = "Edit Games";
            this.editGamesButton.Click += new System.EventHandler(this.editGamesButton_Click);
            // 
            // editUsersButton
            // 
            this.editUsersButton.Animated = true;
            this.editUsersButton.BackColor = System.Drawing.Color.Black;
            this.editUsersButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editUsersButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editUsersButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editUsersButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editUsersButton.FillColor = System.Drawing.Color.Black;
            this.editUsersButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.editUsersButton.ForeColor = System.Drawing.Color.White;
            this.editUsersButton.Location = new System.Drawing.Point(0, 396);
            this.editUsersButton.Name = "editUsersButton";
            this.editUsersButton.Size = new System.Drawing.Size(200, 45);
            this.editUsersButton.TabIndex = 23;
            this.editUsersButton.Text = "Edit Users";
            this.editUsersButton.Click += new System.EventHandler(this.editUsersButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1304, 680);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.controlBarPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controlBarPanel.ResumeLayout(false);
            this.controlBarPanel.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.dashBoardPanel.ResumeLayout(false);
            this.verticalFlowPanel.ResumeLayout(false);
            this.searchBarPanel.ResumeLayout(false);
            this.searchBarPanel.PerformLayout();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.horizontalCardsPanel.ResumeLayout(false);
            this.horizontalCardsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.topSellingTopRatedPanel.ResumeLayout(false);
            this.topSellingTopRatedPanel.PerformLayout();
            this.menuBarPanel.ResumeLayout(false);
            this.menuBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2Panel controlBarPanel;
        private Guna.UI2.WinForms.Guna2Panel formPanel;
        private Guna.UI2.WinForms.Guna2Panel menuBarPanel;
        private Guna.UI2.WinForms.Guna2Panel dashBoardPanel;
        private System.Windows.Forms.FlowLayoutPanel verticalFlowPanel;
        private Guna.UI2.WinForms.Guna2Panel searchBarPanel;
        private Guna.UI2.WinForms.Guna2Panel horizontalCardsPanel;
        private Guna.UI2.WinForms.Guna2Panel topSellingTopRatedPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton rightButton;
        private Guna.UI2.WinForms.Guna2CircleButton leftButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userIcon;
        private Guna.UI2.WinForms.Guna2Button searchButton;
        private Guna.UI2.WinForms.Guna2Button myCartButton;
        private Guna.UI2.WinForms.Guna2Button myGamesButton;
        private Guna.UI2.WinForms.Guna2Button homePageButton;
        private Guna.UI2.WinForms.Guna2Button signINButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private NoScrollFlowLayoutPanel horizontalFlowPanel;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button addGamesButton;
        private Guna.UI2.WinForms.Guna2Button editGamesButton;
        //private Guna.UI2.WinForms.Guna2Panel TopSellingPanel;
        //private Guna.UI2.WinForms.Guna2Panel TopRatedPanel;
        private System.Windows.Forms.FlowLayoutPanel TopSellingPanel;
        private System.Windows.Forms.FlowLayoutPanel TopRatedPanel;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2HtmlLabel currentUserNameLabel;
        private Guna.UI2.WinForms.Guna2Panel profilePanel;
        private Guna.UI2.WinForms.Guna2Button editUsersButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
    }
}

