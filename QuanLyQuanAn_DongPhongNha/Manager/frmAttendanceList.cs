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
    public partial class frmAttendanceList : Form
    {
        public frmAttendanceList()
        {
            InitializeComponent();
        }

        private void txtStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(txtStaffID, "Vui lòng không nhập các kí tự đặc biệt");
            }
            else
            {
                errorProvider1.SetError(txtStaffID, null);
            }
        }

        private void txtStaffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(txtStaffName, "Vui lòng không nhập số");
            }
            else
            {
                errorProvider1.SetError(txtStaffName, null);
            }
        }

        private void txtSex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(txtSex, "Vui lòng không nhập số");
            }
            else
            {
                errorProvider1.SetError(txtSex, null);
            }
        }

        private void txtPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                errorProvider1.SetError(txtPosition, "Vui lòng không nhập số");
            }
            else
            {
                errorProvider1.SetError(txtPosition, null);
            }
        }

        private void txtDateOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtDateOfBirth, "Vui lòng không nhập chữ");
            }
            else
            {
                errorProvider1.SetError(txtDateOfBirth, null);
            }
        }

        private void txtIdentityCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtIdentityCard, "Vui lòng không nhập chữ");
            }
            else
            {
                errorProvider1.SetError(txtIdentityCard, null);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtPhoneNumber, "Vui lòng không nhập chữ");
            }
            else
            {
                errorProvider1.SetError(txtPhoneNumber, null);
            }
        }

        private void rtbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; 
                errorProvider1.SetError(rtbAddress, "Vui lòng không nhập các ký tự đặc biệt");
            }
            else
            {
                errorProvider1.SetError(rtbAddress, null); 
            }
        }
    }
}
