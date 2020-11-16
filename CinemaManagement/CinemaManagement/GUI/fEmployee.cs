using System;
using System.Collections;
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
using CinemaManagement.DTO;


namespace CinemaManagement.GUI
{
    public partial class fEmployee : Form
    {
        public static int cellClickIndex = 0;
        MemoryStream ms;
        byte[] arrImage = null;

        public fEmployee()
        {
            InitializeComponent();
            LoadData();
            btnCancel.Hide();
            btnAddImg.Hide();
            btnSave.Hide();
            unenableEdit(false);
            setArrayByteImage();
            this.txtID.Enabled = false;
        }
        #region LOADDATA

        public void LoadData()
        {
            dgvListEmployee.DataSource = EmployeeDAO.Instance.LoadData();
            dgvListEmployee.AutoResizeColumns();
            clearValue();
            setDataCmbTypeEmployee();
            setDataCmbCinema();
            cboSortTypeEmployee.Enabled = false;
            dgvListEmployee_CellClick(null, null);
        }

        public void setDataCmbTypeEmployee()
        {
            cboTypeEmployee.DataSource = EmployeeDAO.Instance.getDataTypeEmployee();
            cboTypeEmployee.ValueMember = "id_typeemployee";
            cboTypeEmployee.DisplayMember = "name_typeemployee";
        }

        public void setDataCmbSortTypeEmployee()
        {
            cboSortTypeEmployee.DataSource = EmployeeDAO.Instance.getDataTypeEmployee();
            cboSortTypeEmployee.ValueMember = "id_typeemployee";
            cboSortTypeEmployee.DisplayMember = "name_typeemployee";
        }

        public void setDataCmbCinema()
        {
            cmbCinema.DataSource = EmployeeDAO.Instance.getDataCinema();
            cmbCinema.ValueMember = "id_cinema";
            cmbCinema.DisplayMember = "name_cinema";
        }

