using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.DAO;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace CinemaManagement.GUI
{
    public partial class fStatistic : Form
    {
        public fStatistic()
        {
            InitializeComponent();
            
            load();
            
            lbNotice.Show();
            cboYear.Enabled = false;
            cboCinema.Enabled = false;
            cboTimeStatistic.Enabled = false;
            cboTimeStatistic.ResetText();
            cboYear.ResetText();
            cboCinema.ResetText();

          

        }


        /// <summary>
        /// Load các thông tin thống kê
        /// </summary>
        public void load()
        {

            //load danh sách rạp của hệ thống
            DataTable cm = new DataTable();
            cm = CinemaDAO.Instance.loadCinema();
            cboCinema.DataSource = cm;
            cboCinema.ValueMember = cm.Columns[0].ToString();
            cboCinema.DisplayMember = cm.Columns[1].ToString();

            


            //load thông tin chung của hệ thống
            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();
            lbmovie.Text = StatisticDAO.Instance.countMovie().Rows.Count.ToString();
            int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            lbCinema.Text = cm.Rows.Count.ToString();


            //load danh sách năm của hệ thống
            DataTable dt = new DataTable();
            dt = StatisticDAO.Instance.loadYear();
            cboYear.DataSource = dt;
            cboYear.DisplayMember = dt.Columns[0].ToString();
            cboYear.ValueMember = dt.Columns[0].ToString();

            


        }

        

        //Xuất file Excel

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }

            string fullPath = Path.GetFullPath(duongDan + tenTap + ".xlsx");
            try
            {
                obj.ActiveWorkbook.SaveAs(fullPath);
                obj.ActiveWorkbook.Saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Xóa các kí tự đặc biệt,khoảng trắng
        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        //Lưu file Excel
        private void btnExcel_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string str = now.ToString();
            str = RemoveSpecialCharacters(str);

            export2Excel(dgvStatistic, @"..\..\Excel_Statistic\", "xuatfileExcel_" + str);
            MessageBox.Show("Đã xuất file excel thành công!");
        }


        /// <summary>
        /// Hàm load doanh số của toàn hệ thống trong 1 năm
        /// </summary>
        public void loadAll()
        {
            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();
            dgvStatistic.DataSource = st;


        }

       
        
        

        int dem = 0;
        private void cboTimeStatistic_SelectedIndexChanged(object sender, EventArgs e)
        {
             dem = cboTimeStatistic.SelectedIndex;
            if(dem>0)
            {
                DataTable st = new DataTable();
                st = StatisticDAO.Instance.countTotalOnCinemabyMonthbyYear(cboYear.SelectedValue.ToString(), dem.ToString(), cboCinema.SelectedValue.ToString());
                dgvStatistic.DataSource = st;
                //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
                int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
                int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
                lbTotalReal.Text = sum.ToString();
                lbTotalPro.Text = pro.ToString();
            }
            else
            {
                DataTable st = new DataTable();
                st = StatisticDAO.Instance.loadOnCinemabyYear(cboCinema.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
                dgvStatistic.DataSource = st;
                //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
                int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
                int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
                lbTotalReal.Text = sum.ToString();
                lbTotalPro.Text = pro.ToString();
            }

            
            
        }

        //khi loa loại danh sách thì xóa text cboCinema
        private void cboCinema_TextChanged(object sender, EventArgs e)
        {
            loadAll();
            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();
            //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
            int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            lbTotalReal.Text = sum.ToString(); 
            lbTotalPro.Text =  pro.ToString();

        }

        private void cboCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNotice.Hide();

            if (cboYear.SelectedItem != null && cboTimeStatistic.SelectedItem == null) //doanh số của rạp được chọn qua  năm được chọn
            {
                DataTable st = new DataTable();
                st = StatisticDAO.Instance.loadOnCinemabyYear(cboCinema.SelectedValue.ToString(), cboYear.SelectedValue.ToString());
                dgvStatistic.DataSource = st;

                //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
                int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
                int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
                lbTotalReal.Text = sum.ToString();
                lbTotalPro.Text = pro.ToString();
            }
        }

        /// <summary>
        /// load Thống kê toàn hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCtrl_Click(object sender, EventArgs e)
        {
            lbNotice.Hide();
            cboYear.Enabled = true;
            cboCinema.Enabled = true;
            cboTimeStatistic.Enabled = true;

            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();

            //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
            int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            lbTotalReal.Text = sum.ToString();
            lbTotalPro.Text = pro.ToString();

        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTimeStatistic.ResetText();

            if (cboCinema.Text != "")
            {
                DataTable st = new DataTable();
                st = StatisticDAO.Instance.loadOnCinema(cboCinema.SelectedValue.ToString());
                dgvStatistic.DataSource = st;

                //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
                
                int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
                int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
                lbTotalReal.Text = sum.ToString();
                lbTotalPro.Text = pro.ToString();

            }
            else
            {
                lbNotice.Text = "THỐNG KÊ DOANH SỐ TRONG NĂM " + cboYear.Text + " CỦA HỆ THỐNG";
                lbNotice.Show();

                DataTable st = new DataTable();
                st = StatisticDAO.Instance.countTotalbyYear(cboYear.Text);
                dgvStatistic.DataSource = st;

                //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
                int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
                int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
                lbTotalReal.Text = sum.ToString();
                lbTotalPro.Text = pro.ToString();
            }

        }

        private void btnOrgan_Click(object sender, EventArgs e)
        {
            lbNotice.Show();
            cboYear.Enabled = false;
            cboCinema.Enabled = false;
            cboTimeStatistic.Enabled = false;
            cboTimeStatistic.ResetText();
            cboYear.ResetText();
            cboCinema.ResetText();
        }

        private void cboYear_TextChanged(object sender, EventArgs e)
        {
            //cboTimeStatistic.ResetText();
            
            //if (cboCinema.Text !="")
            //{
            //    DataTable st = new DataTable();
            //    st = StatisticDAO.Instance.loadOnCinema(cboCinema.SelectedValue.ToString());
            //    dgvStatistic.DataSource = st;
            //    //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
            //    int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            //    int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            //    lbTotalReal.Text = sum.ToString();
            //    lbTotalPro.Text = pro.ToString();

            //}
            //else
            //{
            //    lbNotice.Text = "THỐNG KÊ DOANH SỐ TRONG NĂM " + cboYear.Text + " CỦA HỆ THỐNG";
            //    lbNotice.Show();
            //    DataTable st = new DataTable();
            //    st = StatisticDAO.Instance.countTotalbyYear(cboYear.Text);
            //    dgvStatistic.DataSource = st;
            //    //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
            //    int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            //    int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            //    lbTotalReal.Text = sum.ToString();
            //    lbTotalPro.Text = pro.ToString();
            //}
            
        }

        
        





        
    }
}
