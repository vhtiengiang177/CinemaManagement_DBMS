using CinemaManagement.DAO;
using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement.GUI
{
    public partial class fCustomer : Form
    {
        public static int typeEmployee;
        Customer customer = new Customer();
        public fCustomer()
        {
            InitializeComponent();
            loadData();
            fillCboTypeCustomer();
        }

        public fCustomer(int type)
        {
            InitializeComponent();
            fCustomer.typeEmployee = type;

            if (type == 1)
                btnDelete.Hide();
            fillCboTypeCustomer();
            loadData();
            
        }

        void reset()
        {
            txtAddressCustomer.ResetText();
            txtEmailCustomer.ResetText();
            txtFNameCustomer.ResetText();
            txtIdentityCardCustomer.ResetText();
            txtLNameCustomer.ResetText();
            txtPhoneCustomer.ResetText();
            txtPointCustomer.ResetText();
            //txtQrCustomer.ResetText();
            txtSexCustomer.ResetText();
            txtSearch.ResetText();
            txtIdCustomer.ResetText();
        }
        void loadCustomer()
        {
            customer.Id_Customer = this.txtIdCustomer.Text;
            customer.Fname_Customer = this.txtFNameCustomer.Text;
            customer.Lname_Customer = this.txtLNameCustomer.Text;
            customer.Birthday_Customer = this.dpkBirthDateCustomer.Value;
            customer.Sex_Customer = this.txtSexCustomer.Text;
            customer.Identitycard_Customer = this.txtIdentityCardCustomer.Text;
            customer.Phone_Customer = txtPhoneCustomer.Text;
            customer.Email_Customer = txtEmailCustomer.Text;
            customer.Address_Customer = txtAddressCustomer.Text;
            customer.Point_Customer = Convert.ToInt32(txtPointCustomer.Text);
            customer.Id_TypeCustomer = cboTypeCustomer.SelectedValue.ToString();
            //customer.Qr_Customer = txtQrCustomer.Text;
        }

        void showCustomer()
        {
            this.txtIdCustomer.Text = customer.Id_Customer;
            this.txtFNameCustomer.Text = customer.Fname_Customer;
            this.txtLNameCustomer.Text = customer.Lname_Customer;
            this.dpkBirthDateCustomer.Value = customer.Birthday_Customer;
            this.txtSexCustomer.Text = customer.Sex_Customer;
            this.txtIdentityCardCustomer.Text = customer.Identitycard_Customer;
            this.txtPhoneCustomer.Text = customer.Phone_Customer;
            this.txtEmailCustomer.Text = customer.Email_Customer;
            this.txtAddressCustomer.Text = customer.Address_Customer;
            this.txtPointCustomer.Text = customer.Point_Customer.ToString();
            this.cboTypeCustomer.Text = customer.Id_TypeCustomer.ToString();
            //this.txtQrCustomer.Text = customer.Qr_Customer;
        }
        string createAutoIdCustomer()
        {
            string lastID = CustomerDAO.Instance.getLastIdCustomer();
            //MessageBox.Show(lastID);
            int id = Convert.ToInt32(lastID[2].ToString() + lastID[3].ToString()) + 1;

            if (id < 10)
            {
                return "cu0" + id.ToString();
            }
            return "cu" + id.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                loadCustomer();
                string id = createAutoIdCustomer();
                if (CustomerDAO.Instance.AddCustomer(customer, id))
                {
                    MessageBox.Show("Thành công");
                    loadData();
                    reset();
                }
                else MessageBox.Show("Lỗi");
            }
            catch(SqlException ex )
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                loadCustomer();
                if (CustomerDAO.Instance.UpdateCustomer(customer))
                {
                    MessageBox.Show("Sửa Thành công");
                    loadData();
                    reset();
                }
                //else MessageBox.Show("Lỗi");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: "+ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loadCustomer();
            

            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc chắn xóa  khách hàng này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 

                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                   
                    if (CustomerDAO.Instance.DeleteCustomer(customer))
                    {
                        // Cập nhật lại DataGridView 
                        reset();
                        MessageBox.Show(" Xóa thành công!");
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadData()
        {
            dgvListCustomer.DataSource = CustomerDAO.Instance.LoadData();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvListCustomer.DataSource = CustomerDAO.Instance.SearchCustomer(txtSearch.Text);
        }

        void fillCboTypeCustomer()
        {
            cboTypeCustomer.DataSource = CustomerDAO.Instance.GetTypeCustomer();
            cboTypeCustomer.DisplayMember = "name_typecustomer";
            cboTypeCustomer.ValueMember = "id_typecustomer";
        }

        private void dgvListCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customer.Id_Customer = dgvListCustomer.CurrentRow.Cells[0].Value.ToString();
            customer.Lname_Customer = dgvListCustomer.CurrentRow.Cells[1].Value.ToString();
            customer.Fname_Customer = dgvListCustomer.CurrentRow.Cells[2].Value.ToString();
            customer.Birthday_Customer = Convert.ToDateTime(dgvListCustomer.CurrentRow.Cells[3].Value);
            customer.Sex_Customer = dgvListCustomer.CurrentRow.Cells[4].Value.ToString();
            customer.Identitycard_Customer = dgvListCustomer.CurrentRow.Cells[5].Value.ToString();
            customer.Phone_Customer = dgvListCustomer.CurrentRow.Cells[6].Value.ToString();
            customer.Email_Customer = dgvListCustomer.CurrentRow.Cells[7].Value.ToString();
            customer.Address_Customer = dgvListCustomer.CurrentRow.Cells[8].Value.ToString();
            customer.Point_Customer = Convert.ToInt32(dgvListCustomer.CurrentRow.Cells[9].Value.ToString());
            customer.Id_TypeCustomer = dgvListCustomer.CurrentRow.Cells[10].Value.ToString();

            //customer.Qr_Customer = dgvListCustomer.CurrentRow.Cells[11].Value.ToString();
            showCustomer();
        }

        private void txtIdCustomer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable data = CustomerDAO.Instance.GetCustomerById(txtIdCustomer.Text);
                customer.Id_Customer = data.Rows[0][0].ToString();
                customer.Lname_Customer = data.Rows[0][1].ToString();
                customer.Fname_Customer = data.Rows[0][2].ToString();
                customer.Birthday_Customer = Convert.ToDateTime(data.Rows[0][3]);
                customer.Sex_Customer = data.Rows[0][4].ToString();
                customer.Identitycard_Customer = data.Rows[0][5].ToString();
                customer.Phone_Customer = data.Rows[0][6].ToString();
                customer.Email_Customer = data.Rows[0][7].ToString();
                customer.Address_Customer = data.Rows[0][8].ToString();
                customer.Point_Customer = Convert.ToInt32(data.Rows[0][9]);
                customer.Id_TypeCustomer = data.Rows[0][10].ToString();
                customer.Qr_Customer = data.Rows[0][11].ToString();
                showCustomer();
            }
            catch
            {

            }
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
