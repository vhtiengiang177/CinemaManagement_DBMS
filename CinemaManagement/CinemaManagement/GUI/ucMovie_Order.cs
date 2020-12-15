using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CinemaManagement.GUI
{
    public partial class ucMovie_Order : UserControl
    {
        MemoryStream ms;

        public ucMovie_Order()
        {
            InitializeComponent();
        }

        #region Properties
        private string id_movie;
        private string name_movie;
        private string director_movie;
        private string runningtime_movie;
        private string namecamo_movie;
        private byte[] img_movie;

        // Mã số phim
        public string Id_movie
        {
            get { return id_movie; }
            set { id_movie = value; }
        }

        // Tên phim
        public string Name_movie
        {
            get { return name_movie; }
            set { name_movie = value; lblShowNameMovie.Text = value; }
        }

        // Đạo diễn
        public string Director_movie
        {
            get { return director_movie; }
            set { director_movie = value; lblShowDirectorMovie.Text = value; }
        }

        // Thời lượng 
        public string Runningtime_movie
        {
            get { return runningtime_movie; }
            set { runningtime_movie = value; lblShowRunningTime.Text = value; }
        }

        // Thể loại
        public string Namecamo_movie
        {
            get { return namecamo_movie; }
            set { namecamo_movie = value; lblShowNameCategory.Text = value; }
        }

        // Poster phim
        public byte[] Img_movie
        {
            get { return img_movie; }
            set { img_movie = value;
                if (value != null)
                    picImageMovie.Image = byteArrayToImage(value);
                else picImageMovie.Image = picImageMovie.InitialImage;
            }
        }

        // Button Đặt vé. Dùng để bắt sự kiên qua bên Form.
        public Button btn_Order
        {
            get { return this.btnOrderMovie; }
        }

        #endregion


        #region MouseHover_Leave

        private void lblShowRunningTime_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void lblShowNameMovie_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void lblShowNameCategory_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void lblShowDirectorMovie_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void lblRunningTime_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void lblDirectorMovie_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void lblCategoryMovie_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void btnOrderMovie_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void ucMovie_Order_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void lblShowRunningTime_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void lblShowNameMovie_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void lblShowNameCategory_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void lblShowDirectorMovie_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void lblRunningTime_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void lblDirectorMovie_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void lblCategoryMovie_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void btnOrderMovie_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }

        private void ucMovie_Order_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
        }
        #endregion


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

        // Chọn đặt vé mở sang form lịch chiếu
        private void btnOrderMovie_MouseClick(object sender, MouseEventArgs e)
        {
            ucMovie_Order uc = new ucMovie_Order();
            fShowtime_Order fShowtime = new fShowtime_Order(Id_movie);
            fShowtime.ShowDialog();
        }
    }
}
