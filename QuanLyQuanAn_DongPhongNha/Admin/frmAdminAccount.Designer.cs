namespace QuanLyQuanAn_DongPhongNha.Admin
{
    partial class frmAdminAccount
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
            this.txtFindAccountByName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripTim = new System.Windows.Forms.ToolStripLabel();
            this.lblTotalAccount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.colmanv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colloaitk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenhienthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.nudTypeAccount = new System.Windows.Forms.NumericUpDown();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblThongtintk = new System.Windows.Forms.Label();
            this.txtIdStaff = new System.Windows.Forms.TextBox();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lblnhaplaimk = new System.Windows.Forms.Label();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.lblTentk = new System.Windows.Forms.Label();
            this.lblloaitk = new System.Windows.Forms.Label();
            this.lblTenhienthi = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTypeAccount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFindAccountByName
            // 
            this.txtFindAccountByName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindAccountByName.Name = "txtFindAccountByName";
            this.txtFindAccountByName.Size = new System.Drawing.Size(500, 31);
            this.txtFindAccountByName.Click += new System.EventHandler(this.txtFindAccountByName_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolstripTim,
            this.txtFindAccountByName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(759, 31);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstripTim
            // 
            this.toolstripTim.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripTim.Name = "toolstripTim";
            this.toolstripTim.Size = new System.Drawing.Size(202, 26);
            this.toolstripTim.Text = "Tìm kiếm tài khoản";
            // 
            // lblTotalAccount
            // 
            this.lblTotalAccount.AutoSize = true;
            this.lblTotalAccount.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAccount.Location = new System.Drawing.Point(21, 16);
            this.lblTotalAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAccount.Name = "lblTotalAccount";
            this.lblTotalAccount.Size = new System.Drawing.Size(195, 25);
            this.lblTotalAccount.TabIndex = 3;
            this.lblTotalAccount.Text = "Tổng số tài khoản: ";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.lblTotalAccount);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 75);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1107, 66);
            this.panel5.TabIndex = 38;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAccount.Location = new System.Drawing.Point(829, 48);
            this.btnShowAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(190, 90);
            this.btnShowAccount.TabIndex = 30;
            this.btnShowAccount.Text = "Hiển thị";
            this.btnShowAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccount.Location = new System.Drawing.Point(123, 48);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(196, 90);
            this.btnAddAccount.TabIndex = 27;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.Location = new System.Drawing.Point(587, 48);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(196, 90);
            this.btnDeleteAccount.TabIndex = 29;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAccount.Location = new System.Drawing.Point(354, 48);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(196, 90);
            this.btnEditAccount.TabIndex = 28;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.btnShowAccount);
            this.panel4.Controls.Add(this.btnAddAccount);
            this.panel4.Controls.Add(this.btnDeleteAccount);
            this.panel4.Controls.Add(this.btnEditAccount);
            this.panel4.Location = new System.Drawing.Point(0, 932);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1107, 181);
            this.panel4.TabIndex = 37;
            // 
            // colmanv
            // 
            this.colmanv.HeaderText = "Mã nhân viên ";
            this.colmanv.MinimumWidth = 6;
            this.colmanv.Name = "colmanv";
            this.colmanv.ReadOnly = true;
            this.colmanv.Width = 125;
            // 
            // colloaitk
            // 
            this.colloaitk.HeaderText = "Loại tài khoản ";
            this.colloaitk.MinimumWidth = 6;
            this.colloaitk.Name = "colloaitk";
            this.colloaitk.ReadOnly = true;
            this.colloaitk.Width = 125;
            // 
            // coltenhienthi
            // 
            this.coltenhienthi.HeaderText = "Tên hiển thị ";
            this.coltenhienthi.MinimumWidth = 6;
            this.coltenhienthi.Name = "coltenhienthi";
            this.coltenhienthi.ReadOnly = true;
            this.coltenhienthi.Width = 125;
            // 
            // coltentk
            // 
            this.coltentk.HeaderText = "Tên tài khoản ";
            this.coltentk.MinimumWidth = 6;
            this.coltentk.Name = "coltentk";
            this.coltentk.ReadOnly = true;
            this.coltentk.Width = 125;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coltentk,
            this.coltenhienthi,
            this.colloaitk,
            this.colmanv});
            this.dgvAccount.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAccount.Location = new System.Drawing.Point(0, 152);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(1107, 681);
            this.dgvAccount.TabIndex = 36;
            this.dgvAccount.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_CellMouseClick);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.Location = new System.Drawing.Point(128, 865);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(325, 112);
            this.btnResetPassword.TabIndex = 19;
            this.btnResetPassword.Text = "Đặt lại mật khẩu ";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // nudTypeAccount
            // 
            this.nudTypeAccount.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTypeAccount.Location = new System.Drawing.Point(308, 600);
            this.nudTypeAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nudTypeAccount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTypeAccount.Name = "nudTypeAccount";
            this.nudTypeAccount.Size = new System.Drawing.Size(183, 29);
            this.nudTypeAccount.TabIndex = 24;
            this.nudTypeAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(309, 274);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(184, 29);
            this.txtAccountName.TabIndex = 10;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.Location = new System.Drawing.Point(309, 714);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(184, 29);
            this.txtDisplayName.TabIndex = 13;
            // 
            // lblThongtintk
            // 
            this.lblThongtintk.AutoSize = true;
            this.lblThongtintk.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtintk.Location = new System.Drawing.Point(28, 152);
            this.lblThongtintk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtintk.Name = "lblThongtintk";
            this.lblThongtintk.Size = new System.Drawing.Size(292, 36);
            this.lblThongtintk.TabIndex = 2;
            this.lblThongtintk.Text = "Thông tin tài khoản ";
            // 
            // txtIdStaff
            // 
            this.txtIdStaff.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdStaff.Location = new System.Drawing.Point(309, 531);
            this.txtIdStaff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtIdStaff.Name = "txtIdStaff";
            this.txtIdStaff.Size = new System.Drawing.Size(184, 29);
            this.txtIdStaff.TabIndex = 11;
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatkhau.Location = new System.Drawing.Point(28, 369);
            this.lblmatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(109, 25);
            this.lblmatkhau.TabIndex = 4;
            this.lblmatkhau.Text = "mật khẩu ";
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanv.Location = new System.Drawing.Point(28, 538);
            this.lblmanv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(148, 25);
            this.lblmanv.TabIndex = 8;
            this.lblmanv.Text = "Mã nhân viên ";
            // 
            // lblnhaplaimk
            // 
            this.lblnhaplaimk.AutoSize = true;
            this.lblnhaplaimk.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhaplaimk.Location = new System.Drawing.Point(30, 450);
            this.lblnhaplaimk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnhaplaimk.Name = "lblnhaplaimk";
            this.lblnhaplaimk.Size = new System.Drawing.Size(194, 25);
            this.lblnhaplaimk.TabIndex = 5;
            this.lblnhaplaimk.Text = "Nhập lại mật khẩu ";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword.Location = new System.Drawing.Point(309, 444);
            this.txtRetypePassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.Size = new System.Drawing.Size(184, 29);
            this.txtRetypePassword.TabIndex = 14;
            // 
            // lblTentk
            // 
            this.lblTentk.AutoSize = true;
            this.lblTentk.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentk.Location = new System.Drawing.Point(28, 280);
            this.lblTentk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTentk.Name = "lblTentk";
            this.lblTentk.Size = new System.Drawing.Size(145, 25);
            this.lblTentk.TabIndex = 3;
            this.lblTentk.Text = "Tên tài khoản";
            // 
            // lblloaitk
            // 
            this.lblloaitk.AutoSize = true;
            this.lblloaitk.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloaitk.Location = new System.Drawing.Point(28, 619);
            this.lblloaitk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblloaitk.Name = "lblloaitk";
            this.lblloaitk.Size = new System.Drawing.Size(156, 25);
            this.lblloaitk.TabIndex = 7;
            this.lblloaitk.Text = "Loại tài khoản ";
            // 
            // lblTenhienthi
            // 
            this.lblTenhienthi.AutoSize = true;
            this.lblTenhienthi.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenhienthi.Location = new System.Drawing.Point(30, 720);
            this.lblTenhienthi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenhienthi.Name = "lblTenhienthi";
            this.lblTenhienthi.Size = new System.Drawing.Size(135, 25);
            this.lblTenhienthi.TabIndex = 6;
            this.lblTenhienthi.Text = "Tên hiển thị ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(309, 365);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 29);
            this.txtPassword.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnResetPassword);
            this.panel1.Controls.Add(this.nudTypeAccount);
            this.panel1.Controls.Add(this.txtAccountName);
            this.panel1.Controls.Add(this.txtDisplayName);
            this.panel1.Controls.Add(this.lblThongtintk);
            this.panel1.Controls.Add(this.txtIdStaff);
            this.panel1.Controls.Add(this.lblmatkhau);
            this.panel1.Controls.Add(this.lblmanv);
            this.panel1.Controls.Add(this.lblnhaplaimk);
            this.panel1.Controls.Add(this.txtRetypePassword);
            this.panel1.Controls.Add(this.lblTentk);
            this.panel1.Controls.Add(this.lblloaitk);
            this.panel1.Controls.Add(this.lblTenhienthi);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1151, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 1139);
            this.panel1.TabIndex = 35;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QuanLyQuanAn_DongPhongNha.Properties.Resources.search;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 26);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // frmAdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 1139);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdminAccount";
            this.Text = "frmAdminAccount";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTypeAccount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripTextBox txtFindAccountByName;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolstripTim;
        private System.Windows.Forms.Label lblTotalAccount;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmanv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colloaitk;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenhienthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltentk;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.NumericUpDown nudTypeAccount;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblThongtintk;
        private System.Windows.Forms.TextBox txtIdStaff;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lblnhaplaimk;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Label lblTentk;
        private System.Windows.Forms.Label lblloaitk;
        private System.Windows.Forms.Label lblTenhienthi;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}