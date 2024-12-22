namespace QuanLyQuanAn_DongPhongNha.Manager
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbExit
            // 
            this.ptbExit.BackColor = System.Drawing.Color.Transparent;
            this.ptbExit.Image = global::QuanLyQuanAn_DongPhongNha.Properties.Resources.z6153570384406_f9d6f96bab6a29a8cea819ba4fbcbb64;
            this.ptbExit.Location = new System.Drawing.Point(297, 575);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(58, 58);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 19;
            this.ptbExit.TabStop = false;
            // 
            // btnShowPosition
            // 
            this.btnShowPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowPosition.Location = new System.Drawing.Point(213, 429);
            this.btnShowPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowPosition.Name = "btnShowPosition";
            this.btnShowPosition.Size = new System.Drawing.Size(171, 76);
            this.btnShowPosition.TabIndex = 18;
            this.btnShowPosition.Text = "Hiển thị";
            this.btnShowPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowPosition.UseVisualStyleBackColor = true;
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPosition.Location = new System.Drawing.Point(213, 314);
            this.btnEditPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(171, 76);
            this.btnEditPosition.TabIndex = 16;
            this.btnEditPosition.Text = "Sửa";
            this.btnEditPosition.UseVisualStyleBackColor = true;
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePosition.Location = new System.Drawing.Point(27, 429);
            this.btnDeletePosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(171, 76);
            this.btnDeletePosition.TabIndex = 17;
            this.btnDeletePosition.Text = "Xóa";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            // 
            // txtPositionName
            // 
            this.txtPositionName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionName.Location = new System.Drawing.Point(138, 223);
            this.txtPositionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(228, 22);
            this.txtPositionName.TabIndex = 13;
            // 
            // txtPositionID
            // 
            this.txtPositionID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionID.Location = new System.Drawing.Point(138, 145);
            this.txtPositionID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPositionID.Name = "txtPositionID";
            this.txtPositionID.ReadOnly = true;
            this.txtPositionID.Size = new System.Drawing.Size(228, 22);
            this.txtPositionID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Chức Vụ";
            // 
            // lblMaban
            // 
            this.lblMaban.AutoSize = true;
            this.lblMaban.BackColor = System.Drawing.Color.DimGray;
            this.lblMaban.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaban.ForeColor = System.Drawing.Color.White;
            this.lblMaban.Location = new System.Drawing.Point(24, 147);
            this.lblMaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaban.Name = "lblMaban";
            this.lblMaban.Size = new System.Drawing.Size(46, 16);
            this.lblMaban.TabIndex = 12;
            this.lblMaban.Text = "Mã CV";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Cambria", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(82, 29);
            this.lblThongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(235, 32);
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
            this.dgvPosition.Location = new System.Drawing.Point(7, 97);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            this.dgvPosition.RowHeadersWidth = 82;
            this.dgvPosition.RowTemplate.Height = 33;
            this.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosition.Size = new System.Drawing.Size(685, 590);
            this.dgvPosition.TabIndex = 24;
            // 
            // lblTotalPosition
            // 
            this.lblTotalPosition.AutoSize = true;
            this.lblTotalPosition.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPosition.Location = new System.Drawing.Point(19, 13);
            this.lblTotalPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPosition.Name = "lblTotalPosition";
            this.lblTotalPosition.Size = new System.Drawing.Size(95, 16);
            this.lblTotalPosition.TabIndex = 3;
            this.lblTotalPosition.Text = "Tổng chức vụ:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTotalPosition);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(7, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 53);
            this.panel2.TabIndex = 23;
            // 
            // txtFindPositionByName
            // 
            this.txtFindPositionByName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindPositionByName.Name = "txtFindPositionByName";
            this.txtFindPositionByName.Size = new System.Drawing.Size(200, 25);
            // 
            // toolstripTim
            // 
            this.toolstripTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolstripTim.Name = "toolstripTim";
            this.toolstripTim.Size = new System.Drawing.Size(126, 22);
            this.toolstripTim.Text = "Tìm kiếm chức vụ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
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
            this.toolStrip1.Location = new System.Drawing.Point(7, 6);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(365, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPosition.Location = new System.Drawing.Point(27, 314);
            this.btnAddPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(171, 76);
            this.btnAddPosition.TabIndex = 15;
            this.btnAddPosition.Text = "Thêm";
            this.btnAddPosition.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(698, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 691);
            this.panel1.TabIndex = 25;
            // 
            // frmEditPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 702);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEditPosition";
            this.Text = "frmEditPosition";
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}