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

namespace CinemaManagement
{
    public partial class fShifWorkEmployee : Form
    {
        public static int cellClickIndex;
        public fShifWorkEmployee()
        {
            InitializeComponent();
        }

        #region Close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Get Data

        public void setDataCboTypeEmployee()
        {
            cboTypeSearchEmployee.DataSource = EmployeeDAO.Instance.getDataTypeEmployee();
            cboTypeSearchEmployee.ValueMember = "id_typeemployee";
            cboTypeSearchEmployee.DisplayMember = "name_typeemployee";
        }

        public void setDataCboSortTypeEmployee()
        {
            cboSortTypeEmployee.DataSource = EmployeeDAO.Instance.getDataTypeEmployee();
            cboSortTypeEmployee.ValueMember = "id_typeemployee";
            cboSortTypeEmployee.DisplayMember = "name_typeemployee";
        }


        #endregion

        #region Type Employee

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            cboSortTypeEmployee.Enabled = true;
            setDataCboSortTypeEmployee();
        }

        private void cboSortTypeEmployee_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSortTypeEmployee.Enabled)
            {
                string idType = cboSortTypeEmployee.SelectedValue.ToString().Trim();
                dgvListEmployee.DataSource = EmployeeDAO.Instance.search_TypeEmployee(idType);
            }
        }

        #endregion

        #region Load dgv

        public void loadData()
        {
            dgvListEmployee.DataSource = EmployeeDAO.Instance.loadData();
            dgvListEmployee.AutoResizeColumns();
            clearValue();
            setDataCboTypeEmployee();
            cboSortTypeEmployee.Enabled = false;
            dgvListEmployee_CellClick(null, null);
        }
        #endregion

        private void dgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender != null)
            {
                fShifWorkEmployee.cellClickIndex = dgvListEmployee.CurrentCell.RowIndex;
                loadDataOnTextBoxInforEmployee(fShifWorkEmployee.cellClickIndex);
            }
        }

        public void loadDataOnTextBoxInforEmployee(int row)
        {
            this.txtID.Text = dgvListEmployee.Rows[row].Cells[0].Value.ToString();
            this.txtName.Text = dgvListEmployee.Rows[row].Cells[1].Value.ToString();
        }

        void clearValue()
        {
            txtID.Clear();
            txtName.Clear();
        }
    }
}
