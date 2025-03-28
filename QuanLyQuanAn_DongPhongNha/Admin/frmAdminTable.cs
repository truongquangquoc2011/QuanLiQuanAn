﻿using QuanLyQuanAn_DongPhongNha.Manager;
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

namespace QuanLyQuanAn_DongPhongNha.Admin
{
    public partial class frmAdminTable : Form
    {
        QLNHEntities db = new QLNHEntities();
        public frmAdminTable()
        {
            InitializeComponent();
            columnRatio();
            Load();
        }
        #region Event

        private void txtTableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(txtTableName, "Tên bàn chỉ được nhập kí chữ và số!");
            }
            else
            {
                errorProvider1.SetError(txtTableName, null);
            }
        }

        private void txtTableStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(txtTableStatus, "Vui lòng không nhập các kí tự đặc biệt!");
            }
            else
            {
                errorProvider1.SetError(txtTableStatus, null);
            }
        }

        private void dgvTableFood_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvTableFood.Rows[rowIndex];
                txtTableID.Text = row.Cells[0].Value.ToString();
                txtTableName.Text = row.Cells[1].Value.ToString();
                txtTableStatus.Text = row.Cells[2].Value.ToString();
            }
            catch
            {
                msg.Show("Không có dữ liệu để hiển thị. Vui lòng chọn một dòng hợp lệ!", "Lỗi", msg.Buttons.Yes, msg.Icon.Error);
            }

        }

        private void txtFindTableName_TextChanged(object sender, EventArgs e)
        {
            LoadListTableFoodByName(txtFindTableName.Text);
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            EditTable();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            DeleteTable();
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadTableFood();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AddTable();
            try
            {
                errorProvider1.Clear();
                bool check = true;
                if (string.IsNullOrEmpty(txtTableName.Text))
                {
                    errorProvider1.SetError(txtTableName, "Vui lòng nhập đầy đủ thông tin");
                    check = false;
                }
               
                if (!check)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Method
        public void columnRatio()
        {
            int totalWidth = dgvTableFood.Width;
            int column1Width = (int)(totalWidth * 0.2);
            int column2Width = (int)(totalWidth * 0.4);
            int column3Width = (int)(totalWidth * 0.4);

            dgvTableFood.Columns[0].Width = column1Width;
            dgvTableFood.Columns[1].Width = column2Width;
            dgvTableFood.Columns[2].Width = column3Width;
        }

        void Load()
        {
            LoadTableFood();
        }

        private void LoadTableFood()
        {
            int n = 0;
            dgvTableFood.Rows.Clear();
            foreach (var item in (from t in db.TableFood select t).ToList())
            {
                n = dgvTableFood.Rows.Add();
                dgvTableFood.Rows[n].Cells[0].Value = item.idTable;
                dgvTableFood.Rows[n].Cells[1].Value = item.nameTable;
                dgvTableFood.Rows[n].Cells[2].Value = item.statusTable;
            }
            lblTotalTableFood.Text = "Tổng số bàn ăn: " + dgvTableFood.Rows.Count.ToString();
            setDataGridView(dgvTableFood);
        }

        // load ban them ten
        void LoadListTableFoodByName(string tableName)
        {
            int n = 0;
            dgvTableFood.Rows.Clear();
            foreach (var item in (from t in db.TableFood where t.nameTable.Contains(tableName) select t).ToList())
            {
                n = dgvTableFood.Rows.Add();
                dgvTableFood.Rows[n].Cells[0].Value = item.idTable;
                dgvTableFood.Rows[n].Cells[1].Value = item.nameTable;
                dgvTableFood.Rows[n].Cells[2].Value = item.statusTable;
            }
            lblTotalTableFood.Text = "Tổng số bàn ăn: " + dgvTableFood.Rows.Count.ToString();
            setDataGridView(dgvTableFood);
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

        void AddTable()
        {
            string nameTable = txtTableName.Text;
            if (nameTable != "")
            {
                if ((from t in db.TableFood where t.nameTable == nameTable select t).FirstOrDefault() != null)
                {
                    if (msg.Show("Tên bàn đã tồn tại. Bạn có muốn thêm?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Info) == DialogResult.Yes)
                    {
                        db.TableFood.Add(new TableFood() { nameTable = nameTable });
                        if (db.SaveChanges() > 0)
                        {
                            msg.Show("Thêm bàn thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            Load();
                        }
                        else
                        {
                            msg.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                    }
                }
                else
                {

                    db.TableFood.Add(new TableFood() { nameTable = nameTable, statusTable = "Trống" });
                    db.SaveChanges();
                    msg.Show("Thêm bàn thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                    Load();
                }
            }
            else
            {
                msg.Show("Vui lòng nhập đầy đủ!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        void DeleteTable()
        {
            int idTable = Int32.Parse(txtTableID.Text);
            string name = txtTableName.Text;
            try
            {
                if (msg.Show("Bạn có chắc chắn muốn xóa " + name + "?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                {
                    db.TableFood.Remove((from t in db.TableFood where t.idTable == idTable select t).FirstOrDefault());
                    if (db.SaveChanges() > 0)
                    {
                        msg.Show("Xóa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);

                        Load();
                    }
                    else
                    {
                        msg.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa bàn này!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
        }

        void EditTable()
        {
            int idTable = Int32.Parse(txtTableID.Text);
            string nameTable = txtTableName.Text;
            TableFood table = (from t in db.TableFood where t.nameTable == nameTable select t).FirstOrDefault();
            if (nameTable != "")
            {
                if (table != null)
                {
                    if (msg.Show("Tên bàn đã tồn tại.\n Bạn có muốn sửa tên bàn?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        table.nameTable = nameTable;
                        if (db.SaveChanges() > 0)
                        {
                            msg.Show("Sửa danh mục thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            Load();
                        }
                        else
                        {
                            msg.Show("Đã xảy ra lỗi khi sửa!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                    }
                }
                else
                {
                    table = (from t in db.TableFood where t.idTable == idTable select t).FirstOrDefault();
                    table.nameTable = nameTable;
                    if (db.SaveChanges() > 0)
                    {
                        msg.Show("Sửa danh mục thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        Load();
                    }
                    else
                    {
                        msg.Show("Đã xảy ra lỗi khi sửa!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                msg.Show("Vui lòng nhập đầy đủ!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
            }
        }
        #endregion

        private void frmAdminTable_Load(object sender, EventArgs e)
        {

        }
    }
}
