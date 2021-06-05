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
            loadAll();
            blockAll();

        }


        /// <summary>
        /// Hàm load doanh số của toàn hệ thống trong 1 năm
        /// </summary>
        public void loadAll()
        {
            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();
            int count = st.Rows.Count;
            dgvStatistic.DataSource = st;


            //load danh sách thể loại phim
            DataTable cmv = new DataTable();
            cmv = CategoryMovieDAO.Instance.loadDataCategoryMovie();
            cboChooseCategory.DataSource = cmv;
            cboChooseCategory.ValueMember = cmv.Columns[0].ToString();
            cboChooseCategory.DisplayMember = cmv.Columns[1].ToString();

            //load thông tin chung của hệ thống
            DataTable st1 = new DataTable();
            st1 = StatisticDAO.Instance.loadAll();
            //lbmovie.Text = StatisticDAO.Instance.countMovie().Rows.Count.ToString();
            int sum = st1.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            int pro = st1.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            //lbCinema.Text = cm.Rows.Count.ToString();
        }
        public void blockAll()
        { 
            cboChooseCategory.Enabled = false;
            cboChooseCategory.ResetText();
            cboChooseMovie.Enabled = false;
            cboChooseMovie.ResetText();
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            btnFilter.Enabled = false;
            rbAll.Enabled = false;
            rbMovie.Enabled = false;
            rbTime.Enabled = false;
            loaddgv();


        }

        public void loaddgv()
        {
            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();
            dgvStatistic.DataSource = st;
            int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            int all = st.AsEnumerable().Sum(row => row.Field<int>("Tong"));
            int count = st.AsEnumerable().Sum(row => row.Field<int>("SoLuong"));
            lbTotalReal.Text = sum.ToString() + " VNĐ";
            lbTotalPro.Text = pro.ToString() + " VNĐ";
            lbTotalAll.Text = all.ToString() + " VNĐ";
            lbCount.Text = count.ToString() + " vé";
        }


        /// <summary>
        /// load Thống kê toàn hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCtrl_Click(object sender, EventArgs e)
        {
            rbTime.Checked = false;
            rbMovie.Checked = false;
            rbAll.Checked = false;

            btnFilter.Enabled = true;
            rbAll.Enabled = true;
            rbMovie.Enabled = true;
            rbTime.Enabled = true;

            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();

            //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
            int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            lbTotalReal.Text = sum.ToString()+" VNĐ";
            lbTotalPro.Text = pro.ToString()+" VNĐ";

        }


        private void btnOrgan_Click(object sender, EventArgs e)
        {
            blockAll();
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }



        private void rbTime_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = true;
            dtpFrom.Value = DateTime.Now.Date;
            dtpTo.Value = DateTime.Now.Date;
            dtpTo.Enabled = true;
            cboChooseCategory.Enabled = false;
            cboChooseMovie.Enabled = false;
            loaddgv();
        }

        private void rbMovie_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = false;
            dtpTo.Enabled = false;
            dtpFrom.Value = DateTime.Now.Date;
            dtpTo.Value = DateTime.Now.Date;
            cboChooseCategory.Enabled = true;

            cboChooseMovie.Enabled = true;
            cboChooseCategory.ResetText();
            cboChooseMovie.ResetText();
            loaddgv();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            dtpFrom.Enabled = true;
            dtpTo.Enabled = true;
            cboChooseCategory.Enabled = true;
            dtpFrom.Value = DateTime.Now.Date;
            dtpTo.Value = DateTime.Now.Date;

            cboChooseMovie.Enabled = true;
            cboChooseCategory.ResetText();
            cboChooseMovie.ResetText();
            loaddgv();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable st = new DataTable();
                string datefrom = dtpFrom.Value.ToString("yyyy/MM/dd");
                string dateto = dtpTo.Value.ToString("yyyy/MM/dd");
                if (rbTime.Checked)
                {

                    
                    st = StatisticDAO.Instance.loadTotalByTime(datefrom, dateto);

                }
                if (rbMovie.Checked)
                {
                    if (cboChooseMovie.Text == "" && cboChooseCategory.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn thể loại phim!");


                    }

                    if (cboChooseMovie.Text == "" && cboChooseCategory.Text != "")
                    {
                        st = StatisticDAO.Instance.loadTotalByCategory(cboChooseCategory.SelectedValue.ToString());

                    }
                    if (cboChooseMovie.Text != "" && cboChooseCategory.Text != "")
                    {
                        st = StatisticDAO.Instance.loadTotalByMovie(cboChooseMovie.SelectedValue.ToString());

                    }
                }

                if (rbAll.Checked)
                {
                    if (cboChooseMovie.Text == "" && cboChooseCategory.Text == "")
                    {
                        MessageBox.Show("Bạn chưa chọn thể loại phim!");


                    }

                    if (cboChooseMovie.Text == "" && cboChooseCategory.Text != "")
                    {
                        st = StatisticDAO.Instance.loadTotalByTimeByCategory(datefrom,dateto,cboChooseCategory.SelectedValue.ToString());

                    }
                    if (cboChooseMovie.Text != "" && cboChooseCategory.Text != "")
                    {
                        st = StatisticDAO.Instance.loadTotalByTimeByMovie(datefrom,dateto,cboChooseMovie.SelectedValue.ToString());

                    }
                }


                dgvStatistic.DataSource = st;
                //load thông tin tổng doanh só thực và tổng giảm khuyến mãi
                int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
                int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
                int all = st.AsEnumerable().Sum(row => row.Field<int>("Tong"));
                int count = st.AsEnumerable().Sum(row => row.Field<int>("SoLuong"));
                lbTotalReal.Text = sum.ToString() + " VNĐ";
                lbTotalPro.Text = pro.ToString() + " VNĐ";
                lbTotalAll.Text = all.ToString() + " VNĐ";
                lbCount.Text = count.ToString() + " vé";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu tìm kiếm",ex.Message);
                blockAll();
            }
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
            try
            {
                DateTime now = DateTime.Now;
                string str = now.ToString();
                str = RemoveSpecialCharacters(str);

                export2Excel(dgvStatistic, @"D:\Excel_Statistic\", "xuatfileExcel_" + str);
                MessageBox.Show("Đã xuất file excel thành công!");
            }
            catch
            {
                MessageBox.Show("Không xuất file excel được!");
            }
            
           
        }

        private void cboChooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load  phim theo danh mục
            if (ShowtimesDAO.Instance.loadMovie(cboChooseCategory.SelectedValue.ToString()).Rows.Count > 0)
            {

                DataTable dt1 = new DataTable();
                dt1 = ShowtimesDAO.Instance.loadMovie(cboChooseCategory.SelectedValue.ToString());

                cboChooseMovie.DataSource = dt1;
                cboChooseMovie.DisplayMember = dt1.Columns[1].ToString();
                cboChooseMovie.ValueMember = dt1.Columns[0].ToString();

            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date>dtpTo.Value.Date )
            {
                MessageBox.Show("Vui lòng chọn thời gian bắt đầu nhỏ hơn hoặc bằng thời gian kết thúc ");
                dtpFrom.Value = DateTime.Now;
            }
            
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("Vui lòng chọn thời gian kết thúc lớn hơn hoặc bằng thời gian bắt đầu ");
                dtpTo.Value = DateTime.Now;
            }
            //if (dtpTo.Value.Date > DateTime.Now.Date)
            //{
            //    MessageBox.Show("Vui lòng chọn thời gian kết thúc nhỏ hơn hoặc bằng thời gian hiện tại");
            //    dtpTo.Value = DateTime.Now;
            //}
        }
    }
}
