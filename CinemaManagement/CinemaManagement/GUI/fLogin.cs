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
    public partial class fLogin : Form
    {
        private string sUserName;
        private string sPassWord;

        public string userName
        {
            get { return this.sUserName; }
            set { this.sUserName = value; }
        }

        public string passWord
        {
            get { return this.sPassWord; }
            set { this.sPassWord = value; }
        }

        public void getInfoLogin()
        {
            this.userName = txtUserName.Text.Trim();
            this.passWord = txtPassword.Text.Trim();
        }

        public fLogin()
        {
            InitializeComponent();
          
        }

        #region CHECK LOGIN


        /// <summary>
        /// Nếu thông tin đăng nhập đầy đủ thì return về 2
        /// </summary>
        /// <returns></returns>
        public int checkInfoLogin()
        {
            getInfoLogin();
            int a = 1, b = 1;
            if (this.userName == null || this.userName == "")
            {
                a = 0;
                MessageBox.Show("Không được để trống tên đăng nhập !");
                this.txtUserName.Focus();
            }

            if (this.passWord == null || this.passWord == "")
            {
                b = 0;
                MessageBox.Show("Không được để trống mật khẩu !");
                this.txtPassword.Focus();
            }

            return a + b;
        }


        public bool isLogin()
        {
            string temp = "";
            temp = (string)LoginDAO.Instance.isLogin(userName, passWord);
            if (temp != "" || temp != null)
                return true;
            return false;
        }

        #endregion

        #region DECENTRALIZATION

        public int getTypeEmployee()
        {
            string type = (string)LoginDAO.Instance.getTypeEmployee(userName);
            if (type.Contains("1")) return 1; //Nhân viên bán vé
            if (type.Contains("2")) return 2; //Nhân viên kỹ thuật
            if (type.Contains("3")) return 3; //Quản lý rạp
            if (type.Contains("4")) return 4; //Quản lý hệ thống
            return 0;
        }

        #endregion

        #region LOGIN

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(checkInfoLogin() == 2)
            {
                if(isLogin())
                {
                    int type = getTypeEmployee();
                    // Đăng nhập thành công, set quyền truy cập
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu !", "Thông báo", (MessageBoxButtons)MessageBoxIcon.Error);
                }
            }
        }

        #endregion

    }
}
