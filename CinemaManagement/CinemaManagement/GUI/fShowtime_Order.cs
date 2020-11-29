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

namespace CinemaManagement.GUI
{
    public partial class fShowtime_Order : Form
    {
        DataTable dt = new DataTable(); // Tạo kho ảo lưu trữ dl movie
        Movie mo = new Movie();
        MemoryStream ms;

        private string id_movie;

        public string Id_movie
        {
            get { return this.id_movie; }
            set { this.id_movie = value; }
        }

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

            loadData();
        }

        // Tải toàn bộ dữ liệu
        public void loadData()
        {
            dt = MovieDAO.Instance.getMovie(Id_movie);
            // Lấy thông tin phim

            this.lblShowNameMovie.Text = dt.Rows[0][1].ToString();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
        }
    }
}
