namespace QuanLyQuanAn_DongPhongNha.Admin
{
    partial class frmAdminCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCategory));
            this.colSomon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFoodCategory = new System.Windows.Forms.DataGridView();
            this.colTenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalCategory = new System.Windows.Forms.Label();
            this.lblTongDM = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblTenDM = new System.Windows.Forms.Label();
            this.lblMaDM = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTracuu = new System.Windows.Forms.ToolStripLabel();
            this.txtFindCategoryByName = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCategory)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colSomon
            // 
            this.colSomon.HeaderText = "Số món ăn";
            this.colSomon.MinimumWidth = 6;
            this.colSomon.Name = "colSomon";
            this.colSomon.ReadOnly = true;
            // 
            // colMaDM
            // 
            this.colMaDM.HeaderText = "Mã danh mục";
            this.colMaDM.MinimumWidth = 6;
            this.colMaDM.Name = "colMaDM";
            this.colMaDM.ReadOnly = true;
            // 
            // dgvFoodCategory
            // 
            this.dgvFoodCategory.AllowUserToAddRows = false;
            this.dgvFoodCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDM,
            this.colTenDM,
            this.colSomon});
            this.dgvFoodCategory.Location = new System.Drawing.Point(0, 101);
            this.dgvFoodCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFoodCategory.Name = "dgvFoodCategory";
            this.dgvFoodCategory.ReadOnly = true;
            this.dgvFoodCategory.RowHeadersWidth = 51;
            this.dgvFoodCategory.RowTemplate.Height = 24;
            this.dgvFoodCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodCategory.Size = new System.Drawing.Size(745, 484);
            this.dgvFoodCategory.TabIndex = 9;
            this.dgvFoodCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFoodCategory_CellMouseClick);
            // 
            // colTenDM
            // 
            this.colTenDM.HeaderText = "Tên danh mục";
            this.colTenDM.MinimumWidth = 6;
            this.colTenDM.Name = "colTenDM";
            this.colTenDM.ReadOnly = true;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowCategory.Location = new System.Drawing.Point(559, 37);
            this.btnShowCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(169, 72);
            this.btnShowCategory.TabIndex = 4;
            this.btnShowCategory.Text = "Hiển thị";
            this.btnShowCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowCategory.UseVisualStyleBackColor = true;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.Location = new System.Drawing.Point(377, 37);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(174, 72);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCategory.Location = new System.Drawing.Point(195, 37);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(174, 72);
            this.btnEditCategory.TabIndex = 1;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(13, 37);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(174, 72);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnShowCategory);
            this.panel3.Controls.Add(this.btnDeleteCategory);
            this.panel3.Controls.Add(this.btnEditCategory);
            this.panel3.Controls.Add(this.btnAddCategory);
            this.panel3.Location = new System.Drawing.Point(0, 595);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 145);
            this.panel3.TabIndex = 8;
            // 
            // lblTotalCategory
            // 
            this.lblTotalCategory.AutoSize = true;
            this.lblTotalCategory.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategory.Location = new System.Drawing.Point(237, 13);
            this.lblTotalCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCategory.Name = "lblTotalCategory";
            this.lblTotalCategory.Size = new System.Drawing.Size(15, 16);
            this.lblTotalCategory.TabIndex = 5;
            this.lblTotalCategory.Text = "0";
            // 
            // lblTongDM
            // 
            this.lblTongDM.AutoSize = true;
            this.lblTongDM.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDM.Location = new System.Drawing.Point(19, 13);
            this.lblTongDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDM.Name = "lblTongDM";
            this.lblTongDM.Size = new System.Drawing.Size(106, 16);
            this.lblTongDM.TabIndex = 3;
            this.lblTongDM.Text = "Tổng danh mục:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTotalCategory);
            this.panel2.Controls.Add(this.lblTongDM);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 53);
            this.panel2.TabIndex = 7;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(148, 440);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(193, 23);
            this.txtCategoryName.TabIndex = 4;
            this.txtCategoryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoryName_KeyPress);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryID.Location = new System.Drawing.Point(148, 343);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(193, 23);
            this.txtCategoryID.TabIndex = 3;
            // 
            // lblTenDM
            // 
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDM.ForeColor = System.Drawing.Color.White;
            this.lblTenDM.Location = new System.Drawing.Point(46, 443);
            this.lblTenDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(94, 16);
            this.lblTenDM.TabIndex = 2;
            this.lblTenDM.Text = "Tên danh mục";
            // 
            // lblMaDM
            // 
            this.lblMaDM.AutoSize = true;
            this.lblMaDM.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDM.ForeColor = System.Drawing.Color.White;
            this.lblMaDM.Location = new System.Drawing.Point(46, 346);
            this.lblMaDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDM.Name = "lblMaDM";
            this.lblMaDM.Size = new System.Drawing.Size(90, 16);
            this.lblMaDM.TabIndex = 1;
            this.lblMaDM.Text = "Mã danh mục";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(45, 227);
            this.lblThongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(191, 23);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "Thông tin danh mục";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtCategoryName);
            this.panel1.Controls.Add(this.txtCategoryID);
            this.panel1.Controls.Add(this.lblTenDM);
            this.panel1.Controls.Add(this.lblMaDM);
            this.panel1.Controls.Add(this.lblThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(753, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 740);
            this.panel1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripTracuu,
            this.txtFindCategoryByName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(522, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Tra cứu danh mục";
            // 
            // toolStripTracuu
            // 
            this.toolStripTracuu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripTracuu.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTracuu.Name = "toolStripTracuu";
            this.toolStripTracuu.Size = new System.Drawing.Size(132, 22);
            this.toolStripTracuu.Text = "Tra cứu danh mục";
            // 
            // txtFindCategoryByName
            // 
            this.txtFindCategoryByName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindCategoryByName.Name = "txtFindCategoryByName";
            this.txtFindCategoryByName.Size = new System.Drawing.Size(350, 25);
            this.txtFindCategoryByName.TextChanged += new System.EventHandler(this.txtFindCategoryByName_TextChanged);
            // 
            // frmAdminCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 740);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvFoodCategory);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminCategory";
            this.Text = "frmAdminCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCategory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colSomon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDM;
        private System.Windows.Forms.DataGridView dgvFoodCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDM;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalCategory;
        private System.Windows.Forms.Label lblTongDM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblTenDM;
        private System.Windows.Forms.Label lblMaDM;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripTracuu;
        private System.Windows.Forms.ToolStripTextBox txtFindCategoryByName;
    }
}