using CinemaManagement.DAO;
using CinemaManagement.DTO;
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

namespace CinemaManagement.GUI
{
    public partial class fShowMovie_Order : Form
    {
        DataTable dt = new DataTable(); // Tạo kho ảo lưu trữ dl movie
        MemoryStream ms;

        public fShowMovie_Order()
        {
            InitializeComponent();
            showMovie();
        }


        // Hiển thị phim theo danh sách dạng lưới
        public void showMovie()
        {
            if(flpnlMovie.Controls.Count > 0)
            {
                // Xóa các control trên flow layout panel để không bị hiện lặp lại
                flpnlMovie.Controls.Clear(); 
            }
            dt = MovieDAO.Instance.showMovieActive();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Khởi tạo 1 uc
                ucMovie_Order ucMovie = new ucMovie_Order();

                // Lấy mã phim
                ucMovie.Id_movie = dt.Rows[i][0].ToString();
                ucMovie.Name_movie = dt.Rows[i][1].ToString();
                ucMovie.Director_movie = dt.Rows[i][2].ToString();
                ucMovie.Namecamo_movie = dt.Rows[i][3].ToString();
                ucMovie.Runningtime_movie = dt.Rows[i][4].ToString();

                // Nếu image null
                if (dt.Rows[i][7] == DBNull.Value)
                    ucMovie.Img_movie = null;
                else ucMovie.Img_movie = (byte[])dt.Rows[i][7];
                
                // Thêm uc vào flow layout panel
                flpnlMovie.Controls.Add(ucMovie);
                ucMovie.btn_Order.MouseClick += Btn_Order_MouseClick;
            }
        }

        private void Btn_Order_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
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

    }
}
