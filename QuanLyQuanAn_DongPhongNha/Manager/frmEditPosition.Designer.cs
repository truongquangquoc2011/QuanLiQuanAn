namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmEditPosition
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
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.btnShowPosition = new System.Windows.Forms.Button();
            this.btnEditPosition = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.txtPositionName = new System.Windows.Forms.TextBox();
            this.txtPositionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaban = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.lblTotalPosition = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFindPositionByName = new System.Windows.Forms.ToolStripTextBox();
            this.toolstripTim = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbExit
            // 
            this.ptbExit.BackColor = System.Drawing.Color.Transparent;
            this.ptbExit.Image = global::QuanLyQuanAn_DongPhongNha.Properties.Resources.z6153570384406_f9d6f96bab6a29a8cea819ba4fbcbb64;
            this.ptbExit.Location = new System.Drawing.Point(396, 708);
            this.ptbExit.Margin = new System.Windows.Forms.Padding(4);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(77, 71);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 19;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // btnShowPosition
            // 
            this.btnShowPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowPosition.Location = new System.Drawing.Point(284, 528);
            this.btnShowPosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnShowPosition.Name = "btnShowPosition";
            this.btnShowPosition.Size = new System.Drawing.Size(228, 94);
            this.btnShowPosition.TabIndex = 18;
            this.btnShowPosition.Text = "Hiển thị";
            this.btnShowPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowPosition.UseVisualStyleBackColor = true;
            this.btnShowPosition.Click += new System.EventHandler(this.btnShowPosition_Click);
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPosition.Location = new System.Drawing.Point(284, 386);
            this.btnEditPosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(228, 94);
            this.btnEditPosition.TabIndex = 16;
            this.btnEditPosition.Text = "Sửa";
            this.btnEditPosition.UseVisualStyleBackColor = true;
            this.btnEditPosition.Click += new System.EventHandler(this.btnEditPosition_Click);
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePosition.Location = new System.Drawing.Point(36, 528);
            this.btnDeletePosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(228, 94);
            this.btnDeletePosition.TabIndex = 17;
            this.btnDeletePosition.Text = "Xóa";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // txtPositionName
            // 
            this.txtPositionName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionName.Location = new System.Drawing.Point(184, 274);
            this.txtPositionName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(303, 25);
            this.txtPositionName.TabIndex = 13;
            this.txtPositionName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPositionName_KeyPress);
            // 
            // txtPositionID
            // 
            this.txtPositionID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionID.Location = new System.Drawing.Point(184, 181);
            this.txtPositionID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPositionID.Name = "txtPositionID";
            this.txtPositionID.ReadOnly = true;
            this.txtPositionID.Size = new System.Drawing.Size(303, 25);
            this.txtPositionID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Chức Vụ";
            // 
            // lblMaban
            // 
            this.lblMaban.AutoSize = true;
            this.lblMaban.BackColor = System.Drawing.Color.DimGray;
            this.lblMaban.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaban.ForeColor = System.Drawing.Color.White;
            this.lblMaban.Location = new System.Drawing.Point(32, 181);
            this.lblMaban.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaban.Name = "lblMaban";
            this.lblMaban.Size = new System.Drawing.Size(57, 20);
            this.lblMaban.TabIndex = 12;
            this.lblMaban.Text = "Mã CV";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Cambria", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(109, 36);
            this.lblThongtin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(296, 40);
            this.lblThongtin.TabIndex = 10;
            this.lblThongtin.Text = "Thông tin chức vụ";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Chức Vụ";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã CV";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPosition.Location = new System.Drawing.Point(9, 119);
            this.dgvPosition.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            this.dgvPosition.RowHeadersWidth = 82;
            this.dgvPosition.RowTemplate.Height = 33;
            this.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosition.Size = new System.Drawing.Size(913, 726);
            this.dgvPosition.TabIndex = 24;
            this.dgvPosition.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPosition_CellMouseClick);
            // 
            // lblTotalPosition
            // 
            this.lblTotalPosition.AutoSize = true;
            this.lblTotalPosition.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPosition.Location = new System.Drawing.Point(25, 16);
            this.lblTotalPosition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalPosition.Name = "lblTotalPosition";
            this.lblTotalPosition.Size = new System.Drawing.Size(118, 20);
            this.lblTotalPosition.TabIndex = 3;
            this.lblTotalPosition.Text = "Tổng chức vụ:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTotalPosition);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(9, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 65);
            this.panel2.TabIndex = 23;
            // 
            // txtFindPositionByName
            // 
            this.txtFindPositionByName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindPositionByName.Name = "txtFindPositionByName";
            this.txtFindPositionByName.Size = new System.Drawing.Size(200, 27);
            this.txtFindPositionByName.TextChanged += new System.EventHandler(this.txtFindPositionByName_TextChanged);
            // 
            // toolstripTim
            // 
            this.toolstripTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolstripTim.Name = "toolstripTim";
            this.toolstripTim.Size = new System.Drawing.Size(152, 23);
            this.toolstripTim.Text = "Tìm kiếm chức vụ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolstripTim,
            this.txtFindPositionByName});
            this.toolStrip1.Location = new System.Drawing.Point(9, 7);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(399, 26);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPosition.Location = new System.Drawing.Point(36, 386);
            this.btnAddPosition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(228, 94);
            this.btnAddPosition.TabIndex = 15;
            this.btnAddPosition.Text = "Thêm";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.ptbExit);
            this.panel1.Controls.Add(this.btnShowPosition);
            this.panel1.Controls.Add(this.btnEditPosition);
            this.panel1.Controls.Add(this.btnDeletePosition);
            this.panel1.Controls.Add(this.btnAddPosition);
            this.panel1.Controls.Add(this.txtPositionName);
            this.panel1.Controls.Add(this.txtPositionID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMaban);
            this.panel1.Controls.Add(this.lblThongtin);
            this.panel1.Location = new System.Drawing.Point(931, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 850);
            this.panel1.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 864);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditPosition";
            this.Text = "Chức Vụ";
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.Button btnShowPosition;
        private System.Windows.Forms.Button btnEditPosition;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.TextBox txtPositionName;
        private System.Windows.Forms.TextBox txtPositionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaban;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.Label lblTotalPosition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripTextBox txtFindPositionByName;
        private System.Windows.Forms.ToolStripLabel toolstripTim;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}