using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.DAO;

namespace CinemaManagement
{
    public partial class fShifWorkEmployee : Form
    {
        public static int cellClickIndex = 0;
        public static int searchTypeIndex = 0;
      

        MemoryStream ms;
        byte[] arrImage = null;

        public fShifWorkEmployee()
        {
            InitializeComponent();
            loadData();
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
            //cboTypeSearchEmployee.DataSource = EmployeeDAO.Instance.getDataTypeEmployee();
            //cboTypeSearchEmployee.ValueMember = "id_typeemployee";
            //cboTypeSearchEmployee.DisplayMember = "name_typeemployee";
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
            searchEmployee(fShifWorkEmployee.searchTypeIndex);
           
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
            cboSortTypeEmployee.Enabled = false;
            setDataCboSortTypeEmployee();
            
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
            if (dgvListEmployee.Rows[row].Cells[11].Value != DBNull.Value)
            {
                this.picEmployee.Image = (System.Drawing.Image)
             dgvListEmployee.Rows[row].Cells[11].FormattedValue;

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


        void clearValue()
        {
            txtID.Clear();
            txtName.Clear();
        }

        public void searchEmployee(int index)
        {
            switch (index)
            {
                case 0: { dgvListEmployee.DataSource = EmployeeDAO.Instance.search_IDEmployee(txtSearchEmployee.Text.Trim()); break; }
                case 1: { dgvListEmployee.DataSource = EmployeeDAO.Instance.search_PhoneEmployee(txtSearchEmployee.Text.Trim()); break; }
                case 2: { dgvListEmployee.DataSource = EmployeeDAO.Instance.search_NameEmployee(txtSearchEmployee.Text.Trim()); break; }
                case 3: { dgvListEmployee.DataSource = EmployeeDAO.Instance.search_IdentityCardEmployee(txtSearchEmployee.Text.Trim()); break; }
            }
        }

        private void cboTypeSearchEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            fShifWorkEmployee.searchTypeIndex = cboTypeSearchEmployee.SelectedIndex;

        }

        private void btnSearchType_Click(object sender, EventArgs e)
        {
            cboSortTypeEmployee.Enabled = true;
            setDataCboSortTypeEmployee();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            loadData();
            
        }

        public void changeShiftOfMonth(string idShift)
        {
            string id = txtID.Text.Trim();
            
            int month = Int32.Parse(cboMonth.SelectedItem.ToString().Trim());
            int year = Int32.Parse(cboYear.SelectedItem.ToString().Trim());
            if (EmployeeDAO.Instance.createShiftOfMonth(id, month, year, idShift))
                MessageBox.Show("Đã xếp lịch cho nhân viên: " + id);
            else
                MessageBox.Show("Lỗi");
        }

        private void btnChangeMonth_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Trim()!="")
            {
                string idShift = "";
                if (rdoEveningMonth.Checked)
                    idShift = "sw01";
                if (rdoEveningMonth.Checked)
                    idShift = "sw02";
                if (rdoFullMonth.Checked)
                    idShift = "sw03";
                changeShiftOfMonth(idShift);
            }
        }

       

        private void nudWeekSelected_ValueChanged(object sender, EventArgs e)
        {

            int month = Int32.Parse(cboMonth.SelectedItem.ToString().Trim());
            int year = Int32.Parse(cboYear.SelectedItem.ToString().Trim());
            DateTime fisrtDay = ((DateTime)EmployeeDAO.Instance.selectWeekOnMonth(month, year, Int32.Parse(nudWeekSelected.Value.ToString())));
            txtFirstDate.Text =fisrtDay.ToShortDateString();
            txtLastDate.Text = ((DateTime)EmployeeDAO.Instance.selectDateEndWeek(fisrtDay, 6)).ToShortDateString();
        }

        public string setShiftOfMonday()
        {
            string idShift = "";
            if (rdoMorningMonday.Checked)
                idShift = "sw01";
            if (rdoEveningMonday.Checked)
                idShift = "sw02";
            if (rdoFullMonday.Checked)
                idShift = "sw03";
            return idShift;
        }

        public string setShiftOfTus()
        {
            string idShift = "";
            if (rdoMorningTus.Checked)
                idShift = "sw01";
            if (rdoEveningTus.Checked)
                idShift = "sw02";
            if (rdoFullTus.Checked)
                idShift = "sw03";
            return idShift;
        }
        public string setShiftOfWed()
        {
            string idShift = "";
            if (rdoMorningWed.Checked)
                idShift = "sw01";
            if (rdoEveningWed.Checked)
                idShift = "sw02";
            if (rdoFullWed.Checked)
                idShift = "sw03";
            return idShift;
        }
        public string setShiftOfThur()
        {
            string idShift = "";
            if (rdoMorningThur.Checked)
                idShift = "sw01";
            if (rdoEveningThur.Checked)
                idShift = "sw02";
            if (rdoFullThur.Checked)
                idShift = "sw03";
            return idShift;
        }
        public string setShiftOfFri()
        {
            string idShift = "";
            if (rdoMorningFri.Checked)
                idShift = "sw01";
            if (rdoEverningFri.Checked)
                idShift = "sw02";
            if (rdoFullFri.Checked)
                idShift = "sw03";
            return idShift;
        }

