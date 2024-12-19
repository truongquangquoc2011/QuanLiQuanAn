using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn_DongPhongNha.Admin
{
    public partial class frmAdminFood : Form
    {
        public frmAdminFood()
        {
            InitializeComponent();
        }

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
                if (!check)
                {
                    MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin ", "Thông Báo ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



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
    }
}
