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
            fillChart();
            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();
            lbmovie.Text = st.Rows.Count.ToString();


            int sum = st.AsEnumerable().Sum(row => row.Field<int>("TongThu"));
            int pro = st.AsEnumerable().Sum(row => row.Field<int>("TongGiam"));
            lbTotalReal.Text = sum.ToString();
            lbTotalPro.Text = pro.ToString();
        }

        public void fillChart()
        {
            DataTable ds = new DataTable();
            DataTable dt = new DataTable();
            ds.Columns.Add("Month",typeof(string));
            ds.Columns.Add("Sum", typeof(int));
            dt = StatisticDAO.Instance.loaddata();
            int i = 1;
            int dem = dt.Rows.Count;
            int j = 0;
            if (dt.Rows.Count > 0)
            {
                while (i < 13)
                {
                    if (dt.Rows[j][0].ToString() == i.ToString() && j<dem)
                    {
                        ds.Rows.Add( dt.Rows[j][0].ToString(), Convert.ToInt32(dt.Rows[j][1].ToString()) );
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
                chart.Titles.Add("Biểu đồ thống kê doanh số theo tháng");
            }
            else
            {
                MessageBox.Show("KHông có số liệu");
            }

        }


        public void loadAll()
        {
            DataTable st = new DataTable();
            st = StatisticDAO.Instance.loadAll();
            dgvTopMovie.DataSource = st;
            

        }

        private void cboTopMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dem = cboTopMovie.SelectedIndex;

                if (dem > 0)
                {
                    DataTable dt = new DataTable();
                    dt = StatisticDAO.Instance.loadInMonth(dem);
                    dgvTopMovie.DataSource = dt;
                }    
                else
                {
                    loadAll();
                }    
               
        }

        private void btnResset_Click(object sender, EventArgs e)
        {
            //StatisticDAO.Instance.deleteData();
            //MessageBox.Show("Đã xóa toàn bộ lịch chiếu và vé trong năm");
        }

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
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string str = now.ToString();
            str=RemoveSpecialCharacters(str);
            export2Excel(dgvTopMovie, @"D:\", "xuatfileExcel "+str);
        }
    }
}
