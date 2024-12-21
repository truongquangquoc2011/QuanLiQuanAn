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
    public partial class frmAdminTable : Form
    {
        public frmAdminTable()
        {
            InitializeComponent();
        }

        private void txtTableID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTableID, "Mã bàn không phải là nhập chữ");
            }
            else
            {
                errorProvider1.SetError(txtTableID, null);
            }
        }

        private void txtTableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTableName, "Tên bàn không phải là nhập số");
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
                errorProvider1.SetError(txtTableStatus, "Vui lòng không nhập các kí tự đặc biệt");
            }
            else
            {
                errorProvider1.SetError (txtTableStatus, null); 
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                bool check = true;
                if (string.IsNullOrEmpty(txtTableName.Text))
                {
                    errorProvider1.SetError(txtTableName, "Vui lòng nhập đầy đủ thông tin");
                    check = false;
                }
                if (string.IsNullOrEmpty(txtTableID.Text))
                {
                    errorProvider1.SetError(txtTableID, "Vui lòng nhập đầy đủ thông tin");
                    check = false;
                }
                if (string.IsNullOrEmpty(txtTableStatus.Text))
                {
                    errorProvider1.SetError(txtTableStatus, "Vui lòng nhập đầy đủ thông tin");
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
    }
}
