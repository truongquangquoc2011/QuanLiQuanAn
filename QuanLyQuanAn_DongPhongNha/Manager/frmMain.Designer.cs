﻿namespace QuanLyQuanAn_DongPhongNha.Manager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClock = new System.Windows.Forms.Label();
            this.btnDisplayName = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlSubAdmin = new System.Windows.Forms.Panel();
            this.btnOpenFormAccount = new System.Windows.Forms.Button();
            this.btnOpenFormStaff = new System.Windows.Forms.Button();
            this.btnOpenFromTable = new System.Windows.Forms.Button();
            this.btnOpenFormCategory = new System.Windows.Forms.Button();
            this.btnOpenFormFood = new System.Windows.Forms.Button();
            this.btnOpenFormRevenue = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnOpenFormAttendance = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlSubAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblClock);
            this.panel1.Controls.Add(this.btnDisplayName);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1933, 172);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.White;
            this.lblClock.Location = new System.Drawing.Point(929, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(269, 71);
            this.lblClock.TabIndex = 2;
            this.lblClock.Text = "...";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDisplayName
            // 
            this.btnDisplayName.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDisplayName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDisplayName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDisplayName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayName.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayName.ForeColor = System.Drawing.Color.White;
            this.btnDisplayName.Location = new System.Drawing.Point(1205, 0);
            this.btnDisplayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplayName.Name = "btnDisplayName";
            this.btnDisplayName.Size = new System.Drawing.Size(269, 71);
            this.btnDisplayName.TabIndex = 1;
            this.btnDisplayName.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(549, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(622, 78);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang chủ";
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.DimGray;
            this.pnlMenu.Controls.Add(this.btnInfo);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.pnlSubAdmin);
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnOpenFormAttendance);
            this.pnlMenu.Controls.Add(this.btnFind);
            this.pnlMenu.Controls.Add(this.btnOrder);
            this.pnlMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 172);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 1142);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Linen;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(0, 466);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(240, 55);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "Thông tin";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Silver;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 1051);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(240, 55);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1106);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 36);
            this.panel2.TabIndex = 8;
            // 
            // pnlSubAdmin
            // 
            this.pnlSubAdmin.Controls.Add(this.btnOpenFormAccount);
            this.pnlSubAdmin.Controls.Add(this.btnOpenFormStaff);
            this.pnlSubAdmin.Controls.Add(this.btnOpenFromTable);
            this.pnlSubAdmin.Controls.Add(this.btnOpenFormCategory);
            this.pnlSubAdmin.Controls.Add(this.btnOpenFormFood);
            this.pnlSubAdmin.Controls.Add(this.btnOpenFormRevenue);
            this.pnlSubAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubAdmin.Location = new System.Drawing.Point(0, 232);
            this.pnlSubAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSubAdmin.Name = "pnlSubAdmin";
            this.pnlSubAdmin.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.pnlSubAdmin.Size = new System.Drawing.Size(240, 234);
            this.pnlSubAdmin.TabIndex = 5;
            // 
            // btnOpenFormAccount
            // 
            this.btnOpenFormAccount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFormAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFormAccount.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFormAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenFormAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOpenFormAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFormAccount.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFormAccount.Location = new System.Drawing.Point(7, 195);
            this.btnOpenFormAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFormAccount.Name = "btnOpenFormAccount";
            this.btnOpenFormAccount.Size = new System.Drawing.Size(226, 39);
            this.btnOpenFormAccount.TabIndex = 8;
            this.btnOpenFormAccount.Text = "Tài khoản";
            this.btnOpenFormAccount.UseVisualStyleBackColor = false;
            this.btnOpenFormAccount.Click += new System.EventHandler(this.btnOpenFormAccount_Click);
            // 
            // btnOpenFormStaff
            // 
            this.btnOpenFormStaff.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFormStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFormStaff.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFormStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenFormStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOpenFormStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFormStaff.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFormStaff.Location = new System.Drawing.Point(7, 156);
            this.btnOpenFormStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFormStaff.Name = "btnOpenFormStaff";
            this.btnOpenFormStaff.Size = new System.Drawing.Size(226, 39);
            this.btnOpenFormStaff.TabIndex = 7;
            this.btnOpenFormStaff.Text = "Nhân viên";
            this.btnOpenFormStaff.UseVisualStyleBackColor = false;
            this.btnOpenFormStaff.Click += new System.EventHandler(this.btnOpenFormStaff_Click);
            // 
            // btnOpenFromTable
            // 
            this.btnOpenFromTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFromTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFromTable.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFromTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenFromTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOpenFromTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFromTable.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFromTable.Location = new System.Drawing.Point(7, 117);
            this.btnOpenFromTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFromTable.Name = "btnOpenFromTable";
            this.btnOpenFromTable.Size = new System.Drawing.Size(226, 39);
            this.btnOpenFromTable.TabIndex = 6;
            this.btnOpenFromTable.Text = "Bàn ăn";
            this.btnOpenFromTable.UseVisualStyleBackColor = false;
            this.btnOpenFromTable.Click += new System.EventHandler(this.btnOpenFromTable_Click);
            // 
            // btnOpenFormCategory
            // 
            this.btnOpenFormCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFormCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFormCategory.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFormCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenFormCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOpenFormCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFormCategory.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFormCategory.Location = new System.Drawing.Point(7, 78);
            this.btnOpenFormCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFormCategory.Name = "btnOpenFormCategory";
            this.btnOpenFormCategory.Size = new System.Drawing.Size(226, 39);
            this.btnOpenFormCategory.TabIndex = 5;
            this.btnOpenFormCategory.Text = "Danh mục món";
            this.btnOpenFormCategory.UseVisualStyleBackColor = false;
            this.btnOpenFormCategory.Click += new System.EventHandler(this.btnOpenFormCategory_Click);
            // 
            // btnOpenFormFood
            // 
            this.btnOpenFormFood.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFormFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFormFood.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFormFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenFormFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOpenFormFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFormFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFormFood.Location = new System.Drawing.Point(7, 39);
            this.btnOpenFormFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFormFood.Name = "btnOpenFormFood";
            this.btnOpenFormFood.Size = new System.Drawing.Size(226, 39);
            this.btnOpenFormFood.TabIndex = 4;
            this.btnOpenFormFood.Text = "Món ăn";
            this.btnOpenFormFood.UseVisualStyleBackColor = false;
            this.btnOpenFormFood.Click += new System.EventHandler(this.btnOpenFormFood_Click);
            // 
            // btnOpenFormRevenue
            // 
            this.btnOpenFormRevenue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFormRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFormRevenue.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFormRevenue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOpenFormRevenue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnOpenFormRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFormRevenue.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFormRevenue.Location = new System.Drawing.Point(7, 0);
            this.btnOpenFormRevenue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFormRevenue.Name = "btnOpenFormRevenue";
            this.btnOpenFormRevenue.Size = new System.Drawing.Size(226, 39);
            this.btnOpenFormRevenue.TabIndex = 3;
            this.btnOpenFormRevenue.Text = "Thống kê";
            this.btnOpenFormRevenue.UseVisualStyleBackColor = false;
            this.btnOpenFormRevenue.Click += new System.EventHandler(this.btnOpenFormRevenue_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Linen;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(0, 177);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(240, 55);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Quản lý";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnOpenFormAttendance
            // 
            this.btnOpenFormAttendance.BackColor = System.Drawing.Color.Linen;
            this.btnOpenFormAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFormAttendance.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOpenFormAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.btnOpenFormAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOpenFormAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFormAttendance.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFormAttendance.Location = new System.Drawing.Point(0, 122);
            this.btnOpenFormAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenFormAttendance.Name = "btnOpenFormAttendance";
            this.btnOpenFormAttendance.Size = new System.Drawing.Size(240, 55);
            this.btnOpenFormAttendance.TabIndex = 3;
            this.btnOpenFormAttendance.Text = "Chấm công";
            this.btnOpenFormAttendance.UseVisualStyleBackColor = false;
            this.btnOpenFormAttendance.Click += new System.EventHandler(this.btnOpenFormAttendance_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Linen;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(0, 67);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(240, 55);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tra cứu";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Linen;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(0, 12);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(240, 55);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Đặt món";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 12);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDesktop.Location = new System.Drawing.Point(246, 180);
            this.pnlDesktop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1666, 1139);
            this.pnlDesktop.TabIndex = 4;
            this.pnlDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDesktop_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1933, 1314);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1930, 1258);
            this.Name = "frmMain";
            this.Text = "Giao Dien Quan Ly ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnDisplayName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSubAdmin;
        private System.Windows.Forms.Button btnOpenFormAccount;
        private System.Windows.Forms.Button btnOpenFormStaff;
        private System.Windows.Forms.Button btnOpenFromTable;
        private System.Windows.Forms.Button btnOpenFormCategory;
        private System.Windows.Forms.Button btnOpenFormFood;
        private System.Windows.Forms.Button btnOpenFormRevenue;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnOpenFormAttendance;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlDesktop;
    }
    }