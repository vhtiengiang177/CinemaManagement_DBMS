using CinemaManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement.Customer
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent(); loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CustomerDAO.Instance.AddCustomer(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString()))
            {
                MessageBox.Show("Success");
                loadData();
            }
            else MessageBox.Show("error");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CustomerDAO.Instance.UpdateCustomer(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString()))
            {
                MessageBox.Show("Success");
                loadData();
            }
            else MessageBox.Show("error");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CustomerDAO.Instance.DeleteCustomer(txtID.Text))
            {
                MessageBox.Show("Success");
                loadData();
            }
            else MessageBox.Show("error");
        }

        void loadData()
        {
            dataGridView1.DataSource = CustomerDAO.Instance.LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerDAO.Instance.SearchCustomer(txtSearch.Text);
        }
    }
}
