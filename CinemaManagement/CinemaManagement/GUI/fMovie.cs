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
    public partial class fMovie : Form
    {
        OpenFileDialog openIMG = new OpenFileDialog();
        Movie mo;
        MemoryStream ms;
        byte[] arrImage = null;

        public fMovie()
        {
            InitializeComponent();
            LoadData();
            cboInfoSearchMovie.ValueMember[0].ToString();
        }

        // Tải lại toàn bộ dữ liệu
        public void LoadData()
        {
            dtgMovie.DataSource = MovieDAO.Instance.loadData();
            picImageMovie.Image = null;
            lblIDMovie.Text = ""; // CHƯA SINH MÃ PHIM TỰ ĐỘNG !!!!
            txtNameMovie.Text = "";
            txtDirectorMovie.Text = "";
            cboCategoryMovie.ValueMember[0].ToString();
            txtRunningTimeMovie.Text = "";
            dtmReleaseDate.Value = DateTime.Now;
            txtLanguageMovie.Text = "";
            rdoActiveMovie.Checked = true;

            // Khi thêm phim thì không cần chọn trạng thái mà mặc định sẵn hoạt động. 
            // Khi nhấn xem thông tin bên dtg thì mới enable.
            rdoActiveMovie.Enabled = false;
            rdoInactiveMovie.Enabled = false;
        }

        // Thêm hình phim
        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            this.openIMG.FileName = string.Empty;
            this.openIMG.Filter = "JPEG Image|*.jpeg|JPG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp|GIF Image|*.gif|All Files|*.*";
            this.openIMG.FilterIndex = 1;
            this.openIMG.Multiselect = false;
            if (this.openIMG.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openIMG.FileName) == ".jpeg" || Path.GetExtension(openIMG.FileName) == ".jpg" || Path.GetExtension(openIMG.FileName) == ".png" || Path.GetExtension(openIMG.FileName) == ".bmp" || Path.GetExtension(openIMG.FileName) == ".gif")
                {
                    this.picImageMovie.Image = new Bitmap(openIMG.FileName);
                    ms = new MemoryStream();
                    this.picImageMovie.Image.Save(ms, picImageMovie.Image.RawFormat);
                    arrImage = ms.GetBuffer();
                    ms.Close();
                }
                else
                {
                    MessageBox.Show("Sai định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Xóa hình phim
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            this.picImageMovie.Image = null;
        }

        // Thêm phim
        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            mo = new Movie(this.lblIDMovie.Text.ToString(),
                                 this.txtNameMovie.Text.ToString(),
                                 this.txtLanguageMovie.Text.ToString(),
                                 this.txtDirectorMovie.Text.ToString(),
                                 this.txtRunningTimeMovie.Text.ToString(),
                                 Convert.ToDateTime(this.dtmReleaseDate.Value),
                                 this.cboCategoryMovie.SelectedValue.ToString(),
                                 1,
                                 arrImage);
            MovieDAO.Instance.insertMovie(mo);
        }

        private void fMovie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cinemaDBMSDataSet.CategoryMovie' table. You can move, or remove it, as needed.
            // Kết nối Combo Box thể loại dưới dtb
            this.categoryMovieTableAdapter.Fill(this.cinemaDBMSDataSet.CategoryMovie);
        }
    }
}
