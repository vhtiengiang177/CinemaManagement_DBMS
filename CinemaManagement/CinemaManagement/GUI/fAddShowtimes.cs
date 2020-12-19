
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            addShiftInDay();
            addCategoryMovie();
            
            reset();
            chooseCinema();
            //cboCinema.SelectedItem = null;
            //cboTypeMovie.SelectedItem = null;




        }

        public void chooseCinema()
        {
            DataTable cm = new DataTable();
            cm = CinemaDAO.Instance.loadCinema();
            cboCinema.DataSource = cm;
            cboCinema.ValueMember = cm.Columns[0].ToString();
            cboCinema.DisplayMember = cm.Columns[1].ToString();
        }

        /// <summary>
        /// Hàm xử lí khi click icon close thì đóng form
        /// </summary>
        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
            fShowTime frm = new fShowTime();
            
        }

        private void reset()
        {
            txtMovie.ResetText();
            txtRoom.ResetText();
            txtShift.ResetText();
           
            txtCountMovieInDay.ResetText();
            txtCountRoom.ResetText();
            txtCountShift.ResetText();
            cboMovie.ResetText();
            cboRoom.ResetText();
            cboShift.ResetText();
            txtShiftEmpty.ResetText();
            btnChooseDay.Hide();
            btnChooseShift.Hide();
            btnChoosrRoom.Hide();
            btnChooseMovie.Hide();
        }

        #region CHỌN NGÀY CHIẾU

        private void cboCinema_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = RoomDAO.Instance.loadRoomOnCinema(cboCinema.SelectedValue.ToString());
            cboRoom.DataSource = dt;
            cboRoom.DisplayMember = dt.Columns[1].ToString();
            cboRoom.ValueMember = dt.Columns[0].ToString();

            txtCountMovieInDay.ResetText();
            txtShiftEmpty.ResetText();


            //if (ShowtimesDAO.Instance.countShiftInDay(cboShift.SelectedValue.ToString(), dtmChooseDay.Value.ToString(), cboCinema.SelectedValue.ToString()).Rows.Count > 0)
            //{
            //    int count = Convert.ToInt32(ShowtimesDAO.Instance.countShiftInDay(cboShift.SelectedValue.ToString(), dtmChooseDay.Value.ToString(), cboCinema.SelectedValue.ToString()).Rows[0][0].ToString());
            //    if (count < 3)
            //        txtCountShift.Text = (3 - count).ToString();
            //    else
            //        txtCountShift.Text = "0";
            //}

            //else
            //    txtCountShift.Text = "3";
        }

        /// <summary>
        /// Hàm đếm số lịch chiếu đã được xếp trong ngày đó 
        /// </summary>
        /// <returns></returns>
        private int countMovieInDay()
        {
            

            if (ShowtimesDAO.Instance.countMovieInDay(dtmChooseDay.Value.ToString(), cboCinema.SelectedValue.ToString()).Rows.Count > 0)
                txtCountMovieInDay.Text = ShowtimesDAO.Instance.countMovieInDay(dtmChooseDay.Value.ToString(),cboCinema.SelectedValue.ToString()).Rows[0][0].ToString();
            else
                txtCountMovieInDay.Text = "0";
            return Convert.ToInt32(txtCountMovieInDay.Text.ToString());

        }

        /// <summary>
        /// Hàm xử lí sự kiện khi chọn Ngày được chọn xếp còn bao nhiêu lượt (ví dụ tối đa 5 lượt/ngày)
        /// </summary>
        private void dtmChooseDay_ValueChanged(object sender, EventArgs e)
        {
            countMovieInDay();
            txtShiftEmpty.Text = (6 - countMovieInDay()).ToString();
            btnChooseDay.Show();
        }





        /// <summary>
        /// Khi Nhấn CHỌN thì thông tin về ngày chiếu được đưa vào txtDay ở bảng hiển thị thông tin
        /// </summary>
        bool flagDay = false;
        private void btnChooseDay_Click(object sender, EventArgs e)
        {
            flagDay = true;
            if (txtShiftEmpty.Text == "0")
                MessageBox.Show("Đã quá lượt thêm lịch trong ngày");
            else
                dtmDay.Value = dtmChooseDay.Value;
        }



        #endregion

        #region CHỌN CA CHIẾU

        /// <summary>
        /// Hàm load dữ liệu Ca chiếu vào cbo Ca chiếu
        /// </summary>
        private void addShiftInDay()
        {
            
            DataTable dt = new DataTable();
            //dt = ShowtimesDAO.Instance.loadShiftShow();
            dt.Columns.Add("Mã ca chiếu",typeof(string));
            dt.Columns.Add("Tên ca chiếu", typeof(string));
            dt.Rows.Add("ss01", "9am-11am");
            dt.Rows.Add("ss02", "11am-1pm");
            dt.Rows.Add("ss03", "1pm-3pm");
            

            cboShift.DataSource = dt;
            cboShift.ValueMember = dt.Columns[0].ToString();
            cboShift.DisplayMember = dt.Columns[1].ToString();
        }

        /// <summary>
        /// Khi thay đổi ca chiếu hiển thị Số lần còn được chọn ca đó trong ngày
        /// </summary>
        private void cboShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseCinema();
            addShiftInDay();
            btnChooseShift.Show();
            //if (ShowtimesDAO.Instance.countShiftInDay(cboShift.SelectedValue.ToString(), dtmChooseDay.Value.ToString(), cboCinema.SelectedValue.ToString()).Rows.Count > 0)
            //{
            //    int count = Convert.ToInt32(ShowtimesDAO.Instance.countShiftInDay(cboShift.SelectedValue.ToString(), dtmChooseDay.Value.ToString(), cboCinema.SelectedValue.ToString()).Rows[0][0].ToString());
            //    if (count < 3)
            //        txtCountShift.Text = (3 - count).ToString();
            //    else
            //        txtCountShift.Text = "0";
            //}

            //else
            //    txtCountShift.Text = "3";
        }


        /// <summary>
        /// Khi Nhấn CHỌN thì thông tin về ca chiếu được đưa vào txtShift ở bảng hiển thị thông tin
        /// </summary>

        private void btnChooseShift_Click(object sender, EventArgs e)
        {
            if (txtCountShift.Text == "0")
                MessageBox.Show("Đã hết lượt chọn ca này trong ngày");
            else
                txtShift.Text = cboShift.Text.ToString();
        }



        #endregion

        #region CHỌN PHÒNG CHIẾU

        /// <summary>
        /// Đưa dữ liệu Phòng chiếu vào cbo
        /// </summary>

        private void addRoom()
        {
            

        }

        /// <summary>
        /// khi chọn phòng thì hiện thông tin  phòng đó còn bao nhiêu lượt chọn trong ngày
        /// </summary>

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChoosrRoom.Show();
            //DataTable dt = new DataTable();
            //dt = RoomDAO.Instance.countRoomInDay(dtmChooseDay.Value.ToString(), cboRoom.SelectedValue.ToString(), cboShift.SelectedValue.ToString());

            //if (dt.Rows.Count > 0)
            //{
            //    int num = 3 - Convert.ToInt32(dt.Rows[0][0].ToString());
            //    if (num < 3)
            //        txtCountRoom.Text = num.ToString();
            //    else
            //        txtCountRoom.Text = "0";
            //}

            //else
            //    txtCountRoom.Text = "3";

            //DataTable dts = new DataTable();
            //dts = ShowtimesDAO.Instance.checkMovie(dtmChooseDay.Value.ToString(), cboShift.SelectedValue.ToString(), cboRoom.SelectedValue.ToString());
            //if (dts.Rows.Count > 0)
            //    MessageBox.Show("Phòng này đã có lịch vào khung giờ bạn chọn! Vui lòng thay đổi phòng!");
            ////txtCountMovie.Text = dts.Rows[0][0].ToString();
            ////else txtCountMovie.Text = "0";

        }


        /// <summary>
        /// Khi Nhấn CHỌN thì thông tin về phòng chiếu được đưa vào txtRoom ở bảng hiển thị thông tin
        /// </summary>

        private void btnChoosrRoom_Click(object sender, EventArgs e)
        {
            if (txtCountRoom.Text == "0")
                MessageBox.Show("Đã hết lượt chọn phòng chiếu này trong ngày");
            else
                txtRoom.Text = cboRoom.Text.ToString();

            

        }

        #endregion

        #region CHỌN PHIM CHIẾU

        /// <summary>
        /// Hàm load dữ liệu Thể loại phim vào cbo Thể loại phim, lọc ra phim theo thể loại cho dễ xếp lịch
        /// </summary>
        private void addCategoryMovie()
        {
            DataTable dt = new DataTable();
            dt = ShowtimesDAO.Instance.loadCategoryMovie();
            cboTypeMovie.DataSource = dt;
            cboTypeMovie.DisplayMember = dt.Columns[1].ToString();
            cboTypeMovie.ValueMember = dt.Columns[0].ToString();

        }

        /// <summary>
        /// Hàm load phim vào cbo Movie theo thể loại của Phim - dễ tìm kiếm phim để xếp
        /// </summary>

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ShowtimesDAO.Instance.checkMovieandRoom(dtmChooseDay.Value.ToString(), cboShift.SelectedValue.ToString(), cboMovie.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Phim đã được xếp ở {0} trong cùng thời điểm", dt.Rows[0][2].ToString());
                }
                else
                {
                    btnChooseMovie.Show();
                }

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi: ", ex.Message);
            }



        }

        private void cboTypeMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ShowtimesDAO.Instance.loadMovie(cboTypeMovie.SelectedValue.ToString()).Rows.Count > 0)
            {


                DataTable dt = new DataTable();
                dt = ShowtimesDAO.Instance.loadMovie(cboTypeMovie.SelectedValue.ToString());

                cboMovie.DataSource = dt;
                cboMovie.DisplayMember = dt.Columns[1].ToString();
                cboMovie.ValueMember = dt.Columns[0].ToString();

            }

        }
        /// <summary>
        /// Khi Nhấn CHỌN thì thông tin về phim chiếu được đưa vào txtMovie ở bảng hiển thị thông tin
        /// </summary>
        private void btnChooseMovie_Click(object sender, EventArgs e)
        {
            //if (txtCountMovie.Text == "1")
            //    MessageBox.Show("Không thể chọn phim cho lịch chiếu này! Vui lòng thay đổi các thông tin ở trước.");
            //else
                txtMovie.Text = cboMovie.Text.ToString();
        }


        #endregion

        private void btnAddShowtimes_Click(object sender, EventArgs e)
        {
            try
            {

            
            
                bool f;
                if (dtmDay.Text.Trim() == " " || txtRoom.Text.Trim() == "" || txtShift.Text.Trim() == "" || txtMovie.Text.Trim() == "" || flagDay==false)
                {
                    MessageBox.Show("Phải chọn đầy đủ thông tin");
                }
                else
                {
                
                    // Lệnh Insert 
                    f = ShowtimesDAO.Instance.addShowtimes(
                    this.dtmDay.Value.ToString(),
                    this.cboRoom.SelectedValue.ToString(),
                    this.cboMovie.SelectedValue.ToString(),
                    this.cboShift.SelectedValue.ToString() );

                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        reset();

                        // Thông báo 
                        MessageBox.Show("Đã thêm xong!");             
                    }
                    else
                    {
                        MessageBox.Show("Thêm chưa xong!");
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnResetInfo_Click(object sender, EventArgs e)
        {

        }

       
    }
}