﻿
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
            // SỬA: Nếu mở comment ở sửa bên reset thì comment 3 hàm dưới này và 2 hàm addShiftInDay(); addCategoryMovie();
            chooseCinema();
            
            cboCinema.SelectedValue = "ci01";




        }

        public void chooseCinema()
        {
            DataTable cm = new DataTable();
            cm = CinemaDAO.Instance.loadCinema();
            cboCinema.DataSource = cm;
            cboCinema.ValueMember = cm.Columns[0].ToString();
            cboCinema.DisplayMember = cm.Columns[1].ToString();
            cboCinema.SelectedItem = " ";

        }

        /// <summary>
        /// Hàm xử lí khi click icon close thì đóng form
        /// </summary>
        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }

        private void reset()
        {
            txtMovie.ResetText();
            txtRoom.ResetText();
            txtShift.ResetText();
            dtmChooseDay.Value = DateTime.Now;
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

            // SỬA: Ngay từ mới vào form dữ liệu đã được đổ sẵn vào cbo, nhưng bấm vào lần nữa mới hiện nút chọn, vậy nên dùng những dòng dưới để bớt đi thao tác
            //addShiftInDay();
            //addCategoryMovie();
            dtmChooseDay.Value = DateTime.Now;
            //chooseCinema();
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


            
        }


        /// <summary>
        /// Hàm xử lí sự kiện khi chọn Ngày được chọn xếp còn bao nhiêu lượt (ví dụ tối đa 5 lượt/ngày)
        /// </summary>
        private void dtmChooseDay_ValueChanged(object sender, EventArgs e)
        {
            
            btnChooseDay.Show();
        }





        /// <summary>
        /// Khi Nhấn CHỌN thì thông tin về ngày chiếu được đưa vào txtDay ở bảng hiển thị thông tin
        /// </summary>
        bool flagDay = false;
        private void btnChooseDay_Click(object sender, EventArgs e)
        {

            txtRoom.ResetText();
            txtShift.ResetText();
            txtMovie.ResetText();
            btnChooseMovie.Hide();
            btnChooseShift.Hide();
            btnChoosrRoom.Hide();

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
            
        }

        /// <summary>
        /// Khi thay đổi ca chiếu hiển thị Số lần còn được chọn ca đó trong ngày
        /// </summary>
        private void cboShift_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            btnChooseShift.Show();

            
        }


        /// <summary>
        /// Khi Nhấn CHỌN thì thông tin về ca chiếu được đưa vào txtShift ở bảng hiển thị thông tin
        /// </summary>

        private void btnChooseShift_Click(object sender, EventArgs e)
        {

           
            txtMovie.ResetText();
            btnChooseMovie.Hide();
           

            string id_shift;
            
            DataTable dts = new DataTable();
            if (cboShift.SelectedIndex == 0)
            {
                id_shift = "ss01";
                dts = ShowtimesDAO.Instance.checkMovie(dtmChooseDay.Value.ToString(), "ss01", cboRoom.SelectedValue.ToString());
            }
            else if (cboShift.SelectedIndex == 1)
            {
                id_shift = "ss02";
                dts = ShowtimesDAO.Instance.checkMovie(dtmChooseDay.Value.ToString(), "ss02", cboRoom.SelectedValue.ToString());

            }
            else if (cboShift.SelectedIndex == 2)
            {
                id_shift = "ss03";
                dts = ShowtimesDAO.Instance.checkMovie(dtmChooseDay.Value.ToString(), "ss03", cboRoom.SelectedValue.ToString());

            }



            if (dts.Rows.Count > 0)
            {
               
                MessageBox.Show("Bị trùng lịch rồi vui ! Vui lòng thay đổi thông tin ở phía trước");

            }
            else
                txtShift.Text = cboShift.Text.ToString();
        }



        #endregion

        #region CHỌN PHÒNG CHIẾU

        /// <summary>
        /// Đưa dữ liệu Phòng chiếu vào cbo
        /// </summary>

        

        /// <summary>
        /// khi chọn phòng thì hiện thông tin  phòng đó còn bao nhiêu lượt chọn trong ngày
        /// </summary>

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChoosrRoom.Show();
            

        }


        /// <summary>
        /// Khi Nhấn CHỌN thì thông tin về phòng chiếu được đưa vào txtRoom ở bảng hiển thị thông tin
        /// </summary>

        private void btnChoosrRoom_Click(object sender, EventArgs e)
        {
            
            txtShift.ResetText();
            txtMovie.ResetText();
            btnChooseMovie.Hide();
            btnChooseShift.Hide();
            

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

            // Load hẳn phim tự động
            if (ShowtimesDAO.Instance.loadMovie(cboTypeMovie.SelectedValue.ToString()).Rows.Count > 0)
            {

                DataTable dt1 = new DataTable();
                dt1 = ShowtimesDAO.Instance.loadMovie(cboTypeMovie.SelectedValue.ToString());

                cboMovie.DataSource = dt1;
                cboMovie.DisplayMember = dt1.Columns[1].ToString();
                cboMovie.ValueMember = dt1.Columns[0].ToString();

            }

        }

        /// <summary>
        /// Hàm load phim vào cbo Movie theo thể loại của Phim - dễ tìm kiếm phim để xếp
        /// </summary>

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id_shift="";
                if (cboShift.Text == "9am-11am")
                {
                    id_shift = "ss01";
                }
                else if (cboShift.Text == "11am-1pm")
                {
                    id_shift = "ss02";
                   

                }
                else if (cboShift.Text == "1pm-3pm")
                {
                    id_shift = "ss03";
                    

                }
                DataTable dt = new DataTable();
                dt = ShowtimesDAO.Instance.checkMovieandRoom(dtmChooseDay.Value.ToString(), id_shift, cboMovie.SelectedValue.ToString());
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Phim đã được xếp ở " + dt.Rows[0][1].ToString() + " trong cùng thời điểm");
                }
                else
                {
                    btnChooseMovie.Show();
                }

                //SỬA: Phim đã được xếp ở phòng đó rồi thì để báo 1 lỗi trùng lúc thêm lịch, còn chỗ chọn phim vẫn để chọn bình thường.Ẩn 10 dòng trên
               // btnChooseMovie.Show();

            }
            catch (SqlException ex)
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
                string id_shift="";
                if (cboShift.Text == "9am-11am")
                {
                    id_shift = "ss01";
                }
                else if (cboShift.Text == "11am-1pm")
                {
                    id_shift = "ss02";


                }
                else if (cboShift.Text == "1pm-3pm")
                {
                    id_shift = "ss03";


                }

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
                    id_shift);

                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        reset();
                        txtRoom.ResetText();
                        txtShift.ResetText();
                        txtMovie.ResetText();
                        btnChooseMovie.Hide();
                        btnChooseShift.Hide();
                        btnChoosrRoom.Hide();
                        btnChooseDay.Hide();
                        dtmChooseDay.Value = DateTime.Now;

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
            txtRoom.ResetText();
            txtShift.ResetText();
            txtMovie.ResetText();
            btnChooseMovie.Hide();
            btnChooseShift.Hide();
            btnChoosrRoom.Hide();
            btnChooseDay.Hide();
            dtmChooseDay.Value = DateTime.Now;
        }

       
    }
}