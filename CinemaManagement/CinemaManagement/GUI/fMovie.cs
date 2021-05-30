using CinemaManagement.DAO;
using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            loadData();
            cboInfoSearchMovie.SelectedItem = "Tên phim";
        }



        // Tải lại toàn bộ dữ liệu
        public void loadData()
        {
            this.dgvMovie.DataSource = MovieDAO.Instance.loadData();
            this.txtSearchMovie.Text = "";
            this.picImageMovie.Image = this.picImageMovie.InitialImage;
            this.lblShowIDMovie.Text = MovieDAO.Instance.createIDMovie().ToString(); 
            this.txtNameMovie.Text = "";
            this.txtDirectorMovie.Text = "";
           // this.cboCategoryMovie.ValueMember[0].ToString();
            this.txtRunningTimeMovie.Text = "";
            this.dtmReleaseDate.Value = DateTime.Now;
            this.txtLanguageMovie.Text = "";
            this.rdoActiveMovie.Checked = true;

            // Khi thêm phim thì không cần chọn trạng thái mà mặc định sẵn hoạt động. 
            // Khi nhấn xem thông tin bên dtg thì mới enable.
            this.rdoActiveMovie.Enabled = false;
            this.rdoInactiveMovie.Enabled = false;

            // Cho phép thêm phim
            this.btnInsertMovie.Enabled = true;
            // Không cho sử dụng 2 nút Sửa, Xóa vì chưa chọn phim
            this.btnUpdateMovie.Enabled = false;
            this.btnDeleteMovie.Enabled = false;

            // TODO: This line of code loads data into the 'cinemaDBMSDataSet.CategoryMovie' table. You can move, or remove it, as needed.
            // Kết nối Combo Box thể loại dưới dtb
            //this.categoryMovieTableAdapter.Fill(this.cinemaDBMSDataSet.CategoryMovie);



            //load Category Movie
            DataTable dtCategory = new DataTable();
            dtCategory = MovieDAO.Instance.loadCategory();
            cboCategoryMovie.DataSource = dtCategory;
            cboCategoryMovie.DisplayMember = dtCategory.Columns[1].ToString();
            cboCategoryMovie.ValueMember = dtCategory.Columns[0].ToString();
        }

        // Nhấn vào nút reload lại form. (tải lại danh sách)
        private void picReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        /// <summary>
        /// Chuyển image sang array byte
        /// </summary>
        /// <param name="imageIn"></param>
        public void imageToByteArray(System.Drawing.Image imageIn)
        {
            ms = new MemoryStream();
            imageIn.Save(ms, picImageMovie.Image.RawFormat);
            arrImage = ms.GetBuffer();
            ms.Close();
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

        // Thêm hình phim
        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            this.openIMG.FileName = string.Empty;
            this.openIMG.Filter = "JPEG Image|*.jpeg|JPG Image|*.jpg|PNG Image|*.png|All Files|*.*";
            this.openIMG.FilterIndex = 1;
            this.openIMG.Multiselect = false;
            if (this.openIMG.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openIMG.FileName) == ".jpeg" || Path.GetExtension(openIMG.FileName) == ".jpg" || Path.GetExtension(openIMG.FileName) == ".png")
                {
                    this.picImageMovie.Image = new Bitmap(openIMG.FileName);
                    imageToByteArray(this.picImageMovie.Image); // Chuyển hình sang mảng byte
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
            this.picImageMovie.Image = this.picImageMovie.InitialImage;
            imageToByteArray(this.picImageMovie.Image);
        }

        // Xử lý lỗi đầu vào
        private bool inputValidate()
        {
            int errorCount = 0;
            if(txtNameMovie.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtNameMovie, "Không để trống trường này.");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtNameMovie, null);
            }
            if (txtDirectorMovie.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtDirectorMovie, "Không để trống trường này.");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtDirectorMovie, null);
            }
            if (txtLanguageMovie.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtLanguageMovie, "Không để trống trường này.");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtLanguageMovie, null);
            }
            if (txtRunningTimeMovie.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtRunningTimeMovie, "Không để trống trường này.");
                errorCount += 1;
            }
            else
            {
                errorProvider.SetError(this.txtRunningTimeMovie, null);
            }
            if (errorCount == 0)
            {
                return true; // Không có lỗi nào nữa
            }
            else return false; 
        }

        // Thêm phim
        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            if(inputValidate())
            {
                imageToByteArray(picImageMovie.Image);
                mo = new Movie(this.lblShowIDMovie.Text.ToString(),
                     this.txtNameMovie.Text.ToString(),
                     this.txtLanguageMovie.Text.ToString(),
                     this.txtDirectorMovie.Text.ToString(),
                     this.txtRunningTimeMovie.Text.ToString(),
                     Convert.ToDateTime(this.dtmReleaseDate.Value),
                     this.cboCategoryMovie.SelectedValue.ToString(),
                     1,
                     arrImage);
                try
                {
                    MovieDAO.Instance.insertMovie(mo);
                    loadData();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Chọn thông tin phim của 1 hàng, hiển thị bên chỉnh sửa - xóa
        private void dgvMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtGetMovie = new DataTable();
            dtGetMovie = MovieDAO.Instance.getMovie(dgvMovie.CurrentRow.Cells[0].Value.ToString());
            // Kiểm tra ảnh có null không. 
            if (dtGetMovie.Rows[0][7] is null || dtGetMovie.Rows[0][7] == DBNull.Value)
            {
                picImageMovie.Image = picImageMovie.InitialImage;
                imageToByteArray(picImageMovie.Image);
            }
            else
            {
                arrImage = (byte[])dtGetMovie.Rows[0][7];
                this.picImageMovie.Image = byteArrayToImage(arrImage);
            }

            this.lblShowIDMovie.Text = dtGetMovie.Rows[0][0].ToString();
            this.txtNameMovie.Text = dtGetMovie.Rows[0][1].ToString();
            this.txtLanguageMovie.Text = dtGetMovie.Rows[0][2].ToString();
            this.txtDirectorMovie.Text = dtGetMovie.Rows[0][3].ToString();
            this.txtRunningTimeMovie.Text = dtGetMovie.Rows[0][4].ToString();
            this.dtmReleaseDate.Value = Convert.ToDateTime(dtGetMovie.Rows[0][5].ToString());
            this.cboCategoryMovie.SelectedValue = dtGetMovie.Rows[0][6].ToString();

            // Kiểm tra state của phim
            if (dtGetMovie.Rows[0][8].ToString() == "True")
            {
                rdoActiveMovie.Checked = true;
            }
            else
            {
                rdoInactiveMovie.Checked = true;
            }

            // Hiển thị 2 radio button Đang hoạt động và Ngưng hoạt động
            this.rdoActiveMovie.Enabled = true;
            this.rdoInactiveMovie.Enabled = true;

            // Ẩn nút thêm phim vì thông tin này đã có dưới csdl
            btnInsertMovie.Enabled = false;
            // Hiển thị nút sửa - xóa
            btnUpdateMovie.Enabled = true;
            btnDeleteMovie.Enabled = true;
        }

        // Sửa phim
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if(inputValidate())
            {
                byte stateM;
                if (rdoActiveMovie.Checked == true)
                {
                    stateM = 1;
                }
                else
                {
                    stateM = 0;
                }
                mo = new Movie(this.lblShowIDMovie.Text.ToString(),
                                 this.txtNameMovie.Text.ToString(),
                                 this.txtLanguageMovie.Text.ToString(),
                                 this.txtDirectorMovie.Text.ToString(),
                                 this.txtRunningTimeMovie.Text.ToString(),
                                 Convert.ToDateTime(this.dtmReleaseDate.Value),
                                 this.cboCategoryMovie.SelectedValue.ToString(),
                                 stateM,
                                 arrImage);


                MovieDAO.Instance.updateMovie(mo);
                loadData();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        // Xóa phim
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                // Hiện hộp thoại hỏi đáp 
                result = MessageBox.Show("Bạn có chắc chắn xóa phim này không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 

                if (result == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = MovieDAO.Instance.deleteMovie(this.lblShowIDMovie.Text.ToString());
                    if (f)
                    {
                        // Cập nhật lại DataGridView 
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khi chọn vào cbo tìm kiếm theo loại, kiểm tra xem có chọn đang hoạt động hay ngưng hoạt động không
        private void cboInfoSearchMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboInfoSearchMovie.SelectedIndex == 6 || cboInfoSearchMovie.SelectedIndex == 7)
            {
                this.txtSearchMovie.Enabled = false; // Không cho tìm kiếm bằng txt nữa vì đã chọn rõ trạng thái rồi
                if (cboInfoSearchMovie.SelectedIndex == 6) // Đang hoạt động
                {
                    dgvMovie.DataSource = MovieDAO.Instance.searchActiveStateMovie();
                }
                else if (cboInfoSearchMovie.SelectedIndex == 7) // Ngưng hoạt động
                {
                    dgvMovie.DataSource = MovieDAO.Instance.searchInactiveMovie();
                }
            }
            else
            {
                this.txtSearchMovie.Enabled = true;
                this.dgvMovie.DataSource = MovieDAO.Instance.loadData(); // Hiển thị lại ds đầy đủ các phim
            }
        }

        // Khi thay đổi chữ trong ô tìm kiếm thì tìm luôn
        private void txtSearchMovie_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchMovie.Text == "")
            {
                this.dgvMovie.DataSource = MovieDAO.Instance.loadData(); // Hiển thị lại ds đầy đủ các phim
            }
            else if (cboInfoSearchMovie.SelectedIndex == 0) // ID
            {
                dgvMovie.DataSource = MovieDAO.Instance.searchIDMovie(txtSearchMovie.Text.Trim());
            }
            else if (cboInfoSearchMovie.SelectedIndex == 1) // Tên phim
            {
                dgvMovie.DataSource = MovieDAO.Instance.searchNameMovie(txtSearchMovie.Text.Trim());
            }
            else if (cboInfoSearchMovie.SelectedIndex == 2) // Đạo diễn
            {
                dgvMovie.DataSource = MovieDAO.Instance.searchDirectorMovie(txtSearchMovie.Text.Trim());
            }
            else if (cboInfoSearchMovie.SelectedIndex == 3) // Thể loại
            {
                dgvMovie.DataSource = MovieDAO.Instance.searchNameCamoMovie(txtSearchMovie.Text.Trim());
            }
            else if (cboInfoSearchMovie.SelectedIndex == 4) // Thời lượng
            {
                dgvMovie.DataSource = MovieDAO.Instance.searchRunningTimeMovie(txtSearchMovie.Text.Trim());
            }
            else if (cboInfoSearchMovie.SelectedIndex == 5) // Ngôn ngữ
            {
                dgvMovie.DataSource = MovieDAO.Instance.searchLanguageMovie(txtSearchMovie.Text.Trim());
            }
        }

        // Mở form thể loại để thêm thể loại mới. 
        private void btnInsertCategory_Click(object sender, EventArgs e)
        {
            fCategoryMovie fCamo = new fCategoryMovie();
            fCamo.ShowDialog();
            if(fCamo.close == true)
            {
                loadData();
            }
        }

        private void fMovie_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
