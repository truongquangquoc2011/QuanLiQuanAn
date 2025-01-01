using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn_DongPhongNha.Manager
{
    public partial class frmManagerFood : Form
    {
        QLNHEntities db = new QLNHEntities();
        public frmManagerFood()
        {
            InitializeComponent();
            load();
        }
        #region Method
        private void txtFoodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtFoodName, "Tên thức ăn không chứa số ");
            }
            else
            {
                errorProvider1.SetError(txtFoodName, null);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtPrice, "giá chỉ cho phép nhập số ");
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
            }
        }
        void load()
        {
            loadFoodList();
            loadCategory();
        }

        private void loadCategory()
        {
            List<FoodCategory> listFoodCategories = (from category in db.FoodCategory
                                                     select category).ToList();
            // fill danh muc len tren combobox
            cmbNameFC.DataSource = listFoodCategories;
            cmbNameFC.DisplayMember = "nameFC";
        }
        public bool ChangeStatus(bool status, int idFood)
        {
            Food food = (from f in db.Food where f.idFood == idFood select f).FirstOrDefault();
            food.statusFood = "Đang bán";

            if (status == false) food.statusFood = "Tạm ngưng";
            return db.SaveChanges() > 0;
        }

        void loadFoodList()
        {
            int insertRow = 0;
            dgvFoodList.Rows.Clear();
            List<Food> listFood = (from food in db.Food
                                   select food).ToList();
            foreach (var item in listFood)
            {
                insertRow = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[insertRow].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[insertRow].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[insertRow].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[insertRow].Cells[3].Value = item.price;
                dgvFoodList.Rows[insertRow].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[insertRow].Cells[5].Value = item.statusFood;
            }
            txtTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count).ToString();
            setDataGridView(dgvFoodList);
        }

        void setDataGridView(DataGridView dataGrid)
        {
            // fontSize 
            int desiredFontSize = 12;

            // chinh font size cho toan bo dgv
            dataGrid.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            // chinh frontSize cho ten cot
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);

            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.BackgroundColor = Color.White;

            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void loadListFoodByName(string name)
        {
            int n = 0;
            dgvFoodList.Rows.Clear();
            QLNHEntities db = new QLNHEntities();
            List<Food> listFood = (from f in db.Food where f.nameFood.Contains(name) select f).ToList();
            foreach (var item in listFood)
            {
                n = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[n].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[n].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[n].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[n].Cells[3].Value = item.price;
                dgvFoodList.Rows[n].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[n].Cells[5].Value = item.statusFood;
            }
            txtTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count).ToString();
            setDataGridView(dgvFoodList);
        }
        void LoadImageFoodByIdFood(int id)
        {
            QLNHEntities db = new QLNHEntities();
            String image = (from f in db.Food where f.idFood == id select f.imageFood).FirstOrDefault().ToString();
            if (image == null)
            {
                image = "default.png";
            }

            Image img = GetCopyImage(@"..\..\Image\food\" + image);
            ptbImageOfFood.Image = img;
            ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
            //ptbImageOfFood.Image = new Bitmap(@"./Image/food/" + image);
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
        #endregion
        #region Event
        private void dgvFoodList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvFoodList.Rows[rowIndex];
                txtFoodID.Text = row.Cells[0].Value.ToString();
                txtFoodName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                lblLinkImage.Text = row.Cells[4].Value.ToString();
                cbStatus.Checked = row.Cells[5].Value.ToString() == "Đang bán";
                cmbNameFC.SelectedIndex = (int)row.Cells[2].Value - 1;
                LoadImageFoodByIdFood((int)row.Cells[0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                int idFood = Int32.Parse(txtFoodID.Text);
                ChangeStatus(cbStatus.Checked == true, idFood);
            }
            catch
            {
                msg.Show("Vui lòng chọn món trước khi điều chỉnh", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
            }
        }
        
        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            loadListFoodByName(txtSearchFood.Text);
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            loadFoodList();
        }

        #endregion

        private void txtSearchFood_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTotalFood_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
