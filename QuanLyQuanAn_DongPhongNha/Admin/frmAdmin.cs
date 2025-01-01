﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanAn_DongPhongNha.Admin
{
    public partial class frmAdmin : Form
    {
        QLNHEntities db = new QLNHEntities();
        public frmAdmin()
        {
            InitializeComponent();
            load();
        }
        #region Method
        void load()
        {
            loadFoodChart();
            loadStaffChart();
            loadTableChart();
            loadTotal();
        }
        void loadFoodChart()
        {
            DateTime now = DateTime.Today;
            FoodChart.ChartAreas["ChartArea1"].AxisY.Title = "Số món ăn đã bán";
            FoodChart.ChartAreas["ChartArea1"].AxisX.Title = "Tên món ăn";
            FoodChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            FoodChart.Series["Số món ăn đã bán"].IsValueShownAsLabel = true;
            FoodChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            var dt = db.USP_GetTopFood(now.Date, now.Date.AddDays(1)).ToList();
            FoodChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            foreach (var series in FoodChart.Series)
            {
                series.Points.Clear();
            }

            foreach (var item in dt)
            {
                FoodChart.Series["Số món ăn đã bán"].Points.AddXY(item.nameFood, item.countFood);
            }
        }
        

        // bao cao so nhan vien di lam
        void loadStaffChart()
        {
            // lay ra tong so nhan vien
            int totalStaff = (from s in db.Staff select s).ToList().Count();
            // dem so luong nhan vien da cham cong
            int totalStaffCheckIn = db.USP_GetTotalAttendanceList().ToList().Count();
            // đặt Palette của biểu đồ thành ChartColorPalette.None, sau đó đặt PaletteCustomColors thành một mảng các màu tùy chỉnh.
            StaffChart.Palette = ChartColorPalette.None;
            StaffChart.PaletteCustomColors = new Color[] { Color.FromArgb(255, 192, 72), Color.FromArgb(11, 232, 129), Color.Yellow };
            /*
            Điểm đầu tiên biểu thị số lượng nhân viên đã chấm công và được gán nhãn là "Đi làm". 
            Điểm thứ hai biểu thị số lượng nhân viên vắng mặt (tổng số nhân viên trừ số lượng nhân viên đã chấm công) và được gán nhãn là "Vắng".
            */
            StaffChart.Series["staff"].Points.AddXY("Đi làm", totalStaffCheckIn);
            StaffChart.Series["staff"].Points.AddXY("Vắng", totalStaff - totalStaffCheckIn);
            lblStaff.Text = totalStaffCheckIn.ToString() + "/" + totalStaff.ToString();
        }

        // bao cao ban an 
        void loadTableChart()
        {
            // lay ra tong so ban
            int totalTable = (from s in db.TableFood select s).ToList().Count();
            // dem so ban co nguoi
            int totalTableCheckIn = (from s in db.TableFood where s.statusTable.Contains("Có người") select s).ToList().Count();
            TableChart.Palette = ChartColorPalette.None;
            TableChart.PaletteCustomColors = new Color[] { Color.FromArgb(239, 87, 119), Color.FromArgb(87, 95, 207), Color.Yellow };
            TableChart.Series["table"].Points.AddXY("Có người", totalTableCheckIn);
            TableChart.Series["table"].Points.AddXY("Trống", totalTable - totalTableCheckIn);
            lblTable.Text = totalTableCheckIn.ToString() + "/" + totalTable.ToString();
        }
        void loadTotal()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            // lay ra tong so mon an
            lblTotalFood.Text = (from s in db.Food select s).ToList().Count().ToString();
            // lay ra tong so danh muc
            lblTotalCategory.Text = (from s in db.FoodCategory select s).ToList().Count().ToString();
            // lay ra tong so hoa don
            lblTotalBill.Text = db.USP_GetTotalBillsInDay().ToList().Count().ToString();

            lblRevenue.Text = double.Parse(getRevenue().ToString()).ToString("#,###", culture.NumberFormat) + " đ";
        }

        // lay ra tong so tien trong ngay
        public Double getRevenue()
        {
            var list = db.USP_GetTotalBillsInDay().ToList();
            double total = 0;
            foreach (var item in list)
            {
                total += (Double)item.totalPrice;
            }
            return total;
        }
        #endregion
    }
}
