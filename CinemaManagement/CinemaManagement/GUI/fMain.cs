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
using CinemaManagement.BLL;
namespace CinemaManagement.GUI
{
    public partial class fMain : Form
    {
        public static string idEmployeeMain;
        public static string userNameEmployeeMain;
        public static string passEmployeeMain;
        public fMain()
        {
            InitializeComponent();
        }

        public fMain(string idEmp, string username, string pass)
        {
            InitializeComponent();
            fMain.idEmployeeMain = idEmp;
            fMain.userNameEmployeeMain = username;
            fMain.passEmployeeMain = pass;
            DataTable dtEmp = EmployeeDAO.Instance.search_IDEmployee(fMain.idEmployeeMain);
            lbIdEmployeeMain.Text = dtEmp.Rows[0][0].ToString();
            lbNameEmployeeMain.Text = dtEmp.Rows[0][1].ToString();
            if (dtEmp.Rows[0][11] != DBNull.Value)
                picEmployeeMain.Image =BSImage.convertToImage((byte[])dtEmp.Rows[0][11]);
            else
                picEmployeeMain.Image = picEmployeeMain.ErrorImage;

        }

        private void lbChangeAccount_Click(object sender, EventArgs e)
        {
            fChangeAccount f = new fChangeAccount(fMain.userNameEmployeeMain, fMain.passEmployeeMain);
            f.ShowDialog();
            this.Show();
        }
    }
}
