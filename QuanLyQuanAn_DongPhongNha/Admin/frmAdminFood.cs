using QuanLyQuanAn_DongPhongNha.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn_DongPhongNha.Admin
{
    
    public partial class frmAdminFood : Form
    {
        QLNHEntities db = new QLNHEntities();
        public frmAdminFood()
        {
            InitializeComponent();
            load();
            columnRatio();
        }
        #region Method
        void load()
        {
            loadListFood();
            loadCategory();
        }
        public void columnRatio()
        {
            int totalWidth = dgvFoodList.Width;
            int column1Width = (int)(totalWidth * 0.25);
            int column2Width = (int)(totalWidth * 0.25);
            int column3Width = (int)(totalWidth * 0.25);
            int column4Width = (int)(totalWidth * 0.25);

            dgvFoodList.Columns[0].Width = column1Width;
            dgvFoodList.Columns[1].Width = column2Width;
            dgvFoodList.Columns[2].Width = column3Width;
            dgvFoodList.Columns[3].Width = column4Width;

        }
        // load du lieu le dataGirdView
        void loadListFood()
        {
            int index = 0;
            dgvFoodList.Rows.Clear();
            foreach (var item in (from x in db.Food select x).ToList())
            {
                index = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[index].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[index].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[index].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[index].Cells[3].Value = item.price;
                dgvFoodList.Rows[index].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[index].Cells[5].Value = item.statusFood;
            }
            lblTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count).ToString();
            setDataGridView(dgvFoodList);
        }
        void loadListFoodByName(string name)
        {
            int index = 0;
            dgvFoodList.Rows.Clear();
            foreach (var item in (from x in db.Food
                                  where x.nameFood.Contains(name)
                                  select x).ToList())
            {
                index = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[index].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[index].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[index].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[index].Cells[3].Value = item.price;
                dgvFoodList.Rows[index].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[index].Cells[5].Value = item.statusFood;
            }
            lblTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count ).ToString();
            setDataGridView(dgvFoodList);
        }

        // load loai thuc an len comboox
        void loadCategory()
        {
            List<FoodCategory> foodCategories = (from x in db.FoodCategory select x).ToList();
            cbbFoodCategory.DataSource = foodCategories;
            cbbFoodCategory.DisplayMember = "nameFC";
        }

        // kiem tra anh trong Image\food\ va do len tren form
        void LoadImageFoodByIdFood(int id)
        {
            String image = (from f in db.Food where f.idFood == id select f.imageFood).FirstOrDefault();
            Image img = GetCopyImage(@"..\..\Image\food\" + image);
            ptbImageOfFood.Image = img;
            ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
        // mo file de upload anh
        void GetFile()
        {
            System.Windows.Forms.OpenFileDialog openImage = new OpenFileDialog();
            openImage.Title = "Select your image";
            openImage.InitialDirectory = "C:";
            openImage.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openImage.AutoUpgradeEnabled = true;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                String Chosen_File = openImage.FileName;

                string filename = System.IO.Path.GetFileName(Chosen_File);
                String inputExt = (Path.GetExtension(filename).ToLower());
                try
                {
                    System.IO.File.Copy(Chosen_File, @"..\..\Image\food\" + filename);
                }
                catch
                {
                }
                Invoke((MethodInvoker)delegate
                {
                    lblLinkImage.Text = filename;
                    ptbImageOfFood.Image = new Bitmap(Chosen_File);
                    ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
                });
            }
        }

        // them food
        void AddFood()
        {
            string name = txtFoodName.Text;
            int idCategory = (cbbFoodCategory.SelectedIndex) + 1;
            float price = 0;
            string linkImage = lblLinkImage.Text;
            if (name != "" && float.TryParse(txtPrice.Text, out price))
            {
                if ((from f in db.Food where f.nameFood == name select f).FirstOrDefault() != null)
                {
                    if (msg.Show("Tên món ăn đã tồn tại. Bạn có chắc chắn thêm món?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Warning) == DialogResult.Yes)
                    {
                        if (linkImage == "")
                        {
                            if (msg.Show("Bạn vẫn chưa tải hình món ăn lên. Bạn có chắc chắn thêm món?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                            {
                                if (db.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                                {
                                    msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                                    loadListFood();
                                }
                                else
                                {
                                    msg.Show("Có lỗi khi thêm món ăn.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                                }
                            }
                        }
                        else
                        {
                            if (db.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                            {
                                msg.Show("Thêm thành công.", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                                loadListFood();
                            }
                            else
                            {
                                msg.Show("Có lỗi khi thêm món ăn.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                            }
                        }
                    }
                }
                else
                {
                    if (db.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                    {
                        msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        loadListFood();
                    }
                    else
                    {
                        msg.Show("Có lỗi khi thêm món ăn", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                if (name == "")
                {
                    msg.Show("Vui lòng nhập tên món ăn !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
                else
                {
                    msg.Show("Vui lòng nhập giá món ăn là số!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
            }
        }
        void DeleteFood()
        {
            try
            {
                int idFood = Int32.Parse(txtFoodID.Text);
                string name = txtFoodID.Text;
                string linkImage = lblLinkImage.Text;

                if (msg.Show("Bạn có chắc chắn muốn xóa món " + name + "?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                {
                    Food foodDelete = (from food in db.Food where food.idFood == idFood select food).FirstOrDefault();
                    db.Food.Remove(foodDelete);
                    if (db.SaveChanges() > 0)
                    {
                        msg.Show("Xóa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        if (File.Exists(@"..\..\Image\food\" + linkImage)) // kiem tra tap tin dung huong dan 
                        {
                            File.Delete(@"..\..\Image\food\" + linkImage); // xao tep anh do
                        }
                        loadListFood();
                    }
                    else
                    {
                        msg.Show("Đã có lỗi xảy ra", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa món ăn này!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
            }
        }

        // sua food
        void EditFood()
        {
            int idFood = Int32.Parse(txtFoodID.Text);
            string name = txtFoodName.Text;
            int idCategory = (cbbFoodCategory.SelectedIndex) + 1;
            float price = 0;
            string linkImage = lblLinkImage.Text;

            if (name == "" || float.TryParse(txtPrice.Text, out price))
            {
                Food foodEdit = (from food in db.Food where food.idFood == idFood select food).FirstOrDefault();
                // kiem tra nguoi dung khi chua cap nhat anh
                if ((from x in db.Food where x.imageFood == linkImage && x.idFood == idFood select x).FirstOrDefault() != null)
                {
                    if (msg.Show("Bạn vẫn chưa tải hình món ăn lên.\n Bạn có chắc chắn sửa món?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            foodEdit.idFood = idFood;
                            foodEdit.nameFood = name;
                            foodEdit.price = price;
                            foodEdit.imageFood = linkImage;
                            db.SaveChanges();
                            msg.Show("Sửa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadListFood();
                        }
                        catch
                        {

                        }

                    }
                }
                else
                {
                    foodEdit.idFood = idFood;
                    foodEdit.nameFood = name;
                    foodEdit.price = price;
                    foodEdit.imageFood = linkImage;
                    db.SaveChanges();
                    msg.Show("Sửa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                    loadListFood();
                }
            }
            else
            {
                if (name == "")
                {
                    msg.Show("Vui lòng nhập tên món ăn !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
                else
                {
                    msg.Show("Vui lòng nhập giá món ăn là số!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
            }
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
        #endregion
        #region Event

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bool check = true;
                if (string.IsNullOrEmpty(txtFoodName.Text))
                {
                    errorProvider1.SetError(txtFoodName, "Tên món ăn không được bỏ trống. Vui lòng nhập vào"); check = false;
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    errorProvider1.SetError(txtPrice, "Giá không được để trống, vui lòng nhập vào "); check = false;
                }
                
                AddFood();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFoodName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtFoodName, "Tên thức ăn không chứa số ");
            }
            else {
                errorProvider1.SetError(txtFoodName, null);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtPrice, "giá chỉ cho phép nhập số ");
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            EditFood();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
             DeleteFood();
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            loadListFood();
            txtSearchFood.Text = string.Empty;

        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            loadListFoodByName(txtSearchFood.Text);
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            Thread threadGetFile = new Thread(new ThreadStart(GetFile));
            threadGetFile.ApartmentState = ApartmentState.STA;
            threadGetFile.Start();
        }

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
                cbbFoodCategory.SelectedIndex = (int)row.Cells[2].Value - 1;
                LoadImageFoodByIdFood((int)row.Cells[0].Value);
            }
            catch
            {

            }
        }
        public bool ChangeStatus(bool status, int idFood)
        {
            Food food = (from f in db.Food where f.idFood == idFood select f).FirstOrDefault();
            food.statusFood = "Đang bán";
            //string query = string.Format("update food set statusFood = N'Đang bán' where idFood = " + idFood);
            if (status == false) food.statusFood = "Tạm ngưng";// query = string.Format("update food set statusFood = N'Tạm ngưng' where idFood = " + idFood);
            //int result = DataProvider.Instance.ExecuteNonQuery(query);
            return db.SaveChanges() > 0;
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
                msg.Show("Vui lòng chọn món trước khi điều chỉnh", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
            }
        }
        #endregion
    }
}
