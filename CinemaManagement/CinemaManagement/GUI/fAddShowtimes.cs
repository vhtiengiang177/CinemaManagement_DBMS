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

namespace CinemaManagement.GUI
{
    public partial class fAddShowtimes : Form
    {
        public fAddShowtimes()
        {
            InitializeComponent();
            AddShiftInDay();
            AddCategoryMovie();
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int countMovieInDay()
        {

            if (ShowtimesDAO.Intance.countMovieInDay(dtmChooseDay.Value.ToString()).Rows.Count > 0)
                txtCountMovieInDay.Text = ShowtimesDAO.Intance.countMovieInDay(dtmChooseDay.Value.ToString()).Rows[0][0].ToString();
            else
                txtCountMovieInDay.Text = "0";
            return Convert.ToInt32(txtCountMovieInDay.Text.ToString());

        }

        private void AddShiftInDay()
        {
            DataTable dt = new DataTable();
            dt = ShowtimesDAO.Intance.loadShiftShow();
            cboShift.DataSource = dt;
            cboShift.ValueMember = dt.Columns[0].ToString();
            
            

        }

        private void AddCategoryMovie()
        {
            DataTable dt = new DataTable();
            dt = ShowtimesDAO.Intance.loadCategoryMovie();
            cboTypeMovie.DataSource = dt;
            cboTypeMovie.DisplayMember= dt.Columns[1].ToString();
            cboTypeMovie.ValueMember = dt.Columns[0].ToString();



        }

        private void btnCheckDay_Click(object sender, EventArgs e)
        {
            countMovieInDay();
            txtShiftEmpty.Text = (5 - countMovieInDay()).ToString();
           
        }

        private void btnChooseDay_Click(object sender, EventArgs e)
        {
            txtDay.Text = dtmChooseDay.Value.ToString();
        }

        private void btnChooseShift_Click(object sender, EventArgs e)
        {
            txtShift.Text = cboShift.Text.ToString();
        }

        private void btnChooseMovie_Click(object sender, EventArgs e)
        {
            txtMovie.Text = cboMovie.Text.ToString();
        }

        private void btnChoosrRoom_Click(object sender, EventArgs e)
        {
            txtRoom.Text = cboRoom.Text.ToString();

        }

        private void btnCheckShift_Click(object sender, EventArgs e)
        {
            
            
            if (ShowtimesDAO.Intance.countShiftInDay(cboShift.ValueMember.ToString()).Rows.Count > 0)
            {
                int count = Convert.ToInt32(ShowtimesDAO.Intance.countShiftInDay(cboShift.ValueMember.ToString()).Rows[0][0].ToString());
                txtCountShift.Text = (3 - count).ToString();
            }    
                
            else
                txtCountShift.Text = "3";
            
        }

        private void btnCheckCategoryMovie_Click(object sender, EventArgs e)
        {
            if (ShowtimesDAO.Intance.loadMovie(cboTypeMovie.SelectedValue.ToString()).Rows.Count > 0)
            {
                
               
                DataTable dt = new DataTable();
                dt = ShowtimesDAO.Intance.loadMovie(cboTypeMovie.SelectedValue.ToString());
                
                cboMovie.DataSource = dt;
                cboMovie.DisplayMember = dt.Columns[1].ToString();
                cboMovie.ValueMember = dt.Columns[0].ToString();

            }

            else
                MessageBox.Show("Chưa có phim ở thể loại này");
        }

        private void fAddShowtimes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDBMSDataSet1.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.cinemaDBMSDataSet1.Movie);

        }
    }
}
