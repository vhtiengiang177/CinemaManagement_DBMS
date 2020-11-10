using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.BLL;
using CinemaManagement.DTO;

namespace CinemaManagement
{
    public partial class fEmployee : Form
    {
        public Employee emp;
        public fEmployee()
        {
            InitializeComponent();
            LoadData();
            btnCancel.Hide();
            btnAddImg.Hide();
            btnSave.Hide();
            unenableEdit(false);
        }


        public void LoadData()
        {
            dgvListEmployee.DataSource = Employee_BL.Instance.LoadData();
            dgvListEmployee.AutoResizeColumns();
            dgvListEmployee_CellClick(null, null);
        }

        public void loadDataOnTextBoxInforEmployee(int r)
        {

                this.txtID.Text = dgvListEmployee.Rows[r].Cells[0].Value.ToString();
                this.txtNameEmployee.Text = dgvListEmployee.Rows[r].Cells[1].Value.ToString() + " " + dgvListEmployee.Rows[r].Cells[2].Value.ToString();
                this.txtBirthday.Text = dgvListEmployee.Rows[r].Cells[3].Value.ToString();
                string gender = dgvListEmployee.Rows[r].Cells[4].Value.ToString();
                if (gender == "Nữ")
                {
                    rdbFemale.Checked = true;
                }
                else
                    rdbMale.Checked = true;

                this.txtIndentity.Text = dgvListEmployee.Rows[r].Cells[5].Value.ToString();
                this.txtPhoneEmployee.Text = dgvListEmployee.Rows[r].Cells[6].Value.ToString();
                this.txtEmailEmployee.Text = dgvListEmployee.Rows[r].Cells[7].Value.ToString();
                this.txtAddressEmployee.Text = dgvListEmployee.Rows[r].Cells[8].Value.ToString();
                this.txtSalary.Text = dgvListEmployee.Rows[r].Cells[9].Value.ToString();
                this.cmbTypeEmployee.Text = dgvListEmployee.Rows[r].Cells[10].Value.ToString();
                this.cmbCinema.Text = dgvListEmployee.Rows[r].Cells[11].Value.ToString();
                string state = dgvListEmployee.Rows[r].Cells[13].Value.ToString();
            
                if (state.Equals("True"))
                        this.txtStateEmployee.Text = "Vẫn còn hoạt động";
                    else this.txtStateEmployee.Text = "Ngưng hoạt động";
            
        }

        private void btnLoadListEmployee_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void unenableEdit(bool enable)
        {
            this.txtNameEmployee.Enabled = enable;
            this.txtID.Enabled = enable;
            this.txtIndentity.Enabled = enable;
            this.txtPhoneEmployee.Enabled = enable;
            this.txtSalary.Enabled = enable;
            this.txtEmailEmployee.Enabled = enable;
            this.txtBirthday.Enabled = enable;
            this.cmbCinema.Enabled = enable;
            this.cmbTypeEmployee.Enabled = enable;
            this.txtStateEmployee.Enabled = enable;
            this.txtAddressEmployee.Enabled = enable;
            this.rdbFemale.Enabled = enable;
            this.rdbMale.Enabled = enable;

        }

        private void dgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(sender != null)
            {
                loadDataOnTextBoxInforEmployee(dgvListEmployee.CurrentCell.RowIndex);
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
            btnCancel.Hide();
            btnAddImg.Hide();
            btnSave.Hide();
            unenableEdit(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadDataOnTextBoxInforEmployee(dgvListEmployee.CurrentCell.RowIndex);
        }

        public void createEmp()
        {
            string gender = "";
            if (rdbFemale.Checked)
                gender = "Nữ";
            else gender = "Nam";

           // this.emp = new Employee()
        }
    }
}
