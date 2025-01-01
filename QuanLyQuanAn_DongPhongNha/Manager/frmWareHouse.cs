using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn_DongPhongNha.Manager
{
    public partial class frmWareHouse : Form
    {
        QLNHEntities db = new QLNHEntities();
        public frmWareHouse()
        {
            InitializeComponent();
            load();
        }

        #region Method

        void load()
        {
            loadBillOfWaseHouse();
        }
        void loadBillOfWaseHouse()
        {
            int insertRow = 0;
            dgvBillOfWareHouse.Rows.Clear();
            //lấy ra bảng BillOfWasHouse tu csdl
            List<BillOfWareHouse> billOfWareHouses = (from x in db.BillOfWareHouse
                                                      select x).ToList();
            foreach (var item in billOfWareHouses)
            {
                insertRow = dgvBillOfWareHouse.Rows.Add();
                dgvBillOfWareHouse.Rows[insertRow].Cells[0].Value = item.idBillOfWareHouse;
                dgvBillOfWareHouse.Rows[insertRow].Cells[1].Value = item.dateAdded.ToString().Split(' ')[0];
                dgvBillOfWareHouse.Rows[insertRow].Cells[2].Value = item.supplier;
                dgvBillOfWareHouse.Rows[insertRow].Cells[3].Value = item.note;

                lblTotalBill.Text = "Tổng số hóa đơn: " + dgvBillOfWareHouse.Rows.Count.ToString();
                // fontSize
                int desiredFontSize = 12;

                // chỉnh font size cho toàn bộ dgv
                dgvBillOfWareHouse.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);
                // chỉnh frontSize cho tên cột
                dgvBillOfWareHouse.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);
                dgvBillOfWareHouse.BorderStyle = BorderStyle.None;
                dgvBillOfWareHouse.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dgvBillOfWareHouse.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvBillOfWareHouse.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dgvBillOfWareHouse.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvBillOfWareHouse.BackgroundColor = Color.White;
                dgvBillOfWareHouse.EnableHeadersVisualStyles = false;
                dgvBillOfWareHouse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvBillOfWareHouse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dgvBillOfWareHouse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
        }

        void loadBillInfoWareHouseById(int idBillWareHouseList)
        {
            lsvBillInfoOfWH.Items.Clear();
            int totalPrice = 0;
            //lấy ra bảng thông tin chi tiết hóa đơn nhà cung cấp theo mã
            foreach (var item in
                (from biwh in db.BillInfoOfWareHouse
                 where biwh.idBillOfWareHouse == idBillWareHouseList
                 select biwh).ToList()
                )
            {
                ListViewItem lsvItem = new ListViewItem(item.Material.nameMaterial);
                lsvItem.SubItems.Add(item.number.ToString());
                lsvItem.SubItems.Add(item.price.ToString());
                lsvItem.SubItems.Add(item.totalPrice.ToString());
                totalPrice += item.price;
                lsvBillInfoOfWH.Items.Add(lsvItem);
            }
            txtTotalPrice.Text = totalPrice.ToString();
        }

        #endregion

        #region Event
        private void frmWareHouse_Load(object sender, EventArgs e)
        {

        }
        private void lsvBillInfoOfWH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgvBillOfWareHouse_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int select = e.RowIndex;
                loadBillInfoWareHouseById(select + 1);
                txtBillOfWareHouseID.Text = dgvBillOfWareHouse.Rows[select].Cells[0].Value.ToString();
                txtDateAdd.Text = dgvBillOfWareHouse.Rows[select].Cells[1].Value.ToString();
                txtSupplier.Text = dgvBillOfWareHouse.Rows[select].Cells[2].Value.ToString();
                rtbNote.Text = dgvBillOfWareHouse.Rows[select].Cells[3].Value.ToString();

            }
            catch
            {
                msg.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblSupplier_Click(object sender, EventArgs e)
        {

        }
        private void lbl5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void txtBillOfWareHouseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
                errorProvider1.SetError(txtBillOfWareHouseID, "Vui lòng không nhập các ký tự đặc biệt");
            }
            else
            {
                errorProvider1.SetError(txtBillOfWareHouseID, null); 
            }
        }

        private void txtDateAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtDateAdd, "Vui lòng không nhập chữ");
            }
            else
            {
                errorProvider1.SetError(txtDateAdd, null);
            }
        }

        private void txtSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(txtSupplier, "Vui lòng không nhập các ký tự đặc biệt");
            }
            else
            {
                errorProvider1.SetError(txtSupplier, null);
            }
        }

        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTotalPrice, "Vui lòng không nhập chữ");
            }
            else
            {
                errorProvider1.SetError(txtTotalPrice, null);
            }
        }

        private void rtbNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(rtbNote, "Vui lòng không nhập các ký tự đặc biệt");
            }
            else
            {
                errorProvider1.SetError(rtbNote, null);
            }
        }
    }
}
