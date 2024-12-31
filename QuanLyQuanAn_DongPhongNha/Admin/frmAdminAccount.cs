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
using QuanLyQuanAn_DongPhongNha.Manager;

namespace QuanLyQuanAn_DongPhongNha.Admin
{
    public partial class frmAdminAccount : Form
    {
        QLNHEntities db = new QLNHEntities();
        public frmAdminAccount()
        {
            InitializeComponent();
            columnRatio();
            Load();
        }


        #region Method

        public void columnRatio()
        {
            int totalWidth = dgvAccount.Width;
            int column1Width = (int)(totalWidth * 0.3);
            int column2Width = (int)(totalWidth * 0.3);
            int column3Width = (int)(totalWidth * 0.3);
            int column4Width = (int)(totalWidth * 0.1);
            dgvAccount.Columns[0].Width = column1Width;
            dgvAccount.Columns[1].Width = column2Width;
            dgvAccount.Columns[2].Width = column3Width;
            dgvAccount.Columns[3].Width = column4Width;

        }

        void Load()
        {
            LoadAccount();
        }
        private void LoadAccount()
        {
            int n = 0;
            dgvAccount.Rows.Clear();
            foreach (var item in (from a in db.Account select a).ToList())
            {
                n = dgvAccount.Rows.Add();
                dgvAccount.Rows[n].Cells[0].Value = item.userName;
                dgvAccount.Rows[n].Cells[1].Value = item.displayName;
                dgvAccount.Rows[n].Cells[2].Value = item.typeAccount;
                dgvAccount.Rows[n].Cells[3].Value = item.idStaff;
            }
            lblTotalAccount.Text = "Tổng số tài khoản: " + dgvAccount.Rows.Count.ToString();
            setDataGridView(dgvAccount);
        }