        public string setShiftOfSa()
        {
            string idShift = "";
            if (rdoMorningSa.Checked)
                idShift = "sw01";
            if (rdoEveningSa.Checked)
                idShift = "sw02";
            if (rdoFullSa.Checked)
                idShift = "sw03";
            return idShift;
        }
        public string setShiftOfSunDay()
        {
            string idShift = "";
            if (rdoMorningSun.Checked)
                idShift = "sw01";
            if (rdoEveningSun.Checked)
                idShift = "sw02";
            if (rdoFullSun.Checked)
                idShift = "sw03";
            return idShift;
        }
        private void btnChangeWeek_Click(object sender, EventArgs e)
        {
            string idEmployee = txtID.Text.Trim();
           if(idEmployee != "")
            {
                DateTime date = Convert.ToDateTime(txtFirstDate.Text.Trim());
                if (setShiftOfMonday() != "")
                    try
                    {
                        if (EmployeeDAO.Instance.createShitfOnlyOneDay(date, 0, idEmployee, setShiftOfMonday()))
                        { }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Xếp lịch cho thứ 2 không thành công !");
                    }




                if (setShiftOfTus() != "")

                    try
                    {
                        if (EmployeeDAO.Instance.createShitfOnlyOneDay(date, 1, idEmployee, setShiftOfTus()))
                        { }
                    }
                    catch (SqlException ex)
                    {
                        { MessageBox.Show("Xếp lịch cho thứ 3 không thành công !"); }
                    }



                if (setShiftOfWed() != "")
                    try
                    {
                        if (EmployeeDAO.Instance.createShitfOnlyOneDay(date, 2, idEmployee, setShiftOfWed()))
                        { }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Xếp lịch cho thứ 4 không thành công !");
                    }



                if (setShiftOfThur() != "")
                    try
                    {
                        if (EmployeeDAO.Instance.createShitfOnlyOneDay(date, 3, idEmployee, setShiftOfThur()))
                        { }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Xếp lịch cho thứ 5 không thành công !");
                    }



                if (setShiftOfFri() != "")
                    try
                    {
                        if (EmployeeDAO.Instance.createShitfOnlyOneDay(date, 4, idEmployee, setShiftOfFri()))
                        { }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Xếp lịch cho thứ 6 không thành công !");
                    }


                if (setShiftOfSa() != "")
                    try
                    {
                        if (EmployeeDAO.Instance.createShitfOnlyOneDay(date, 5, idEmployee, setShiftOfSa()))
                        { }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Xếp lịch cho thứ 7 không thành công !");
                    }


                if (setShiftOfSunDay() != "")
                    try
                    {
                        if (EmployeeDAO.Instance.createShitfOnlyOneDay(date, 6, idEmployee, setShiftOfSa()))
                        { }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Xếp lịch cho chủ nhật không thành công !");
                    }



            }
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            plFullMonth.Enabled = false;// Không  cho đăng kí theo tháng
            plWeekFull.Enabled = true; 
            flpWeekOne.Enabled = true;
            int month = Int32.Parse(cboMonth.SelectedItem.ToString().Trim());
            int year = Int32.Parse(cboYear.SelectedItem.ToString().Trim());
            DateTime fisrtDay = ((DateTime)EmployeeDAO.Instance.selectWeekOnMonth(month, year,1));
            txtFirstDate.Text = fisrtDay.ToShortDateString();
            txtLastDate.Text = ((DateTime)EmployeeDAO.Instance.selectDateEndWeek(fisrtDay, 6)).ToShortDateString();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            plFullMonth.Enabled = true;
            plWeekFull.Enabled = false; // Không  cho đăng kí theo tuần
            flpWeekOne.Enabled = false; // Không  cho đăng kí theo tuần
        }


        private void btnCreateFullWeek_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(txtFirstDate.Text.Trim());
            String idShift = "";

            if (rdoMorFullWeek.Checked)
                idShift = "sw01";
            if (rdoEvrFullWeek.Checked)
                idShift = "sw02";
            if (rdoFullFullWeek.Checked)
                idShift = "sw03";
            string idEmployee = txtID.Text.Trim();

            if (idEmployee != "" && idShift != "")
            {
                try
                {
                    bool f = EmployeeDAO.Instance.createShitfFullWeek(date, idEmployee, idShift);
                    if(f)
                    {
                        MessageBox.Show("Đã tạo ca làm việc thành công !");
                    }   
                    
                }catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }

            }
            else
            {
                MessageBox.Show("Chưa chọn thông tin người dùng !");
            }
        }
    }
}
