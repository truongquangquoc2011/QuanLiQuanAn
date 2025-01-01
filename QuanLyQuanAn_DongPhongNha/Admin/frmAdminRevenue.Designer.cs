﻿namespace QuanLyQuanAn_DongPhongNha.Admin
{
    partial class frmAdminRevenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTopFoodChart = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.pnTotalRevenue = new System.Windows.Forms.Panel();
            this.dgv_nvThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ngayRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ngayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_maHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvViewRevenue = new System.Windows.Forms.DataGridView();
            this.lblFoodRevenue = new System.Windows.Forms.Label();
            this.dgvFoodRevenue = new System.Windows.Forms.DataGridView();
            this.dgv_tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_doanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.btn_print = new System.Windows.Forms.Button();
            this.lbl_den = new System.Windows.Forms.Label();
            this.lbl_tu = new System.Windows.Forms.Label();
            this.rbt_seeAll = new System.Windows.Forms.RadioButton();
            this.rbt_year = new System.Windows.Forms.RadioButton();
            this.rbt_month = new System.Windows.Forms.RadioButton();
            this.rbt_today = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FoodChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnTotalRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodRevenue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopFoodChart
            // 
            this.lblTopFoodChart.AutoSize = true;
            this.lblTopFoodChart.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTopFoodChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.lblTopFoodChart.Location = new System.Drawing.Point(9, 331);
            this.lblTopFoodChart.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblTopFoodChart.Name = "lblTopFoodChart";
            this.lblTopFoodChart.Size = new System.Drawing.Size(243, 19);
            this.lblTopFoodChart.TabIndex = 25;
            this.lblTopFoodChart.Text = "Biểu đồ món ăn bán nhiều nhất";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(42, 7);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(92, 19);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "Doanh thu:";
            // 
            // pnTotalRevenue
            // 
            this.pnTotalRevenue.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalRevenue.Controls.Add(this.lblTotalRevenue);
            this.pnTotalRevenue.Location = new System.Drawing.Point(0, 2);
            this.pnTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTotalRevenue.Name = "pnTotalRevenue";
            this.pnTotalRevenue.Size = new System.Drawing.Size(788, 56);
            this.pnTotalRevenue.TabIndex = 1;
            // 
            // dgv_nvThanhToan
            // 
            this.dgv_nvThanhToan.HeaderText = "NV Thanh Toán";
            this.dgv_nvThanhToan.MinimumWidth = 6;
            this.dgv_nvThanhToan.Name = "dgv_nvThanhToan";
            this.dgv_nvThanhToan.ReadOnly = true;
            this.dgv_nvThanhToan.Width = 175;
            // 
            // dgv_ngayRa
            // 
            this.dgv_ngayRa.HeaderText = "Ngày Ra";
            this.dgv_ngayRa.MinimumWidth = 6;
            this.dgv_ngayRa.Name = "dgv_ngayRa";
            this.dgv_ngayRa.ReadOnly = true;
            this.dgv_ngayRa.Width = 175;
            // 
            // dgv_ngayVao
            // 
            this.dgv_ngayVao.HeaderText = "Ngày Vào";
            this.dgv_ngayVao.MinimumWidth = 6;
            this.dgv_ngayVao.Name = "dgv_ngayVao";
            this.dgv_ngayVao.ReadOnly = true;
            this.dgv_ngayVao.Width = 175;
            // 
            // dgv_giamGia
            // 
            this.dgv_giamGia.HeaderText = "Giảm Giá";
            this.dgv_giamGia.MinimumWidth = 6;
            this.dgv_giamGia.Name = "dgv_giamGia";
            this.dgv_giamGia.ReadOnly = true;
            this.dgv_giamGia.Width = 150;
            // 
            // dgv_tongTien
            // 
            this.dgv_tongTien.HeaderText = "Tổng Tiền";
            this.dgv_tongTien.MinimumWidth = 6;
            this.dgv_tongTien.Name = "dgv_tongTien";
            this.dgv_tongTien.ReadOnly = true;
            this.dgv_tongTien.Width = 175;
            // 
            // dgv_maHoaDon
            // 
            this.dgv_maHoaDon.HeaderText = "Mã Hóa Đơn";
            this.dgv_maHoaDon.MinimumWidth = 6;
            this.dgv_maHoaDon.Name = "dgv_maHoaDon";
            this.dgv_maHoaDon.ReadOnly = true;
            this.dgv_maHoaDon.Width = 150;
            // 
            // dgvViewRevenue
            // 
            this.dgvViewRevenue.AllowUserToAddRows = false;
            this.dgvViewRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_maHoaDon,
            this.dgv_tongTien,
            this.dgv_giamGia,
            this.dgv_ngayVao,
            this.dgv_ngayRa,
            this.dgv_nvThanhToan});
            this.dgvViewRevenue.Location = new System.Drawing.Point(0, 68);
            this.dgvViewRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvViewRevenue.Name = "dgvViewRevenue";
            this.dgvViewRevenue.ReadOnly = true;
            this.dgvViewRevenue.RowHeadersWidth = 51;
            this.dgvViewRevenue.RowTemplate.Height = 24;
            this.dgvViewRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewRevenue.Size = new System.Drawing.Size(788, 247);
            this.dgvViewRevenue.TabIndex = 2;
            // 
            // lblFoodRevenue
            // 
            this.lblFoodRevenue.AutoSize = true;
            this.lblFoodRevenue.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.lblFoodRevenue.Location = new System.Drawing.Point(384, 330);
            this.lblFoodRevenue.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lblFoodRevenue.Name = "lblFoodRevenue";
            this.lblFoodRevenue.Size = new System.Drawing.Size(148, 19);
            this.lblFoodRevenue.TabIndex = 26;
            this.lblFoodRevenue.Text = "Doanh thu món ăn";
            // 
            // dgvFoodRevenue
            // 
            this.dgvFoodRevenue.AllowUserToAddRows = false;
            this.dgvFoodRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodRevenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_tenMon,
            this.dgv_soLuong,
            this.dgv_gia,
            this.dgv_doanhThu});
            this.dgvFoodRevenue.Location = new System.Drawing.Point(388, 358);
            this.dgvFoodRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFoodRevenue.Name = "dgvFoodRevenue";
            this.dgvFoodRevenue.ReadOnly = true;
            this.dgvFoodRevenue.RowHeadersWidth = 51;
            this.dgvFoodRevenue.RowTemplate.Height = 24;
            this.dgvFoodRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodRevenue.Size = new System.Drawing.Size(400, 368);
            this.dgvFoodRevenue.TabIndex = 27;
            // 
            // dgv_tenMon
            // 
            this.dgv_tenMon.HeaderText = "Tên Món";
            this.dgv_tenMon.MinimumWidth = 6;
            this.dgv_tenMon.Name = "dgv_tenMon";
            this.dgv_tenMon.ReadOnly = true;
            // 
            // dgv_soLuong
            // 
            this.dgv_soLuong.HeaderText = "Số Lượng";
            this.dgv_soLuong.MinimumWidth = 6;
            this.dgv_soLuong.Name = "dgv_soLuong";
            this.dgv_soLuong.ReadOnly = true;
            // 
            // dgv_gia
            // 
            this.dgv_gia.HeaderText = "Giá";
            this.dgv_gia.MinimumWidth = 6;
            this.dgv_gia.Name = "dgv_gia";
            this.dgv_gia.ReadOnly = true;
            // 
            // dgv_doanhThu
            // 
            this.dgv_doanhThu.HeaderText = "Doanh Thu";
            this.dgv_doanhThu.MinimumWidth = 6;
            this.dgv_doanhThu.Name = "dgv_doanhThu";
            this.dgv_doanhThu.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.dtpkFromDate);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.lbl_den);
            this.panel1.Controls.Add(this.lbl_tu);
            this.panel1.Controls.Add(this.rbt_seeAll);
            this.panel1.Controls.Add(this.rbt_year);
            this.panel1.Controls.Add(this.rbt_month);
            this.panel1.Controls.Add(this.rbt_today);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(796, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 740);
            this.panel1.TabIndex = 28;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CalendarFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkToDate.Location = new System.Drawing.Point(118, 496);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(153, 23);
            this.dtpkToDate.TabIndex = 49;
            this.dtpkToDate.ValueChanged += new System.EventHandler(this.dtpkToDate_ValueChanged);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CalendarFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFromDate.Location = new System.Drawing.Point(118, 422);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(153, 23);
            this.dtpkFromDate.TabIndex = 49;
            this.dtpkFromDate.ValueChanged += new System.EventHandler(this.dtpkFromDate_ValueChanged);
            this.dtpkFromDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dtpkFromDate_MouseUp);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(67, 619);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(220, 71);
            this.btn_print.TabIndex = 48;
            this.btn_print.Text = "Xuất Phiếu";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lbl_den
            // 
            this.lbl_den.AutoSize = true;
            this.lbl_den.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_den.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_den.Location = new System.Drawing.Point(63, 496);
            this.lbl_den.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_den.Name = "lbl_den";
            this.lbl_den.Size = new System.Drawing.Size(39, 16);
            this.lbl_den.TabIndex = 47;
            this.lbl_den.Text = "Đến :";
            // 
            // lbl_tu
            // 
            this.lbl_tu.AutoSize = true;
            this.lbl_tu.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tu.Location = new System.Drawing.Point(64, 422);
            this.lbl_tu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tu.Name = "lbl_tu";
            this.lbl_tu.Size = new System.Drawing.Size(33, 16);
            this.lbl_tu.TabIndex = 46;
            this.lbl_tu.Text = "Từ :";
            // 
            // rbt_seeAll
            // 
            this.rbt_seeAll.AutoSize = true;
            this.rbt_seeAll.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_seeAll.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_seeAll.Location = new System.Drawing.Point(67, 330);
            this.rbt_seeAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbt_seeAll.Name = "rbt_seeAll";
            this.rbt_seeAll.Size = new System.Drawing.Size(94, 20);
            this.rbt_seeAll.TabIndex = 42;
            this.rbt_seeAll.TabStop = true;
            this.rbt_seeAll.Text = "Xem Tất Cả";
            this.rbt_seeAll.UseVisualStyleBackColor = true;
            this.rbt_seeAll.CheckedChanged += new System.EventHandler(this.rbt_seeAll_CheckedChanged);
            // 
            // rbt_year
            // 
            this.rbt_year.AutoSize = true;
            this.rbt_year.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_year.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_year.Location = new System.Drawing.Point(67, 243);
            this.rbt_year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbt_year.Name = "rbt_year";
            this.rbt_year.Size = new System.Drawing.Size(54, 20);
            this.rbt_year.TabIndex = 41;
            this.rbt_year.TabStop = true;
            this.rbt_year.Text = "Năm";
            this.rbt_year.UseVisualStyleBackColor = true;
            this.rbt_year.CheckedChanged += new System.EventHandler(this.rbt_year_CheckedChanged);
            // 
            // rbt_month
            // 
            this.rbt_month.AutoSize = true;
            this.rbt_month.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_month.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_month.Location = new System.Drawing.Point(67, 174);
            this.rbt_month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbt_month.Name = "rbt_month";
            this.rbt_month.Size = new System.Drawing.Size(64, 20);
            this.rbt_month.TabIndex = 40;
            this.rbt_month.TabStop = true;
            this.rbt_month.Text = "Tháng";
            this.rbt_month.UseVisualStyleBackColor = true;
            this.rbt_month.CheckedChanged += new System.EventHandler(this.rbt_month_CheckedChanged);
            // 
            // rbt_today
            // 
            this.rbt_today.AutoSize = true;
            this.rbt_today.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_today.ForeColor = System.Drawing.SystemColors.Control;
            this.rbt_today.Location = new System.Drawing.Point(67, 112);
            this.rbt_today.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbt_today.Name = "rbt_today";
            this.rbt_today.Size = new System.Drawing.Size(82, 20);
            this.rbt_today.TabIndex = 39;
            this.rbt_today.TabStop = true;
            this.rbt_today.Text = "Hôm Nay";
            this.rbt_today.UseVisualStyleBackColor = true;
            this.rbt_today.CheckedChanged += new System.EventHandler(this.rbt_today_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thống Kê Hóa Đơn";
            // 
            // FoodChart
            // 
            chartArea3.Name = "ChartArea";
            this.FoodChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.FoodChart.Legends.Add(legend3);
            this.FoodChart.Location = new System.Drawing.Point(13, 358);
            this.FoodChart.Margin = new System.Windows.Forms.Padding(6);
            this.FoodChart.Name = "FoodChart";
            this.FoodChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "FoodName";
            series6.ChartArea = "ChartArea";
            series6.Legend = "Legend1";
            series6.Name = "Số món ăn đã bán";
            this.FoodChart.Series.Add(series5);
            this.FoodChart.Series.Add(series6);
            this.FoodChart.Size = new System.Drawing.Size(365, 368);
            this.FoodChart.TabIndex = 50;
            this.FoodChart.Text = "chart1";
            // 
            // frmAdminRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 740);
            this.Controls.Add(this.FoodChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvFoodRevenue);
            this.Controls.Add(this.lblFoodRevenue);
            this.Controls.Add(this.lblTopFoodChart);
            this.Controls.Add(this.dgvViewRevenue);
            this.Controls.Add(this.pnTotalRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdminRevenue";
            this.Text = "frmAdminRevenue";
            this.pnTotalRevenue.ResumeLayout(false);
            this.pnTotalRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodRevenue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopFoodChart;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Panel pnTotalRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nvThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ngayRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ngayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_giamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_maHoaDon;
        private System.Windows.Forms.DataGridView dgvViewRevenue;
        private System.Windows.Forms.Label lblFoodRevenue;
        private System.Windows.Forms.DataGridView dgvFoodRevenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_doanhThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_den;
        private System.Windows.Forms.Label lbl_tu;
        private System.Windows.Forms.RadioButton rbt_seeAll;
        private System.Windows.Forms.RadioButton rbt_year;
        private System.Windows.Forms.RadioButton rbt_month;
        private System.Windows.Forms.RadioButton rbt_today;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart FoodChart;
    }
}