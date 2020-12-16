using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.DAO;
//using Microsoft.Office.Interop.Excel;
//using app = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace CinemaManagement.GUI
{
    public partial class fStatistic : Form
    {
        public fStatistic()
        {
            InitializeComponent();
            fillChartAll();
            load();
            cboCinema.SelectedItem = null;
        }


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
            lbTotalReal.Text = sum.ToString();
            lbTotalPro.Text = pro.ToString();
            lbCinema.Text = cm.Rows.Count.ToString();
  

        }

        /// <summary>
        /// Đổ dữ liệu vào Chart
        /// </summary>
        public void fillChartAll()
        {
            //Vì các tháng doanh số =0 hàm lấy dữ liệu không in ra tháng đó nên làm giám tiếp 1 Table đủ 12 tháng
            //Nếu tháng nào doành số >0 thì lấy dưới csdl, còn không có doanh số thì mặc định =0
            DataTable ds = new DataTable();
            ds.Columns.Add("Month", typeof(string));
            ds.Columns.Add("Sum", typeof(int));

            DataTable dt = new DataTable();
            dt = StatisticDAO.Instance.loaddata();
            int i = 1;
            int dem = dt.Rows.Count;
           
            int j = 0;
            if (dt.Rows.Count > 0)
            {
                while (i < 13)
                {
                    if (dt.Rows[j][0].ToString() == i.ToString() && j < dem)
                    {
                        ds.Rows.Add(dt.Rows[j][0].ToString(), Convert.ToInt32(dt.Rows[j][1].ToString()));
                        i++;
                        j++;
                    }
                    else
                    {
                        ds.Rows.Add(i, 0);
                        i++;
                    }
                }


            }
            else
            {
                MessageBox.Show("KHông có số liệu");
            }

            chart.DataSource = ds;
            if (ds.Rows.Count > 0)
            {

                chart.Series["Sum"].XValueMember = ("Month");

                chart.Series["Sum"].YValueMembers = "Sum";
                chart.Titles.Add("Biểu đồ thống kê doanh số theo các tháng của toàn hệ thống");
            }
            else
            {
                MessageBox.Show("KHông có số liệu");
            }

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

        private void btnResset_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("Khi reset data toàn bộ dữ liệu của bạn sẽ mất, chắc chắn rằng bạn đã Xuất File Excel?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel)
            {
                
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                StatisticDAO.Instance.deleteTicket();
                StatisticDAO.Instance.deleteShowtimes();
                MessageBox.Show("Đã xóa toàn bộ lịch chiếu và vé trong năm");
            }
            
        }

        //Xuất file Excel

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            //app obj = new app();
            //obj.Application.Workbooks.Add(Type.Missing);
            //obj.Columns.ColumnWidth = 25;
            //for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            //for (int i = 0; i < g.Rows.Count; i++)
            //{
            //    for (int j = 0; j < g.Columns.Count; j++)
            //    {
            //        if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
            //    }
            //}
            //obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            //obj.ActiveWorkbook.Saved = true;
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
            export2Excel(dgvStatistic, @"D:\", "xuatfileExcel " + str);
        }


        int dem = 0;
        private void cboTimeStatistic_SelectedIndexChanged(object sender, EventArgs e)
        {
             dem = cboTimeStatistic.SelectedIndex;

            if (cboCinema.SelectedItem == null && dem>0)
            {
                DataTable dt = new DataTable();
                dt = StatisticDAO.Instance.loadInMonth(dem);
                dgvStatistic.DataSource = dt;

            }
            else if (cboCinema.SelectedItem == null && dem == 0)
            {
                loadAll();
            }
            else if (cboCinema.SelectedItem != null && dem == 0)
            {

                DataTable dt = new DataTable();
                dt = StatisticDAO.Instance.loadOnCinema(cboCinema.SelectedValue.ToString());
                dgvStatistic.DataSource = dt;

                
            }
            else if (cboCinema.SelectedItem != null && dem > 0)
            {
                DataTable dt = new DataTable();
                dt = StatisticDAO.Instance.loadOnCinemaInMonth(dem, cboCinema.SelectedValue.ToString());
                dgvStatistic.DataSource = dt;
            }
            
        }

        private void cboCinema_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        //khi loa loại danh sách thì xóa text cboCinema
        private void cboCinema_TextChanged(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
