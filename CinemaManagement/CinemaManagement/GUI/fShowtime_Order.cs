using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.DAO;
using CinemaManagement.DTO;
using CinemaManagement.Ticket1;

namespace CinemaManagement.GUI
{
    public partial class fShowtime_Order : Form
    {
        DataTable dt = new DataTable(); // Tạo kho ảo lưu trữ dl movie
        private Movie mo;
        MemoryStream ms;
        private string id_movie;
        private Showtimes stSelect = new Showtimes();
        public string Id_movie
        {
            get { return this.id_movie; }
            set { this.id_movie = value; }
        }

        public Movie Mo { get => mo; set => mo = value; }

        public fShowtime_Order(string id_mo)
        {
            InitializeComponent();
            this.Id_movie = id_mo;

            // Ẩn các thông tin chưa được chọn, khi chọn thông tin nào thì bật lên
            // Hiện ngày
            this.lblDate.Visible = false;
            this.lblShowDate_Showtime.Text = "";
            // Ca chiếu
            this.lblShiftShow.Visible = false;
            this.lblShowStarttime.Text = "";
            // Phòng
            this.lblRoom.Visible = false;
            this.lblShowNameRoom.Text = "";
            this.picImageMovie.Image = this.picImageMovie.InitialImage;
            loadData();
            loadDateShiftShow();
        }

        // Tải toàn bộ dữ liệu
        public void loadData()
        {
            dt = MovieDAO.Instance.getMovieByID(Id_movie);
            // Lấy thông tin phim
            foreach (DataRow item in dt.Rows)
            {
                this.Mo = new Movie(item);
            }
            this.lblShowNameMovie.Text = dt.Rows[0][1].ToString();
            if(dt.Rows[0][7] != DBNull.Value)
                this.picImageMovie.Image = byteArrayToImage((byte[])dt.Rows[0][7]);
        }

        /// <summary>
        /// Chuyển array byte sang image
        /// </summary>
        /// <param name="byteArrayIn"></param>
        /// <returns></returns>
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            ms.Close();
            return returnImage;
        }

        void loadDateShiftShow()
        {
            List<DateTime> listDate = ShowTimeOrderDAO.Instance.getDateShiftShow(Id_movie);

            foreach (var item in listDate)
            {
                Button btn = new Button() { Width = 80, Height = 80 };

               
                //btn.Text = item.Name_movie;
                btn.ForeColor = Color.Gray;
               
                btn.Font = new Font("Arial", 18);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.White;
                btn.Text = item.ToString();
                btn.Tag = item;
                //MessageBox.Show(btn.Tag.GetType().ToString());
                btn.Click += btn_Click;

                fplShiftShow.Controls.Add(btn);

            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime((sender as Button).Text);
            loadShiftShow(date);
            this.lblDate.Visible = true;
            this.lblShowDate_Showtime.Text = date.ToShortDateString();
        }

        public void loadShiftShow(DateTime date)
        {
            List<Showtimes> listShiftTime = ShowTimeOrderDAO.Instance.getShiftTime(Id_movie, date);
            if (flpShiftTime.Controls.Count > 0)
            {
                // Xóa các control trên flow layout panel để không bị hiện lặp lại
                flpShiftTime.Controls.Clear();
            }
            foreach (Showtimes item in listShiftTime)
            {
                Button btn = new Button() { Width =150, Height = 40 };


                //btn.Text = item.Name_movie;
                btn.ForeColor = Color.Gray;

                btn.Font = new Font("Microsoft Sans Serif", 18);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Text = item.Starttime_shiftshow;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Tag = item;
                //MessageBox.Show(btn.Tag.GetType().ToString());
                btn.Click += btnShift_Click;

                flpShiftTime.Controls.Add(btn);

            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        { 
            stSelect = (Showtimes)(sender as Button).Tag;
            // Ca chiếu
            this.lblShiftShow.Visible = true;
            this.lblShowStarttime.Text = stSelect.Starttime_shiftshow;
            // Phòng
            this.lblRoom.Visible = true;
            this.lblShowNameRoom.Text = (String)ShowTimeOrderDAO.Instance.getNameRoomForShowTime(stSelect.Id_room);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Showtimes st = new Showtimes();
        }
    }
}
