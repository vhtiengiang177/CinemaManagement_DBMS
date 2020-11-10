using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class fAddEmployee : Form
    {
        public fAddEmployee()
        {
            InitializeComponent();
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNameEmployee.Clear();
            cmbTypeEmployee.SelectedValue = null;
            txtBirthday.Clear();
            txtSalary.Clear();
            txtIndentity.Clear();
            txtPhoneEmployee.Clear();
            txtEmailEmployee.Clear();
            txtAddressEmployee.Clear();

            rdbFemale.Checked = false;
            rdbMale.Checked = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
