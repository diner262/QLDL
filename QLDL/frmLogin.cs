using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QLDL
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        string UserName = "admin";
        string PassWord = "123456";
        QLDKDULICHEntities data = new QLDKDULICHEntities();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            panelUser.BackColor = Color.White;
            txtPassword.BackColor = SystemColors.Control;
            panelPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panelPassword.BackColor = Color.White;
            txtUser.BackColor = SystemColors.Control;
            panelUser.BackColor = SystemColors.Control;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                btnHide.BringToFront();
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                btnShow.BringToFront();
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.TextLength == 0 || txtPassword.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (checkAccount(txtUser.Text, txtPassword.Text))
            {
                frmMain frmMain = new frmMain();
                txtUser.Clear();
                txtPassword.Clear();
                frmMain.Show();
                this.Hide();

                frmMain.Logout += frmMain_Logout;
            }

            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu. Vui lòng thử lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmMain_Logout(object sender, EventArgs e)
        {
            (sender as frmMain).Close();
            this.Show();
        }

        bool checkAccount(String username, String password)
        {
            if (username == this.UserName && password == this.PassWord)
            {
                return true;
            }

            var u = data.tUser
                    .Where(x => x.TenDangNhap == txtUser.Text & x.MatKhau == txtPassword.Text)
                    .FirstOrDefault();
            if (u != null)
            {
                return true;
            }

            return false;
        }
    }
}