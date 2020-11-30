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
            this.lblDate.Visible = false;
            this.lblShowDate_Showtime.Text = "";
            this.lblShiftShow.Visible = false;
            this.lblShowStarttime.Text = "";
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
                Button btn = new Button() { Width = MovieDAO.MoiveWidth, Height = MovieDAO.MoiveHeight };

               
                //btn.Text = item.Name_movie;
                btn.ForeColor = Color.Red;
               
                btn.Font = new Font("Microsoft Sans Serif", 18);
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.Text = item.ToString();
                btn.Tag = item;
                //MessageBox.Show(btn.Tag.GetType().ToString());
                btn.Click += btn_Click;

                fplShiftShow.Controls.Add(btn);

            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
           
           
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
