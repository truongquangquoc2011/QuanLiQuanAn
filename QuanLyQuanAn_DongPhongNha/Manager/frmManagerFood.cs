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
    public partial class frmManagerFood : Form
    {
        public frmManagerFood()
        {
            InitializeComponent();
        }

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
    }
}
