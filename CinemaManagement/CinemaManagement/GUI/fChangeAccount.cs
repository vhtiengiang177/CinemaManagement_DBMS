using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.DAO;
namespace CinemaManagement.GUI
{
   
    public partial class fChangeAccount : Form
    {
        string userName = "";
        string oldPassword = "";
        public fChangeAccount()
        {
            InitializeComponent();
        }

        public fChangeAccount(string username, string pass)
        {
            InitializeComponent();
            userName = username;
            txtTDN.Text = username;
            oldPassword = pass;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f;
            a = 1; b = 1; c = 1; d = 1; f = 1;
            if (String.Compare(txtPassW.Text.ToString().Trim(), oldPassword.Trim(), true) != 0) MessageBox.Show("Mật khẩu không đúng !"); else f = 0;
            if (txtPassW.Text == "") MessageBox.Show("Chưa nhập mật khẩu"); else a = 0;
            if (txtNewPass.Text == "") MessageBox.Show("Chưa nhập mật khẩu mới"); else b = 0;
            if (txtNewPass.Text == txtPassW.Text) MessageBox.Show("Mật khẩu trùng với mật khẩu cũ"); else c = 0;
            if (txtAgainPass.Text != txtNewPass.Text) MessageBox.Show("Mật khẩu không khớp"); else d = 0;
            if (a == 0 && b == 0 && c == 0 && d == 0 && f == 0)
            {
                if (isUpdatePass())
                {
                    MessageBox.Show("Cập nhập thành công !");
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhập không thành công:");
            }

        }
        private bool isUpdatePass()
        {
            bool f = EmployeeDAO.Instance.updatePassLogin(userName, oldPassword.Trim(), txtNewPass.Text.ToString());
            return f;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtAgainPass.ResetText();
            txtNewPass.ResetText();
            txtPassW.ResetText();
        }

        private void ckShowPassOld_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowPassOld.Checked)
                txtPassW.UseSystemPasswordChar = false;
            else txtPassW.UseSystemPasswordChar = true;
        }

        private void ckbShowNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowNewPass.Checked)
                txtNewPass.UseSystemPasswordChar = false;
            else txtNewPass.UseSystemPasswordChar = true;
        }

        private void ckbShowAgainPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowAgainPass.Checked)
                txtAgainPass.UseSystemPasswordChar = false;
            else txtAgainPass.UseSystemPasswordChar = true;
        }
    }
}