        //load tài khoản theo tên
        private void loadAccountByName(string accountName)
        {
            int index = 0;
            dgvAccount.Rows.Clear();
            foreach (var item in
                (from acc in db.Account
                 where acc.displayName.Contains(accountName)
                 select acc).ToList()
                 )
            {
                index = dgvAccount.Rows.Add();
                dgvAccount.Rows[index].Cells[0].Value = item.userName;
                dgvAccount.Rows[index].Cells[1].Value = item.displayName;
                dgvAccount.Rows[index].Cells[2].Value = item.typeAccount;
                dgvAccount.Rows[index].Cells[3].Value = item.idStaff;
            }
            lblTotalAccount.Text = "Tổng số tài khoản: " + dgvAccount.Rows.Count.ToString();
            setDataGridView(dgvAccount);

        }
        public void setDataGridView(DataGridView dataGridView)
        {
            //fontSize 
            int desiredFontSize = 12;

            //chỉnh fontSize cho toàn bộ dvg
            dataGridView.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            //chỉnh frontSize cho tên cột
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        //thêm account
        void AddAccount()
        {
            string userName = txtAccountName.Text;
            string password = txtPassword.Text;
            string retypePassword = txtRetypePassword.Text;
            string displayName = txtDisplayName.Text;
            int typeAccount = Int32.Parse(nudTypeAccount.Text);
            string idStaff = txtIdStaff.Text;

            if (userName == "" || password == "" || retypePassword == "" || displayName == "" || idStaff == "")
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin !!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
            }
            else
            {
                //kiểm tra tài khoản đã tồn tại hay chưa
                if ((from a in db.Account where a.userName == userName select a).FirstOrDefault() != null)
                {
                    msg.Show("Tài khoản đã tồn tại !!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);

                }
                else
                {
                    //kiểm tra lại mặt khẩu đã nhập có trùng với mặt khẩu hay chưa
                    if (!password.Equals(retypePassword))
                    {
                        msg.Show("Mật khẩu nhập lại không trùng với mật khẩu mới", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                    else
                    {
                        //kiểm tra nhân viên đã tồn tại hay chưa
                        if ((from x in db.Staff where x.idStaff == idStaff select x).FirstOrDefault() == null)
                        {
                            msg.Show("Mã nhân viên không tồn tại !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                        else
                        {
                            try
                            {
                                db.USP_InsertAccount(userName, password, displayName, typeAccount, idStaff);
                                LoadAccount();
                                msg.Show("Tạo tài khoản thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                                resetText();
                            }
                            catch
                            {
                                msg.Show("Có lỗi khi tạo tài khoản", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
                            }
                        }
                    }

                }
            }
        }

        //sửa tài khoản
        void EditAccount()
        {
            string userName = txtAccountName.Text;
            string password = txtPassword.Text;
            string retypePassword = txtRetypePassword.Text;
            string displayName = txtDisplayName.Text;
            int typeAccount = Int32.Parse(nudTypeAccount.Text);
            string idStaff = txtIdStaff.Text;

            if (userName == "" || displayName == "" || idStaff == "")
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin !!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
                return;
            }

            // Kiểm tra tài khoản có tồn tại
            var account = (from x in db.Account where x.userName == userName select x).FirstOrDefault();
            if (account == null)
            {
                msg.Show("Tài khoản không hợp lệ.\nVui lòng chọn đúng tài khoản cần sửa", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
                return;
            }

            // Kiểm tra nếu người dùng cố gắng thay đổi mật khẩu
            if (!string.IsNullOrEmpty(password) || !string.IsNullOrEmpty(retypePassword))
            {
                msg.Show("Bạn không thể thay đổi mật khẩu tại đây!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                return;
            }

            // Kiểm tra mã nhân viên
            var staff = (from nv in db.Staff where nv.idStaff == idStaff select nv).FirstOrDefault();
            if (staff == null)
            {
                msg.Show("Mã nhân viên không tồn tại", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                return;
            }

            try
            {
                // Cập nhật thông tin tài khoản
                account.displayName = displayName;
                account.typeAccount = typeAccount;
                account.idStaff = idStaff;

                db.SaveChanges();
                msg.Show("Sửa thông tin tài khoản thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                resetText();
            }
            catch
            {
                msg.Show("Có lỗi khi sửa thông tin tài khoản", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
        }

        //xóa tài khoản
        void DeleteAccount()
        {
            string userName = txtAccountName.Text.Trim();
            try
            {
                // kiem tra tai khoan co hop le hay khong va userName co bang khoang trong khong
                if (userName == "" || (from x in db.Account where x.userName == userName select x).FirstOrDefault() == null)
                {
                    msg.Show("Tài khoản không hợp lệ.\n Vui lòng chọn đúng tài khoản cần sửa", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
                }
                else
                {
                    // hoi nguoi dung xem co chac chan khong
                    if (msg.Show("Bạn có chắc chắn muốn xóa tài khoản ? ", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            // lay ra account tuong ung tren userName
                            Account acc = (from x in db.Account where x.userName == userName select x).FirstOrDefault();
                            db.Account.Remove(acc);
                            db.SaveChanges();
                            msg.Show("Xóa tài khoản thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);

                        }
                        catch
                        {
                            msg.Show("Đã xảy ra lỗi khi xóa tài khoản", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                        }
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa tài khoản này!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
        }


        void ResetPassword()
        {
            string userName = txtAccountName.Text.Trim();

            if (userName == "" || (from x in db.Account where x.userName == userName select x).FirstOrDefault() == null)
            {
                msg.Show("Tài khoản không hợp lệ.\n Vui lòng chọn đúng tài khoản cần sửa", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
            }
            else
            {
                if (msg.Show("Bạn có chắc chắn muốn đặt lại mật khẩu?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Lấy tài khoản tương ứng từ cơ sở dữ liệu
                        Account acc = (from x in db.Account where x.userName == userName select x).FirstOrDefault();

                        // Chuyển sang form frmAccount với thông tin tài khoản
                        frmAccount accountForm = new frmAccount(acc);
                        accountForm.ShowDialog(); // Sử dụng ShowDialog để form hoạt động trong chế độ modal
                    }
                    catch (Exception ex)
                    {
                        msg.Show($"Đã xảy ra lỗi: {ex.Message}", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
        }
        void resetText()
        {
            txtAccountName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtDisplayName.Text = string.Empty;
            txtRetypePassword.Text = string.Empty;
            txtIdStaff.Text = string.Empty;
        }
        #endregion

        #region Event
        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvAccount.Rows[rowIndex];
                txtAccountName.Text = row.Cells[0].Value.ToString();
                txtDisplayName.Text = row.Cells[1].Value.ToString();
                nudTypeAccount.Text = row.Cells[2].Value.ToString();
                txtIdStaff.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void txtFindAccountByName_TextChanged(object sender, EventArgs e)
        {
            loadAccountByName(txtFindAccountByName.Text);
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
            txtFindAccountByName.Text = "";
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount();
            LoadAccount();
        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            EditAccount();
            LoadAccount();
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccount();
            LoadAccount();
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword();
            LoadAccount();
        }
        #endregion
    }
}
