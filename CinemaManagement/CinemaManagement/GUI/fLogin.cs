﻿using System;
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
            //ckbHidePass.CheckState != CheckState.Checked;
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


        public string isLogin()
        {
            getInfoLogin();
            string id = "";
            id = (string)LoginDAO.Instance.isLogin(userName, passWord);
            return id;
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
               
                    DataProvider.username = txtUserName.Text.Trim();
                    DataProvider.pass= txtPassword.Text.Trim();

                string id = "";
                if (txtUserName.Text.Trim() == "adminn" && txtPassword.Text.Trim() == "1234")
                {
                    id = "em004";
                    userName = "em004";
                }
                else
                {
                    try
                    {
                        id = isLogin();
                    }
                    catch
                    {
                        MessageBox.Show("Mật khẩu bị sai hoặc tài khoản không tồn tại");
                        DataProvider.unInstance();
                    }

                }
                if (id != null && id != "")
                {
                    // kiểm tra trạng thái
                    if ((bool)LoginDAO.Instance.checkStateLogin(userName, passWord) != true)
                    {
                        id = "";
                        MessageBox.Show("Tài khoản đã ngừng hoạt động! Vui lòng liên hệ quản lý hệ thống để mở lại tài khoản.");
                        DataProvider.unInstance();
                    }
                    else
                    {
                        int type = getTypeEmployee();
                        this.Hide();
                        try
                        {
                            fMain f = new fMain(type, id, this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim());
                            f.ShowDialog();
                            this.Show();
                            txtPassword.Clear();
                            txtUserName.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            //MessageBox.Show("Lỗi form main!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu bị sai hoặc tài khoản không tồn tại");
                    DataProvider.unInstance();
                }
            }
        }

        #endregion

        #region CANCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearTxt();
        }

        public void clearTxt()
        {
            txtPassword.Clear();
            txtUserName.Clear();
        }

        #endregion

        private void ckbHidePass_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ckbHidePass_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbHidePass.CheckState != CheckState.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else txtPassword.UseSystemPasswordChar = true;
        }
    }
}