        public void loadDataOnTextBoxInforEmployee(int r)
        {

                this.txtID.Text = dgvListEmployee.Rows[r].Cells[0].Value.ToString();
                this.txtNameEmployee.Text = dgvListEmployee.Rows[r].Cells[1].Value.ToString();
                this.txtBirthday.Text = dgvListEmployee.Rows[r].Cells[2].Value.ToString();
                string gender = dgvListEmployee.Rows[r].Cells[3].Value.ToString();
                if (gender == "Nữ")
                {
                    rdoFemale.Checked = true;
                }
                else
                    rdoMale.Checked = true;

                this.txtIndentity.Text = dgvListEmployee.Rows[r].Cells[4].Value.ToString();
                this.txtPhoneEmployee.Text = dgvListEmployee.Rows[r].Cells[5].Value.ToString();
                this.txtEmailEmployee.Text = dgvListEmployee.Rows[r].Cells[6].Value.ToString();
                this.txtAddressEmployee.Text = dgvListEmployee.Rows[r].Cells[7].Value.ToString();
                this.txtSalary.Text = dgvListEmployee.Rows[r].Cells[8].Value.ToString();
                this.cboTypeEmployee.Text = dgvListEmployee.Rows[r].Cells[9].Value.ToString();
                this.cmbCinema.Text = dgvListEmployee.Rows[r].Cells[10].Value.ToString();
                string state = dgvListEmployee.Rows[r].Cells[13].Value.ToString();
            
                if (state.Equals("True"))
                        this.txtStateEmployee.Text = "Vẫn còn hoạt động";
                    else this.txtStateEmployee.Text = "Ngưng hoạt động";

            if (dgvListEmployee.Rows[r].Cells[11].Value != DBNull.Value)
            {
                this.picEmployee.Image = (System.Drawing.Image)
             dgvListEmployee.Rows[r].Cells[11].FormattedValue;

                setArrayByteImage();
            }
            else this.picEmployee.Image = this.picEmployee.ErrorImage;

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

        #endregion

        private void btnLoadListEmployee_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        /// <summary>
        /// enable các textbox
        /// </summary>
        /// <param name="enable"></param>
        public void unenableEdit(bool enable)
        {
            this.txtNameEmployee.Enabled = enable;
           
            this.txtIndentity.Enabled = enable;
            this.txtPhoneEmployee.Enabled = enable;
            this.txtSalary.Enabled = enable;
            this.txtEmailEmployee.Enabled = enable;
            this.txtBirthday.Enabled = enable;
            this.cmbCinema.Enabled = enable;
            this.cboTypeEmployee.Enabled = enable;
            this.txtStateEmployee.Enabled = enable;
            this.txtAddressEmployee.Enabled = enable;
            this.rdoFemale.Enabled = enable;
            this.rdoMale.Enabled = enable;

        }

        private void dgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(sender != null)
            {
                fEmployee.cellClickIndex = dgvListEmployee.CurrentCell.RowIndex;
                loadDataOnTextBoxInforEmployee(fEmployee.cellClickIndex);
            }    
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            btnCancel.Show();
            btnAddImg.Show();
            btnSave.Show();
            unenableEdit(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeDAO.Instance.EditInfoEmployee(createEmp()) != 0)
                {
                    MessageBox.Show("Đã lưu thành công !");
                    LoadData();
                }
                btnCancel.Hide();
                btnAddImg.Hide();
                btnSave.Hide();
                unenableEdit(false);
            } catch(SqlException ex)
            {
                MessageBox.Show("Không thể lưu vào table Employee !" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadDataOnTextBoxInforEmployee(fEmployee.cellClickIndex);
        }


        /// <summary>
        /// Tạo một nhân viên chứa các giá trị đã chọn
        /// </summary>
        /// <returns></returns>
        public Employee createEmp()
        {
            string gender = "";
            if (rdoFemale.Checked)
                gender = "Nữ";
            else gender = "Nam";

            Byte state = 0;
            if (txtStateEmployee.Text.Contains("Ngưng"))
                state = 0;
            else state = 1;

            DateTime birthDay;
            if (this.txtBirthday.Text != "")
                birthDay = DateTime.Parse(this.txtBirthday.Text);
            else birthDay = DateTime.Now;

            Double salary = 0;
            if (this.txtSalary.Text != "")
                salary = Convert.ToDouble(this.txtSalary.Text);

            string name = dgvListEmployee.Rows[fEmployee.cellClickIndex].Cells[1].Value.ToString().Trim();
          
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
                                     this.cmbCinema.SelectedValue.ToString().Trim(),
                                     arrImage,
                                     this.txtID.Text.Trim(),
                                     state) ; return emp;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên đã chọn ?", "Thông tin", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
                try
                {
                    MessageBox.Show(txtID.Text.Trim());
                    if (EmployeeDAO.Instance.deleteEmployee(txtID.Text.Trim()))
                        MessageBox.Show("Đã xóa nhân viên");
                    LoadData();

                }catch(SqlException ex)
                { MessageBox.Show("Không thể xóa khỏi table Employee " + ex.Message);
                  
                }
        }
        



        public void clearValue()
        {
            txtID.Clear();
            txtNameEmployee.Clear();
            cboTypeEmployee.Text = "";
            cmbCinema.Text = "";
            txtBirthday.Clear();
            txtSalary.Clear();
            txtIndentity.Clear();
            txtPhoneEmployee.Clear();
            txtEmailEmployee.Clear();
            txtAddressEmployee.Clear();
            txtStateEmployee.Clear();
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
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

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            string idNew = (string)EmployeeDAO.Instance.createNewIDEmployee();
            fAddEmployee fAdd = new fAddEmployee(idNew);
            fAdd.ShowDialog();
        }

        private void cmbSortTypeEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSortTypeEmployee.Enabled)
            {
                string idType = cboSortTypeEmployee.SelectedValue.ToString().Trim();
                dgvListEmployee.DataSource = EmployeeDAO.Instance.search_TypeEmployee(idType);
            }
        }

        private void btnSortTypeEmployee_Click(object sender, EventArgs e)
        {
            cboSortTypeEmployee.Enabled = true;
            setDataCmbSortTypeEmployee();
          
        }
    }
}

