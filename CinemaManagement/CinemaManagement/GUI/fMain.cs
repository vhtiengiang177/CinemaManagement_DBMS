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
        public static int typeEmp;
        public fMain()
        {
            InitializeComponent();
            openAchildForm(new fShowMovie_Order());
        }

        public fMain(int type, string idEmp, string username, string pass)
        {
            InitializeComponent();
            fMain.idEmployeeMain = idEmp;
            fMain.userNameEmployeeMain = username;
            fMain.passEmployeeMain = pass;
            fMain.typeEmp = type;

            DataTable dtEmp = EmployeeDAO.Instance.search_IDEmployee(fMain.idEmployeeMain);
            lbIdEmployeeMain.Text = dtEmp.Rows[0][0].ToString();
            lbNameEmployeeMain.Text = dtEmp.Rows[0][1].ToString();

            if (dtEmp.Rows[0][11] != DBNull.Value)
                picEmployeeMain.Image =BSImage.convertToImage((byte[])dtEmp.Rows[0][11]);
            else
                picEmployeeMain.Image = picEmployeeMain.ErrorImage;

            openAchildForm(new fShowMovie_Order());
        }

        private void lbChangeAccount_Click(object sender, EventArgs e)
        {
            fChangeAccount f = new fChangeAccount(fMain.userNameEmployeeMain, fMain.passEmployeeMain);
            f.ShowDialog();
            this.Show();
        }

        private void trpEmployeeManager_Click(object sender, EventArgs e)
        {
            openAchildForm(new fEmployee());
        }

        private Form fActive = null;
        private void openAchildForm(Form childForm)
        {
            if (fActive != null)
                fActive.Close();
            fActive = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            plOpenChildForm.Controls.Add(childForm);
            plOpenChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void trpCustomerManager_Click(object sender, EventArgs e)
        {
            openAchildForm(new fCustomer());
        }

        private void trpHome_Order_Click(object sender, EventArgs e)
        {
            openAchildForm(new fShowMovie_Order(typeEmp, idEmployeeMain));
        }

        private void trpPromotionManager_Click(object sender, EventArgs e)
        {
            openAchildForm(new fPromotion());
        }

        private void trpFilmManager_Click(object sender, EventArgs e)
        {
            openAchildForm(new fMovie());
        }

        private void trpFilmCategoryManager_Click(object sender, EventArgs e)
        {
            openAchildForm(new fCategoryMovie());
        }

        private void trpShowTimeManager_Click(object sender, EventArgs e)
        {
            openAchildForm(new fShowTime());
        }

        private void trpSatis_Click(object sender, EventArgs e)
        {
            openAchildForm(new fStatistic());
        }
    }
}
