﻿namespace QuanLyQuanAn_DongPhongNha.Manager
{
    partial class frmTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableManager));
            this.pdHoaDon = new System.Drawing.Printing.PrintDocument();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvBill = new System.Windows.Forms.ListView();
            this.pnlView = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.nmCountFood = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.ptbImageFood = new System.Windows.Forms.PictureBox();
            this.cmbNameFood = new System.Windows.Forms.ComboBox();
            this.cmbCategoryFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlFood = new System.Windows.Forms.Panel();
            this.pddHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageFood)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giảm giá";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(17, 13);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(237, 27);
            this.txtTotalPrice.TabIndex = 8;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(410, 40);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(254, 79);
            this.btnPayment.TabIndex = 9;
            this.btnPayment.Text = "Thanh Toán";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmDiscount.Location = new System.Drawing.Point(270, 61);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(106, 27);
            this.nmDiscount.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.nmDiscount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 779);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 132);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "HÓA ĐƠN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 100);
            this.panel2.TabIndex = 1;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thanh Toán";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 200;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.LabelEdit = true;
            this.lsvBill.Location = new System.Drawing.Point(0, 100);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(694, 679);
            this.lsvBill.TabIndex = 2;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // pnlView
            // 
            this.pnlView.Controls.Add(this.lsvBill);
            this.pnlView.Controls.Add(this.panel2);
            this.pnlView.Controls.Add(this.panel1);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(298, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(694, 911);
            this.pnlView.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "GỌI MÓN";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(116, 818);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 84);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnLoadTable
            // 
            this.btnLoadTable.Location = new System.Drawing.Point(15, 818);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(79, 84);
            this.btnLoadTable.TabIndex = 13;
            this.btnLoadTable.UseVisualStyleBackColor = true;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.Location = new System.Drawing.Point(57, 675);
            this.lblFoodPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(403, 44);
            this.lblFoodPrice.TabIndex = 12;
            this.lblFoodPrice.Text = "0 đ";
            this.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFood.Image")));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(228, 809);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(257, 96);
            this.btnAddFood.TabIndex = 10;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // nmCountFood
            // 
            this.nmCountFood.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCountFood.Location = new System.Drawing.Point(312, 725);
            this.nmCountFood.Margin = new System.Windows.Forms.Padding(4);
            this.nmCountFood.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCountFood.Name = "nmCountFood";
            this.nmCountFood.Size = new System.Drawing.Size(78, 27);
            this.nmCountFood.TabIndex = 9;
            this.nmCountFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(78, 729);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(85, 20);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "Số lượng:";
            // 
            // ptbImageFood
            // 
            this.ptbImageFood.Location = new System.Drawing.Point(57, 430);
            this.ptbImageFood.Name = "ptbImageFood";
            this.ptbImageFood.Size = new System.Drawing.Size(372, 214);
            this.ptbImageFood.TabIndex = 3;
            this.ptbImageFood.TabStop = false;
            // 
            // cmbNameFood
            // 
            this.cmbNameFood.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNameFood.FormattingEnabled = true;
            this.cmbNameFood.Location = new System.Drawing.Point(206, 280);
            this.cmbNameFood.Name = "cmbNameFood";
            this.cmbNameFood.Size = new System.Drawing.Size(209, 28);
            this.cmbNameFood.TabIndex = 2;
            // 
            // cmbCategoryFood
            // 
            this.cmbCategoryFood.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoryFood.FormattingEnabled = true;
            this.cmbCategoryFood.Location = new System.Drawing.Point(206, 164);
            this.cmbCategoryFood.Name = "cmbCategoryFood";
            this.cmbCategoryFood.Size = new System.Drawing.Size(209, 28);
            this.cmbCategoryFood.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 100);
            this.panel4.TabIndex = 0;
            // 
            // pnlFood
            // 
            this.pnlFood.Controls.Add(this.btnEdit);
            this.pnlFood.Controls.Add(this.btnLoadTable);
            this.pnlFood.Controls.Add(this.lblFoodPrice);
            this.pnlFood.Controls.Add(this.btnAddFood);
            this.pnlFood.Controls.Add(this.nmCountFood);
            this.pnlFood.Controls.Add(this.lblNumber);
            this.pnlFood.Controls.Add(this.ptbImageFood);
            this.pnlFood.Controls.Add(this.cmbNameFood);
            this.pnlFood.Controls.Add(this.cmbCategoryFood);
            this.pnlFood.Controls.Add(this.label2);
            this.pnlFood.Controls.Add(this.label1);
            this.pnlFood.Controls.Add(this.panel4);
            this.pnlFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFood.Location = new System.Drawing.Point(992, 0);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(489, 911);
            this.pnlFood.TabIndex = 4;
            // 
            // pddHoaDon
            // 
            this.pddHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pddHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pddHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.pddHoaDon.Enabled = true;
            this.pddHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("pddHoaDon.Icon")));
            this.pddHoaDon.Name = "pddHoaDon";
            this.pddHoaDon.Visible = false;
            // 
            // flpTable
            // 
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(298, 911);
            this.flpTable.TabIndex = 3;
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 911);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.pnlFood);
            this.Controls.Add(this.flpTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableManager";
            this.Text = "frmTableManager";
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImageFood)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlFood.ResumeLayout(false);
            this.pnlFood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument pdHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmCountFood;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.PictureBox ptbImageFood;
        private System.Windows.Forms.ComboBox cmbNameFood;
        private System.Windows.Forms.ComboBox cmbCategoryFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.PrintPreviewDialog pddHoaDon;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}