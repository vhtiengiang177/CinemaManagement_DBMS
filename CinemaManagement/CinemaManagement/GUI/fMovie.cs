using CinemaManagement.DAO;
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
        public fMovie()
        {
            InitializeComponent();
            LoadData();
            cboInfoSearchMovie.Text = "Tên phim";
        }

        // Tải lại toàn bộ dữ liệu
        public void LoadData()
        {
            dtgMovie.DataSource = MovieDAO.Instance.LoadData();
            picImageMovie.Image = null;
            lblIDMovie.Text = "";
            txtNameMovie.Text = "";
            txtDirectorMovie.Text = "";
            cboCategoryMovie.Text = "";
            txtRunningTimeMovie.Text = "";
            dtmReleaseDate.Value = DateTime.Now;
            txtLanguageMovie.Text = "";
            rdoActiveMovie.Checked = true;
        }

        // Thêm hình cho phim
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
                }
                else
                {
                    MessageBox.Show("Sai định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

    }
}
