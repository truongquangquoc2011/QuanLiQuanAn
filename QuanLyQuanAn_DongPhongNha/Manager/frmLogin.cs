using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn_DongPhongNha.Manager
{
    public partial class frmLogin : Form
    {
        QLNHEntities DB = new QLNHEntities();

        public frmLogin()
        {
            InitializeComponent();

        }
        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Lưu tài khoản
        bool Login(string userName, string passWord)
        {
            List<Account> login = (from acc in DB.Account
                                   where acc.userName == userName && acc.passWord == passWord
                                   select acc).ToList();
            return login.Count() > 0;
        }

        #endregion

        #region Event

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "User";
                txtUser.ForeColor = Color.Black;
            }
        }
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "User")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.DimGray;
            }
        }
        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "Password")
            {
                txtPassWord.Text = "";
                txtPassWord.ForeColor = Color.DimGray;
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {

        }
        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassWord.Text;
            if (Login(userName, password))
            {
                Account loginAccount = (from acc in DB.Account
                                        where acc.userName == userName
                                        select acc).First();

                frmMain frm = new frmMain(loginAccount);

                this.Hide();
                frm.ShowDialog();
                this.Show();
                frm.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                msg.Show("Thông tin tài khoản không hợp lệ !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
        }
        #endregion

        private void cbkCheckPassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkCheckPassWord.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            if (!cbkCheckPassWord.Checked)
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = true;
        }
    }
}

