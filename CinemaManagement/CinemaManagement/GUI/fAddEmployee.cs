﻿using CinemaManagement.BLL;
using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement.GUI
{
    public partial class fAddEmployee : Form
    {

        MemoryStream ms;
        byte[] arrImage = null;
        public static string idNew;

        public fAddEmployee()
        {
            InitializeComponent();
            setArrayByteImage();
            setDataCmbCinema();
            setDataCmbTypeEmployee();
        }

        public fAddEmployee(string id)
        {
            fAddEmployee.idNew = id;
            InitializeComponent();
            setArrayByteImage();
            setDataCmbCinema();
            setDataCmbTypeEmployee();
            txtID.Text = fAddEmployee.idNew;
            txtID.Enabled = false;
        }

        public void setDataCmbTypeEmployee()
        {
            cmbTypeEmployee.DataSource = Employee_BL.Instance.getDataTypeEmployee();
            cmbTypeEmployee.ValueMember = "id_typeemployee";
            cmbTypeEmployee.DisplayMember = "name_typeemployee";
        }


        public void setDataCmbCinema()
        {
            cmbCinema.DataSource = Employee_BL.Instance.getDataCinema();
            cmbCinema.ValueMember = "id_cinema";
            cmbCinema.DisplayMember = "name_cinema";
        }


        public void clearValue()
        {
           
            txtNameEmployee.Clear();
            cmbTypeEmployee.Text = "";
            cmbCinema.Text = "";
            txtID.Text = fAddEmployee.idNew;
            txtBirthday.Clear();
            txtSalary.Clear();
            txtIndentity.Clear();
            txtPhoneEmployee.Clear();
            txtEmailEmployee.Clear();
            txtAddressEmployee.Clear();         
            rdbFemale.Checked = false;
            rdbMale.Checked = false;
        }

        /// <summary>
        /// Để set giá trị arrayImage tránh tình trạng giá trị null và lấy giá trị
        /// </summary>
        public void setArrayByteImage()
        {
            ms = new MemoryStream();
            this.picEmployee.Image.Save(ms, picEmployee.Image.RawFormat);
            arrImage = ms.GetBuffer();
            ms.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearValue();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open File";
            openFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                this.picEmployee.Image = System.Drawing.Image.FromFile(openFile.FileName);
                setArrayByteImage();
            }
        }


        public Employee createEmp()
        {
            string gender = "";
            if (rdbFemale.Checked)
                gender = "Nữ";
            else gender = "Nam";

            Byte state = 1;

            DateTime birthDay;
            if (this.txtBirthday.Text != "")
                birthDay = DateTime.Parse(this.txtBirthday.Text);
            else birthDay = DateTime.Now;

            Double salary = 0;
            if (this.txtSalary.Text != "")
            salary = Convert.ToDouble(this.txtSalary.Text);
            string name = txtNameEmployee.Text.Trim();

            Employee emp = new Employee();
            emp = new Employee(this.txtID.Text.Trim(),
                                     name,
                                     birthDay,
                                     gender.Trim(),
                                     this.txtIndentity.Text.Trim(),
                                     this.txtPhoneEmployee.Text.Trim(),
                                     this.txtEmailEmployee.Text.Trim(),
                                     this.txtAddressEmployee.Text.Trim(),
                                     salary,
                                     this.cmbTypeEmployee.SelectedValue.ToString().Trim(),
                                     this.cmbCinema.SelectedValue.ToString().Trim(),
                                     arrImage,
                                     this.txtID.Text.Trim(),
                                     state); return emp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Employee_BL.Instance.InsertEmployee(createEmp()) )
                {
                    MessageBox.Show("Đã thêm thành công !");
                    
                    fAddEmployee.idNew = (string)Employee_BL.Instance.createNewIDEmployee();
                    clearValue();

                }
              
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm vào table Employee !" + ex.Message);
            }
        }
    }
}