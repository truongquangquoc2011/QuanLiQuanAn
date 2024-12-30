namespace QuanLyQuanAn_DongPhongNha.Manager
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cbkCheckPassWord = new System.Windows.Forms.CheckBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.ptbPassWord = new System.Windows.Forms.PictureBox();
            this.ptbUserName = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbkCheckPassWord
            // 
            this.cbkCheckPassWord.AutoSize = true;
            this.cbkCheckPassWord.BackColor = System.Drawing.Color.Transparent;
            this.cbkCheckPassWord.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkCheckPassWord.ForeColor = System.Drawing.Color.White;
            this.cbkCheckPassWord.Location = new System.Drawing.Point(478, 296);
            this.cbkCheckPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.cbkCheckPassWord.Name = "cbkCheckPassWord";
            this.cbkCheckPassWord.Size = new System.Drawing.Size(156, 23);
            this.cbkCheckPassWord.TabIndex = 12;
            this.cbkCheckPassWord.Text = "Hiển thị mật khẩu";
            this.cbkCheckPassWord.UseVisualStyleBackColor = false;
            this.cbkCheckPassWord.CheckedChanged += new System.EventHandler(this.cbkCheckPassWord_CheckedChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(441, 323);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(193, 36);
            this.btnLogIn.TabIndex = 13;
            this.btnLogIn.Text = "ĐĂNG NHẬP";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(478, 260);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(159, 31);
            this.txtPassWord.TabIndex = 9;
            this.txtPassWord.Enter += new System.EventHandler(this.txtPassWord_Enter);
            this.txtPassWord.Leave += new System.EventHandler(this.txtPassWord_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(478, 169);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(159, 31);
            this.txtUser.TabIndex = 8;
            this.txtUser.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbExit
            // 
            this.ptbExit.BackColor = System.Drawing.Color.Transparent;
            this.ptbExit.BackgroundImage = global::QuanLyQuanAn_DongPhongNha.Properties.Resources.Screenshot_2024_12_05_181838;
            this.ptbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbExit.Location = new System.Drawing.Point(794, 25);
            this.ptbExit.Margin = new System.Windows.Forms.Padding(2);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(33, 38);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 14;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // ptbPassWord
            // 
            this.ptbPassWord.BackColor = System.Drawing.Color.White;
            this.ptbPassWord.Image = ((System.Drawing.Image)(resources.GetObject("ptbPassWord.Image")));
            this.ptbPassWord.Location = new System.Drawing.Point(431, 251);
            this.ptbPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.ptbPassWord.Name = "ptbPassWord";
            this.ptbPassWord.Size = new System.Drawing.Size(38, 40);
            this.ptbPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPassWord.TabIndex = 10;
            this.ptbPassWord.TabStop = false;
            // 
            // ptbUserName
            // 
            this.ptbUserName.BackColor = System.Drawing.Color.White;
            this.ptbUserName.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbUserName.ErrorImage")));
            this.ptbUserName.Image = ((System.Drawing.Image)(resources.GetObject("ptbUserName.Image")));
            this.ptbUserName.Location = new System.Drawing.Point(431, 160);
            this.ptbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.ptbUserName.Name = "ptbUserName";
            this.ptbUserName.Size = new System.Drawing.Size(38, 40);
            this.ptbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUserName.TabIndex = 11;
            this.ptbUserName.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::QuanLyQuanAn_DongPhongNha.Properties.Resources._469095960_1607615440150776_5157970610393270350_n;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(242, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyQuanAn_DongPhongNha.Properties.Resources.background_am_thuc_dep_nhat_081312859;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 401);
            this.Controls.Add(this.cbkCheckPassWord);
            this.Controls.Add(this.ptbExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.ptbPassWord);
            this.Controls.Add(this.ptbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbkCheckPassWord;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox ptbPassWord;
        private System.Windows.Forms.PictureBox ptbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}