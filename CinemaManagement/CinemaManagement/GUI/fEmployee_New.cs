using CinemaManagement.DAO;
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
    public partial class fEmployee_New : Form
    {
        private static int typeEmployee;
        private static string idCinemaCurrent = "";
        private MemoryStream ms;
        private byte[] arrImage = null;
        OpenFileDialog openIMG = new OpenFileDialog();

        public fEmployee_New()
        {
            InitializeComponent();
        }

        public fEmployee_New(int type, string idCinema)
        {
            InitializeComponent();
            typeEmployee = type;
            idCinemaCurrent = idCinema;
            loadData();
        }

        // Đưa dữ liệu lên form
        public void loadData()
        {
            // Gán hình về mặc định
            picEmployee.Image = picEmployee.InitialImage;
            imageToByteArray(picEmployee.Image);

            // Combobox chức vụ
            cboTypeEmployee.DataSource = EmployeeDAO.Instance.getDataTypeEmployee();
            cboTypeEmployee.ValueMember = "id_typeemployee";
            cboTypeEmployee.DisplayMember = "name_typeemployee";

            // Combobox lọc danh sách dgv theo chức vụ 
            DataTable data = EmployeeDAO.Instance.getDataTypeEmployee();
            if(data.Rows.Count > 0)
            {
                DataRow dataRow = data.NewRow();
                dataRow["id_typeemployee"] = "--0--";
                dataRow["name_typeemployee"] = "--Chọn xem danh sách theo chức vụ--";
                data.Rows.InsertAt(dataRow, 0);
                cboSortTypeEmployee.DataSource = data;
                cboSortTypeEmployee.ValueMember = "id_typeemployee";
                cboSortTypeEmployee.DisplayMember = "name_typeemployee";
            }

            // Combobox rạp & dgv
            cmbCinema.DataSource = EmployeeDAO.Instance.getDataCinema();
            dgvListEmployee.DataSource = EmployeeDAO.Instance.loadData();

            this.lbID.Text = "";
            this.picEmployee.Image = this.picEmployee.InitialImage;
            this.txtNameEmployee.Text = "";
            this.txtIndentity.Text = "";
            this.dpkBirthDateEmp.Value = DateTime.Now;
            this.rdoMale.Checked = true;
            this.txtPhoneEmployee.Text = "";
            this.txtEmailEmployee.Text = "";
            this.txtAddressEmployee.Text = "";

            cboTypeSearchEmployee.SelectedIndex = 1;
            numSalary.Value = 0;
            cmbCinema.ValueMember = "id_cinema";
            cmbCinema.DisplayMember = "name_cinema";

            lbID.Text = EmployeeDAO.Instance.createNewIDEmployee().ToString();

            pnState.Visible = false;
            btnUpdateEmployee.Enabled = false;
            btnInsertEmployee.Enabled = true;
        }

        // Reload lại dữ liệu
        private void picReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        #region Convert Image
        /// <summary>
        /// Chuyển image sang array byte
        /// </summary>
        /// <param name="imageIn"></param>
        public void imageToByteArray(System.Drawing.Image imageIn)
        {
            ms = new MemoryStream();
            imageIn.Save(ms, picEmployee.Image.RawFormat);
            arrImage = ms.GetBuffer();
            ms.Close();
        }

        /// <summary>
        /// Chuyển array byte sang image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            ms.Close();
            return returnImage;
        }
        #endregion

        #region Search
        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEmployee.Text == "")
            {
               dgvListEmployee.DataSource = EmployeeDAO.Instance.loadData();
            }
            else if (cboTypeSearchEmployee.SelectedIndex == 0) // ID
            {
                dgvListEmployee.DataSource = EmployeeDAO.Instance.search_IDEmployee(txtSearchEmployee.Text.Trim());
            }
            else if (cboTypeSearchEmployee.SelectedIndex == 1) // Tên NV
            {
                dgvListEmployee.DataSource = EmployeeDAO.Instance.search_NameEmployee(txtSearchEmployee.Text.Trim());
            }
            else if (cboTypeSearchEmployee.SelectedIndex == 2) // Số điện thoại
            {
                dgvListEmployee.DataSource = EmployeeDAO.Instance.search_PhoneEmployee(txtSearchEmployee.Text.Trim());
            }
            else if (cboTypeSearchEmployee.SelectedIndex == 3) // CMND
            {
                dgvListEmployee.DataSource = EmployeeDAO.Instance.search_IdentityCardEmployee(txtSearchEmployee.Text.Trim());
            }    
        }

        private void cboSortTypeEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSortTypeEmployee.SelectedValue.ToString() != "--0--")
            {
                dgvListEmployee.DataSource = EmployeeDAO.Instance.search_TypeEmployee(cboSortTypeEmployee.SelectedValue.ToString().Trim());
            }
            else
            {
                dgvListEmployee.DataSource = EmployeeDAO.Instance.loadData();
            }
        }

        #endregion

        private void dgvListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtGetEmployee = new DataTable();
            dtGetEmployee = EmployeeDAO.Instance.getAnEmployee(dgvListEmployee.CurrentRow.Cells[0].Value.ToString());
            this.lbID.Text = dtGetEmployee.Rows[0][0].ToString();
            this.txtNameEmployee.Text = dtGetEmployee.Rows[0][1].ToString();
            this.dpkBirthDateEmp.Value = Convert.ToDateTime(dtGetEmployee.Rows[0][2].ToString());
            string gender = dtGetEmployee.Rows[0][3].ToString();
            if (gender == "Nam")
                rdoMale.Checked = true;
            else rdoFemale.Checked = true;
            this.txtIndentity.Text = dtGetEmployee.Rows[0][4].ToString();
            this.txtPhoneEmployee.Text = dtGetEmployee.Rows[0][5].ToString();
            this.txtEmailEmployee.Text = dtGetEmployee.Rows[0][6].ToString();
            this.txtAddressEmployee.Text = dtGetEmployee.Rows[0][7].ToString();
            this.numSalary.Value = Convert.ToDecimal(dtGetEmployee.Rows[0][8].ToString());
            this.cboTypeEmployee.SelectedValue = dtGetEmployee.Rows[0][9].ToString();
            if (dtGetEmployee.Rows[0][10].ToString() == "True")
            {
                rdoActive.Checked = true;
            }
            else rdoInactive.Checked = true;
            // Kiểm tra ảnh có null không. 
            if (dtGetEmployee.Rows[0][11] is null || dtGetEmployee.Rows[0][11] == DBNull.Value)
            {
                picEmployee.Image = picEmployee.InitialImage;
                imageToByteArray(picEmployee.Image);
            }
            else
            {
                arrImage = (byte[])dtGetEmployee.Rows[0][11];
                this.picEmployee.Image = byteArrayToImage(arrImage);
            }
            this.cmbCinema.SelectedValue = dtGetEmployee.Rows[0][12].ToString();
            if (lbID.Text == "em004")
            {
                pnState.Visible = false;
                cboTypeEmployee.Visible = false;
            }
            else
            {
                pnState.Visible = true;
                cboTypeEmployee.Visible = true;
            }

            btnUpdateEmployee.Enabled = true;
            btnInsertEmployee.Enabled = false;
        }

        // Thêm hình
        private void picEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.openIMG.FileName = string.Empty;
            this.openIMG.Filter = "JPEG Image|*.jpeg|JPG Image|*.jpg|PNG Image|*.png|All Files|*.*";
            this.openIMG.FilterIndex = 1;
            this.openIMG.Multiselect = false;
            if (this.openIMG.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openIMG.FileName) == ".jpeg" || Path.GetExtension(openIMG.FileName) == ".jpg" || Path.GetExtension(openIMG.FileName) == ".png")
                {
                    this.picEmployee.Image = new Bitmap(openIMG.FileName);
                    imageToByteArray(this.picEmployee.Image); // Chuyển hình sang mảng byte
                }
                else
                {
                    MessageBox.Show("Sai định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            picEmployee.Image = picEmployee.InitialImage;
            imageToByteArray(this.picEmployee.Image);
        }

        // kiểm tra đầu vào
        public bool inputValidate()
        {
            int errorCount = 0;
            if (txtNameEmployee.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtNameEmployee, "Không để trống trường này.");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtNameEmployee, null);
            }
            if (txtIndentity.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtIndentity, "Không để trống trường này.");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtIndentity, null);
            }
            if (txtPhoneEmployee.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtPhoneEmployee, "Không để trống trường này.");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtPhoneEmployee, null);
            }
            if (txtEmailEmployee.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtEmailEmployee, "Không để trống trường này.");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtEmailEmployee, null);
            }
            if (errorCount == 0)
            {
                return true; // Không có lỗi nào nữa
            }
            else return false;
        }

        // Kiểm tra thêm nv
        public bool checkInsert()
        {
            int errorCount = 0;
            if (EmployeeDAO.Instance.search_IdentityCardEmployee(txtIndentity.Text).Rows.Count != 0)
            {
                errorProvider.SetError(this.txtIndentity, "CMND đã tồn tại!");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtIndentity, null);
            }
            if (EmployeeDAO.Instance.search_PhoneEmployee(txtPhoneEmployee.Text).Rows.Count != 0)
            {
                errorProvider.SetError(this.txtPhoneEmployee, "SĐT đã tồn tại!");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtPhoneEmployee, null);
            }
            if (EmployeeDAO.Instance.search_EmailEmployee(txtEmailEmployee.Text).Rows.Count != 0)
            {
                errorProvider.SetError(this.txtEmailEmployee, "Email đã tồn tại!");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtEmailEmployee, null);
            }



            if (errorCount == 0)
            {
                return true; // Không có lỗi nào nữa
            }
            else return false;

        }


        #region Insert
        private void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            if (inputValidate())
            {
                if (checkInsert())
                {
                    string gender = "";
                    if (rdoMale.Checked)
                        gender = "Nam";
                    else gender = "Nữ";
                    // Mới thêm vào thì auto trạng thái là 1
                    Double salary = 0;
                    salary = Convert.ToDouble(this.numSalary.Value);
                    Employee employee = new Employee(this.lbID.Text.ToString(),
                        this.txtNameEmployee.Text.ToString(),
                        Convert.ToDateTime(this.dpkBirthDateEmp.Value),
                        gender,
                        this.txtIndentity.Text.ToString(),
                        this.txtPhoneEmployee.Text.ToString(),
                        this.txtEmailEmployee.Text.ToString(),
                        this.txtAddressEmployee.Text.ToString(),
                        salary,
                        this.cboTypeEmployee.SelectedValue.ToString(),
                        this.cmbCinema.SelectedValue.ToString(),
                        arrImage,
                        this.lbID.Text.ToString(),
                        1
                        );
                    try
                    {
                        EmployeeDAO.Instance.insertEmployee(employee);
                        loadData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Thêm không thành công! \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region Update
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (inputValidate())
            {
                string gender = "";
                if (rdoMale.Checked)
                    gender = "Nam";
                else gender = "Nữ";
                byte state = 0;
                if (rdoActive.Checked)
                    state = 1;
                else state = 0;
                Double salary = 0;
                salary = Convert.ToDouble(this.numSalary.Value);
                string typeEmployee = "";
                if(lbID.Text == "em004")
                {
                    typeEmployee = "tyem04";
                }
                else
                {
                    typeEmployee = this.cboTypeEmployee.SelectedValue.ToString();
                }
                Employee employee = new Employee(this.lbID.Text.ToString(),
                    this.txtNameEmployee.Text.ToString(),
                    Convert.ToDateTime(this.dpkBirthDateEmp.Value),
                    gender,
                    this.txtIndentity.Text.ToString(),
                    this.txtPhoneEmployee.Text.ToString(),
                    this.txtEmailEmployee.Text.ToString(),
                    this.txtAddressEmployee.Text.ToString(),
                    salary,
                    typeEmployee,
                    this.cmbCinema.SelectedValue.ToString(),
                    arrImage,
                    this.lbID.Text.ToString(),
                    state
                    );
                if(state == 0)
                {
                    DialogResult result;
                    result = MessageBox.Show("Bạn có chắc chắn khóa tài khoản " + this.lbID.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if(result == DialogResult.OK)
                    {
                        try
                        {
                            EmployeeDAO.Instance.editInfoEmployee(employee);
                            loadData();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Cập nhật không thành công! \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }  
                else
                {
                    try
                    {
                        EmployeeDAO.Instance.editInfoEmployee(employee);
                        loadData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Cập nhật không thành công! \n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        #endregion



    }
}