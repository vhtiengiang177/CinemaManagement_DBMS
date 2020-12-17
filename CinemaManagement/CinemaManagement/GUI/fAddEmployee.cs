using CinemaManagement.BLL;
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
using CinemaManagement.DAO;

namespace CinemaManagement.GUI
{

    public partial class fAddEmployee : Form
    {
        string MessErr = "";
        MemoryStream ms;
        byte[] arrImage = null;
        public static string idNew;
        public static string idCinemaCurrent = "";

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

        public fAddEmployee(string id, string idCinema)
        {
            fAddEmployee.idNew = id;
            fAddEmployee.idCinemaCurrent = idCinema;
            InitializeComponent();
            setArrayByteImage();
            setDataCmbCinema();
            setDataCmbTypeEmployee();
            txtID.Text = fAddEmployee.idNew;
            txtID.Enabled = false;
        }

        #region SET DATA
        public void setDataCmbTypeEmployee()
        {
            if (idCinemaCurrent == "")
                cboTypeEmployee.DataSource = EmployeeDAO.Instance.getDataTypeForAddEmployee();
            else cboTypeEmployee.DataSource = EmployeeDAO.Instance.getDataTypeForAddEmployeeOfCinemaAcurrent();
            cboTypeEmployee.ValueMember = "id_typeemployee";
            cboTypeEmployee.DisplayMember = "name_typeemployee";
        }


        public void setDataCmbCinema()
        {
            if(idCinemaCurrent == "")
                cboCinema.DataSource = EmployeeDAO.Instance.getDataCinema();
            else cboCinema.DataSource = EmployeeDAO.Instance.getDataCinemaForCinemaCurrent(idCinemaCurrent);

            cboCinema.ValueMember = "id_cinema";
            cboCinema.DisplayMember = "name_cinema";
        }


        public void clearValue()
        {
           
            txtNameEmployee.Clear();
            cboTypeEmployee.Text = "";
            cboCinema.Text = "";
            txtID.Text = fAddEmployee.idNew;
            //txtBirthday.Clear();
            txtSalary.Clear();
            txtIndentity.Clear();
            txtPhoneEmployee.Clear();
            txtEmailEmployee.Clear();
            txtAddressEmployee.Clear();         
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
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


        public Employee createEmp()
        {
            string gender = "";
            if (rdoFemale.Checked)
                gender = "Nữ";
            else gender = "Nam";

            Byte state = 1;

            DateTime birthDay = dpkBirthDateEmp.Value;
            //if (this.txtBirthday.Text != "")
            //    birthDay = DateTime.Parse(this.txtBirthday.Text);
            //else birthDay = DateTime.Now;

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
                                     this.cboTypeEmployee.SelectedValue.ToString().Trim(),
                                     this.cboCinema.SelectedValue.ToString().Trim(),
                                     arrImage,
                                     this.txtID.Text.Trim(),
                                     state); return emp;
        }

        #endregion

        #region ADD

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

        public void RemovetxtIndentity(object sender, EventArgs e)
        {
            if (txtIndentity.Text.Contains("đã tồn tại"))
            {
                txtIndentity.Clear();
            }
        }

        public void RemovetxtPhone(object sender, EventArgs e)
        {
            if (txtPhoneEmployee.Text.Contains("đã tồn tại"))
            {
                txtPhoneEmployee.Clear();
            }
        }

        public void RemovetxtEmail(object sender, EventArgs e)
        {
            if (txtEmailEmployee.Text.Contains("đã tồn tại"))
            {
                txtEmailEmployee.Clear();
            }
        }

        public void RemovetxtName(object sender, EventArgs e)
        {
            if (txtNameEmployee.Text.Contains("không được để trống"))
            {
                txtNameEmployee.Clear();
            }
        }

        public void RemovetxtSalary(object sender, EventArgs e)
        {
            if (txtSalary.Text.Contains("không được để trống"))
            {
                txtSalary.Clear();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int err = 0;
                if(EmployeeDAO.Instance.search_IdentityCardEmployee(txtIndentity.Text).Rows.Count != 0)
                {
                    txtIndentity.Text = "CMND đã tồn tại !";
                    
                    err = err + 1;
                    txtIndentity.GotFocus += RemovetxtIndentity;
                }

                if (EmployeeDAO.Instance.search_PhoneEmployee(txtPhoneEmployee.Text).Rows.Count != 0)
                {
                    txtPhoneEmployee.Text = "SĐT đã tồn tại !";
                    err = err + 1;
                    txtPhoneEmployee.GotFocus += RemovetxtPhone;
                }

                if (EmployeeDAO.Instance.search_EmailEmployee(txtEmailEmployee.Text).Rows.Count != 0)
                {
                    txtEmailEmployee.Text = "Email đã tồn tại !";
                    err = err + 1;
                    txtEmailEmployee.GotFocus += RemovetxtEmail;
                }

                if(txtNameEmployee.Text == "")
                {
                    txtNameEmployee.Text = "Tên nhân viên không được để trống !";
                    err = err + 1;
                    txtNameEmployee.GotFocus += RemovetxtName;
                }

                if (txtSalary.Text == "")
                {
                    txtSalary.Text = "Lương nhân viên không được để trống !";
                    err = err + 1;
                    txtSalary.GotFocus += RemovetxtSalary;
                }

                if (err == 0)
                    if (EmployeeDAO.Instance.insertEmployee(createEmp()))
                    {
                        MessageBox.Show("Đã thêm thành công !");

                        fAddEmployee.idNew = (string)EmployeeDAO.Instance.createNewIDEmployee();
                        clearValue();

                    }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể thêm vào table Employee !" + ex.Message);
            }
        }
        #endregion

        #region CANCEL ADD
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearValue();

        }

        #endregion

        #region EXIT

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void fAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
