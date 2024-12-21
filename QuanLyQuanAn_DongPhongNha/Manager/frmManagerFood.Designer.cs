namespace QuanLyQuanAn_DongPhongNha.Manager
{
    partial class frmManagerFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerFood));
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.danAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.txtTotalFood = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.ptbImageOfFood = new System.Windows.Forms.PictureBox();
            this.lblLinkImage = new System.Windows.Forms.Label();
            this.lblFoodStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNameFc = new System.Windows.Forms.Label();
            this.lblNameFood = new System.Windows.Forms.Label();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbNameFC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageOfFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.MinimumWidth = 10;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 200;
            // 
            // giaMon
            // 
            this.giaMon.HeaderText = "Giá món ăn";
            this.giaMon.MinimumWidth = 10;
            this.giaMon.Name = "giaMon";
            this.giaMon.ReadOnly = true;
            this.giaMon.Width = 200;
            // 
            // danhMuc
            // 
            this.danhMuc.HeaderText = "Ma danh muc";
            this.danhMuc.MinimumWidth = 10;
            this.danhMuc.Name = "danhMuc";
            this.danhMuc.ReadOnly = true;
            this.danhMuc.Visible = false;
            this.danhMuc.Width = 200;
            // 
            // tenMon
            // 
            this.tenMon.HeaderText = "Tên món ăn";
            this.tenMon.MinimumWidth = 10;
            this.tenMon.Name = "tenMon";
            this.tenMon.ReadOnly = true;
            this.tenMon.Width = 200;
            // 
            // maMon
            // 
            this.maMon.HeaderText = "Ma mon";
            this.maMon.MinimumWidth = 10;
            this.maMon.Name = "maMon";
            this.maMon.ReadOnly = true;
            this.maMon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.maMon.Visible = false;
            this.maMon.Width = 200;
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.AllowUserToAddRows = false;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMon,
            this.tenMon,
            this.danhMuc,
            this.giaMon,
            this.danAnh,
            this.trangThai});
            this.dgvFoodList.Location = new System.Drawing.Point(-1, 121);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            this.dgvFoodList.RowHeadersWidth = 82;
            this.dgvFoodList.RowTemplate.Height = 33;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(850, 790);
            this.dgvFoodList.TabIndex = 11;
            // 
            // danAnh
            // 
            this.danAnh.HeaderText = "Đường dẫn ảnh";
            this.danAnh.MinimumWidth = 10;
            this.danAnh.Name = "danAnh";
            this.danAnh.ReadOnly = true;
            this.danAnh.Width = 200;
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.txtSearchFood.Location = new System.Drawing.Point(198, 15);
            this.txtSearchFood.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(567, 29);
            this.txtSearchFood.TabIndex = 8;
            // 
            // txtTotalFood
            // 
            this.txtTotalFood.Enabled = false;
            this.txtTotalFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.txtTotalFood.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalFood.Location = new System.Drawing.Point(-1, 71);
            this.txtTotalFood.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalFood.Name = "txtTotalFood";
            this.txtTotalFood.ReadOnly = true;
            this.txtTotalFood.Size = new System.Drawing.Size(850, 29);
            this.txtTotalFood.TabIndex = 9;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.btnSearchFood.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.Image")));
            this.btnSearchFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFood.Location = new System.Drawing.Point(-1, 6);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(176, 44);
            this.btnSearchFood.TabIndex = 10;
            this.btnSearchFood.Text = "Tìm món ăn";
            this.btnSearchFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.cmbNameFC);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtFoodName);
            this.panel2.Controls.Add(this.txtFoodID);
            this.panel2.Controls.Add(this.btnShowFood);
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.ptbImageOfFood);
            this.panel2.Controls.Add(this.lblLinkImage);
            this.panel2.Controls.Add(this.lblFoodStatus);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblNameFc);
            this.panel2.Controls.Add(this.lblNameFood);
            this.panel2.Controls.Add(this.lblFoodID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(875, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(606, 911);
            this.panel2.TabIndex = 12;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFood.Location = new System.Drawing.Point(15, 825);
            this.btnShowFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(169, 72);
            this.btnShowFood.TabIndex = 8;
            this.btnShowFood.Text = "Hiển thị";
            this.btnShowFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowFood.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.Location = new System.Drawing.Point(294, 370);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(112, 26);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.Text = "Đang bán";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // ptbImageOfFood
            // 
            this.ptbImageOfFood.Location = new System.Drawing.Point(120, 405);
            this.ptbImageOfFood.Margin = new System.Windows.Forms.Padding(6);
            this.ptbImageOfFood.Name = "ptbImageOfFood";
            this.ptbImageOfFood.Size = new System.Drawing.Size(380, 329);
            this.ptbImageOfFood.TabIndex = 6;
            this.ptbImageOfFood.TabStop = false;
            // 
            // lblLinkImage
            // 
            this.lblLinkImage.ForeColor = System.Drawing.Color.White;
            this.lblLinkImage.Location = new System.Drawing.Point(120, 752);
            this.lblLinkImage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLinkImage.Name = "lblLinkImage";
            this.lblLinkImage.Size = new System.Drawing.Size(380, 34);
            this.lblLinkImage.TabIndex = 2;
            this.lblLinkImage.Text = "......";
            this.lblLinkImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoodStatus
            // 
            this.lblFoodStatus.AutoSize = true;
            this.lblFoodStatus.ForeColor = System.Drawing.Color.White;
            this.lblFoodStatus.Location = new System.Drawing.Point(64, 374);
            this.lblFoodStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoodStatus.Name = "lblFoodStatus";
            this.lblFoodStatus.Size = new System.Drawing.Size(99, 22);
            this.lblFoodStatus.TabIndex = 2;
            this.lblFoodStatus.Text = "Trạng thái";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(64, 299);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 22);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá";
            // 
            // lblNameFc
            // 
            this.lblNameFc.AutoSize = true;
            this.lblNameFc.ForeColor = System.Drawing.Color.White;
            this.lblNameFc.Location = new System.Drawing.Point(64, 223);
            this.lblNameFc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNameFc.Name = "lblNameFc";
            this.lblNameFc.Size = new System.Drawing.Size(96, 22);
            this.lblNameFc.TabIndex = 2;
            this.lblNameFc.Text = "Danh mục";
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.ForeColor = System.Drawing.Color.White;
            this.lblNameFood.Location = new System.Drawing.Point(64, 147);
            this.lblNameFood.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(110, 22);
            this.lblNameFood.TabIndex = 2;
            this.lblNameFood.Text = "Tên món ăn";
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.ForeColor = System.Drawing.Color.White;
            this.lblFoodID.Location = new System.Drawing.Point(64, 71);
            this.lblFoodID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(79, 22);
            this.lblFoodID.TabIndex = 2;
            this.lblFoodID.Text = "Mã món";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(223, 64);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(277, 29);
            this.txtFoodID.TabIndex = 9;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(223, 140);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(277, 29);
            this.txtFoodName.TabIndex = 10;
            this.txtFoodName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFoodName_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(223, 292);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(277, 29);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // cmbNameFC
            // 
            this.cmbNameFC.FormattingEnabled = true;
            this.cmbNameFC.Location = new System.Drawing.Point(223, 216);
            this.cmbNameFC.Name = "cmbNameFC";
            this.cmbNameFC.Size = new System.Drawing.Size(277, 29);
            this.cmbNameFC.TabIndex = 12;
            // 
            // frmManagerFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 911);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.txtTotalFood);
            this.Controls.Add(this.btnSearchFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagerFood";
            this.Text = "frmManagerFood";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageOfFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMon;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.DataGridViewTextBoxColumn danAnh;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.TextBox txtTotalFood;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.PictureBox ptbImageOfFood;
        private System.Windows.Forms.Label lblLinkImage;
        private System.Windows.Forms.Label lblFoodStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNameFc;
        private System.Windows.Forms.Label lblNameFood;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbNameFC;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodID;
    }
}