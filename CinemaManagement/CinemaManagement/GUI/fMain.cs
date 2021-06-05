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
        public static string idCinemaCurrent = "";
        public static int typeEmp;
        public fMain()
        {
            InitializeComponent();
            openAchildForm(new fShowMovie_Order());
           // WindowState = FormWindowState.Maximized;
            this.CenterToScreen();
        }

        public fMain(int type, string idEmp, string username, string pass)
        {
            InitializeComponent();

            fMain.idEmployeeMain = idEmp;
            fMain.userNameEmployeeMain = username;
            fMain.passEmployeeMain = pass;
            fMain.typeEmp = type;

            if(type ==  3)
                fMain.idCinemaCurrent =(string)EmployeeDAO.Instance.getIdCinema(idEmp);
            //MessageBox.Show(fMain.idCinemaCurrent);

            DataTable dtEmp = EmployeeDAO.Instance.search_IDEmployee(fMain.idEmployeeMain);
            lbIdEmployeeMain.Text = dtEmp.Rows[0][0].ToString();
            lbNameEmployeeMain.Text = dtEmp.Rows[0][1].ToString();

            if (dtEmp.Rows[0][11] != DBNull.Value)
                picEmployeeMain.Image =BSImage.convertToImage((byte[])dtEmp.Rows[0][11]);
            else
                picEmployeeMain.Image = picEmployeeMain.ErrorImage;
            trgCinemaManager.Visible = false;
            trgEmpManager.Visible = true;
            trpPromotionManager.Visible = true;
            trpSatis.Visible = true;
            trgShiftManager.Visible = false;
            openAchildForm(new fShowMovie_Order(typeEmp, idEmployeeMain));
        }

        private void lbChangeAccount_Click(object sender, EventArgs e)
        {
            fChangeAccount f = new fChangeAccount(fMain.userNameEmployeeMain, fMain.passEmployeeMain);
            f.ShowDialog();
            this.Show();
        }

        private void trpEmployeeManager_Click(object sender, EventArgs e)
        {
            
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
            if(typeEmp != 2)
                 openAchildForm(new fCustomer(typeEmp));
        }

        private void trpHome_Order_Click(object sender, EventArgs e)
        {
            openAchildForm(new fShowMovie_Order(typeEmp, idEmployeeMain));         
        }

        private void trpPromotionManager_Click(object sender, EventArgs e)
        {
            if(typeEmp == 4)
                openAchildForm(new fPromotion());
        }

        private void trpFilmManager_Click(object sender, EventArgs e)
        {
            if (typeEmp != 1)
                openAchildForm(new fMovie());
           
        }

        private void trpFilmCategoryManager_Click(object sender, EventArgs e)
        {
            if (typeEmp != 1)
                openAchildForm(new fCategoryMovie());
        }

        private void trpShowTimeManager_Click(object sender, EventArgs e)
        {
            if (typeEmp != 1)
                openAchildForm(new fShowTime());
        }

        private void trpSatis_Click(object sender, EventArgs e)
        {
            if(typeEmp == 4)
                openAchildForm(new fStatistic());
        }

        private void trgCinemaManager_Click(object sender, EventArgs e)
        {
            if (typeEmp == 4) // Chỉ có addmin quản lý
                openAchildForm(new fCinema());
        }   

        private void trgEmpManager_Click(object sender, EventArgs e)
        {
            if (typeEmp == 4 || typeEmp == 3) //  tùy theo nếu là admin thì quản lý tất cả rạp, còn người quản lý rạp quản lý nhân viên của rạp mình
                openAchildForm(new fEmployee(typeEmp, idCinemaCurrent));
        }

        private void trgShiftManager_Click(object sender, EventArgs e)
        {
            if (typeEmp != 1 && typeEmp != 2)
                openAchildForm(new fShifWorkEmployee());
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbLogout_MouseHover(object sender, EventArgs e)
        {
            //object underline = lbLogout.Text.FontStyle.Underline;
            lbLogout.Font = new Font(lbLogout.Font, FontStyle.Underline);
        }

        private void lbLogout_MouseLeave(object sender, EventArgs e)
        {
            lbLogout.Font = new Font(lbLogout.Font, FontStyle.Regular);
        }
    }
}
