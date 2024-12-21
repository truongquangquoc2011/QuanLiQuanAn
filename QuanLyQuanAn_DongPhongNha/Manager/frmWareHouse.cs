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
        public frmWareHouse()
        {
            InitializeComponent();
        }

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
