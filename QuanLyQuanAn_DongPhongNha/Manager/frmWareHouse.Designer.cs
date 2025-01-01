namespace QuanLyQuanAn_DongPhongNha.Manager
{
    partial class frmWareHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBillOfWHID = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtDateAdd = new System.Windows.Forms.TextBox();
            this.txtBillOfWareHouseID = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBillInfoOfWH = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBillOfWareHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillOfWareHouse = new System.Windows.Forms.DataGridView();
            this.lblBillDetail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.pnTotalBill = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouse)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnTotalBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(12, 186);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(181, 31);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Nhà cung cấp:";
            this.lblSupplier.Click += new System.EventHandler(this.lblSupplier_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(12, 255);
            this.lbl5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(135, 31);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Tổng tiền:";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(11, 112);
            this.lblDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 31);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày Nhập:";
            // 
            // lblBillOfWHID
            // 
            this.lblBillOfWHID.AutoSize = true;
            this.lblBillOfWHID.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillOfWHID.ForeColor = System.Drawing.Color.White;
            this.lblBillOfWHID.Location = new System.Drawing.Point(11, 34);
            this.lblBillOfWHID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBillOfWHID.Name = "lblBillOfWHID";
            this.lblBillOfWHID.Size = new System.Drawing.Size(164, 31);
            this.lblBillOfWHID.TabIndex = 0;
            this.lblBillOfWHID.Text = "Mã hóa đơn:";
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.DimGray;
            this.pn1.Controls.Add(this.rtbNote);
            this.pn1.Controls.Add(this.txtTotalPrice);
            this.pn1.Controls.Add(this.txtSupplier);
            this.pn1.Controls.Add(this.txtDateAdd);
            this.pn1.Controls.Add(this.txtBillOfWareHouseID);
            this.pn1.Controls.Add(this.lblSupplier);
            this.pn1.Controls.Add(this.lbl5);
            this.pn1.Controls.Add(this.lblDate);
            this.pn1.Controls.Add(this.lblNote);
            this.pn1.Controls.Add(this.lblBillOfWHID);
            this.pn1.Location = new System.Drawing.Point(-1, 771);
            this.pn1.Margin = new System.Windows.Forms.Padding(2);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(891, 331);
            this.pn1.TabIndex = 9;
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(564, 89);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.ReadOnly = true;
            this.rtbNote.Size = new System.Drawing.Size(289, 180);
            this.rtbNote.TabIndex = 5;
            this.rtbNote.Text = "";
            this.rtbNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbNote_KeyPress);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(187, 261);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(332, 26);
            this.txtTotalPrice.TabIndex = 4;
            this.txtTotalPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPrice_KeyPress);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(187, 192);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(332, 26);
            this.txtSupplier.TabIndex = 3;
            this.txtSupplier.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplier_KeyPress);
            // 
            // txtDateAdd
            // 
            this.txtDateAdd.Location = new System.Drawing.Point(187, 119);
            this.txtDateAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateAdd.Name = "txtDateAdd";
            this.txtDateAdd.ReadOnly = true;
            this.txtDateAdd.Size = new System.Drawing.Size(332, 26);
            this.txtDateAdd.TabIndex = 2;
            this.txtDateAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDateAdd_KeyPress);
            // 
            // txtBillOfWareHouseID
            // 
            this.txtBillOfWareHouseID.Location = new System.Drawing.Point(187, 40);
            this.txtBillOfWareHouseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBillOfWareHouseID.Name = "txtBillOfWareHouseID";
            this.txtBillOfWareHouseID.ReadOnly = true;
            this.txtBillOfWareHouseID.Size = new System.Drawing.Size(332, 26);
            this.txtBillOfWareHouseID.TabIndex = 1;
            this.txtBillOfWareHouseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillOfWareHouseID_KeyPress);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(568, 34);
            this.lblNote.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(112, 31);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Ghi chú:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nguyên Liệu";
            this.columnHeader1.Width = 160;
            // 
            // lsvBillInfoOfWH
            // 
            this.lsvBillInfoOfWH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillInfoOfWH.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillInfoOfWH.GridLines = true;
            this.lsvBillInfoOfWH.HideSelection = false;
            this.lsvBillInfoOfWH.LabelEdit = true;
            this.lsvBillInfoOfWH.Location = new System.Drawing.Point(894, 129);
            this.lsvBillInfoOfWH.Margin = new System.Windows.Forms.Padding(2);
            this.lsvBillInfoOfWH.Name = "lsvBillInfoOfWH";
            this.lsvBillInfoOfWH.Size = new System.Drawing.Size(767, 973);
            this.lsvBillInfoOfWH.TabIndex = 10;
            this.lsvBillInfoOfWH.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfoOfWH.View = System.Windows.Forms.View.Details;
            this.lsvBillInfoOfWH.SelectedIndexChanged += new System.EventHandler(this.lsvBillInfoOfWH_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            // 
            // note
            // 
            this.note.FillWeight = 95.45455F;
            this.note.HeaderText = "Ghi Chú";
            this.note.MinimumWidth = 10;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.FillWeight = 95.45455F;
            this.supplier.HeaderText = "Nhà cung cấp";
            this.supplier.MinimumWidth = 10;
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // dateAdded
            // 
            this.dateAdded.FillWeight = 95.45455F;
            this.dateAdded.HeaderText = "Ngày Nhập Hàng";
            this.dateAdded.MinimumWidth = 10;
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.ReadOnly = true;
            // 
            // idBillOfWareHouse
            // 
            this.idBillOfWareHouse.FillWeight = 113.6364F;
            this.idBillOfWareHouse.HeaderText = "Mã Hóa Đơn";
            this.idBillOfWareHouse.MinimumWidth = 10;
            this.idBillOfWareHouse.Name = "idBillOfWareHouse";
            this.idBillOfWareHouse.ReadOnly = true;
            this.idBillOfWareHouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvBillOfWareHouse
            // 
            this.dgvBillOfWareHouse.AllowUserToAddRows = false;
            this.dgvBillOfWareHouse.AllowUserToDeleteRows = false;
            this.dgvBillOfWareHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillOfWareHouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBillOfWareHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillOfWareHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBillOfWareHouse,
            this.dateAdded,
            this.supplier,
            this.note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillOfWareHouse.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillOfWareHouse.Location = new System.Drawing.Point(-1, 129);
            this.dgvBillOfWareHouse.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBillOfWareHouse.Name = "dgvBillOfWareHouse";
            this.dgvBillOfWareHouse.ReadOnly = true;
            this.dgvBillOfWareHouse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBillOfWareHouse.RowHeadersWidth = 82;
            this.dgvBillOfWareHouse.RowTemplate.Height = 28;
            this.dgvBillOfWareHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillOfWareHouse.Size = new System.Drawing.Size(891, 629);
            this.dgvBillOfWareHouse.TabIndex = 11;
            this.dgvBillOfWareHouse.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBillOfWareHouse_CellMouseClick);
            // 
            // lblBillDetail
            // 
            this.lblBillDetail.AutoSize = true;
            this.lblBillDetail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillDetail.Location = new System.Drawing.Point(12, 30);
            this.lblBillDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillDetail.Name = "lblBillDetail";
            this.lblBillDetail.Size = new System.Drawing.Size(187, 28);
            this.lblBillDetail.TabIndex = 7;
            this.lblBillDetail.Text = "Chi tiết hóa đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblBillDetail);
            this.panel2.Location = new System.Drawing.Point(894, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 88);
            this.panel2.TabIndex = 12;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBill.Location = new System.Drawing.Point(12, 19);
            this.lblTotalBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(203, 28);
            this.lblTotalBill.TabIndex = 0;
            this.lblTotalBill.Text = "Tổng số hóa đơn: ";
            // 
            // pnTotalBill
            // 
            this.pnTotalBill.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalBill.Controls.Add(this.lblTotalBill);
            this.pnTotalBill.Location = new System.Drawing.Point(-1, 15);
            this.pnTotalBill.Margin = new System.Windows.Forms.Padding(2);
            this.pnTotalBill.Name = "pnTotalBill";
            this.pnTotalBill.Size = new System.Drawing.Size(891, 88);
            this.pnTotalBill.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2082, 1424);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.dgvBillOfWareHouse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTotalBill);
            this.Controls.Add(this.lsvBillInfoOfWH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWareHouse";
            this.Text = "frmWareHouse";
            this.Load += new System.EventHandler(this.frmWareHouse_Load);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouse)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnTotalBill.ResumeLayout(false);
            this.pnTotalBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBillOfWHID;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lsvBillInfoOfWH;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBillOfWareHouse;
        private System.Windows.Forms.DataGridView dgvBillOfWareHouse;
        private System.Windows.Forms.Label lblBillDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Panel pnTotalBill;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtDateAdd;
        private System.Windows.Forms.TextBox txtBillOfWareHouseID;
        private System.Windows.Forms.RichTextBox rtbNote;
    }
}