using CinemaManagement.DAO;
using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement.GUI
{
    public partial class fCategoryMovie : Form
    {
        CategoryMovie camo;
        public bool close = false; // Biến kiểm tra đóng form chưa

        public fCategoryMovie()
        {
            InitializeComponent();
            loadData();
            cboInfoSearchCaMo.SelectedItem = "Tên thể loại";
        }

        // Tải lại dữ liệu form
        public void loadData()
        {
            dgvCategoryMovie.DataSource = CategoryMovieDAO.Instance.loadData();
            lblShowIDCategoryMovie.Text = CategoryMovieDAO.Instance.createIDCategoryMovie().ToString();
            txtNameCategoryMovie.Text = "";

            // Cho phép thêm thể loại
            btnInsertCategoryMovie.Enabled = true;
            // Không cho sửa - xóa vì chưa chọn 1 thể loại trong danh sách
            btnUpdateCategoryMovie.Enabled = false;
            btnDeleteCategoryMovie.Enabled = false;
        }

        // Nhấn vào nút reload lại form. (tải lại danh sách)
        private void picReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        // Xử lý lỗi đầu vào
        private bool inputValidate()
        {
            if (txtNameCategoryMovie.Text.Trim().Length <= 0)
            {
                errorProvider.SetError(this.txtNameCategoryMovie, "Không để trống trường này.");
                return false;
            }
            else
            {
                errorProvider.SetError(this.txtNameCategoryMovie, null);
                return true;
            }
        }

        // Thêm thể loại
        private void btnInsertCategoryMovie_Click(object sender, EventArgs e)
        {
            if(inputValidate())
            {
                camo = new CategoryMovie(lblShowIDCategoryMovie.Text.ToString().Trim(),
                                            txtNameCategoryMovie.Text.ToString());
                try
                {
                    CategoryMovieDAO.Instance.insertCategoryMovie(camo);
                    loadData();
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Chọn thông tin thể loại phim của 1 hàng, hiển thị bên chỉnh sửa - xóa
        private void dgvCategoryMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtGetCategoryMovie = new DataTable();
            dtGetCategoryMovie = CategoryMovieDAO.Instance.getCategoryMovie(dgvCategoryMovie.CurrentRow.Cells[0].Value.ToString());
            this.lblShowIDCategoryMovie.Text = dtGetCategoryMovie.Rows[0][0].ToString();
            this.txtNameCategoryMovie.Text = dtGetCategoryMovie.Rows[0][1].ToString();

            // Ẩn nút thêm phim vì thông tin này đã có dưới csdl
            btnInsertCategoryMovie.Enabled = false;
            // Hiển thị nút sửa - xóa
            btnUpdateCategoryMovie.Enabled = true;
            btnDeleteCategoryMovie.Enabled = true;
        }

        // Sửa thể loại
        private void btnUpdateCategoryMovie_Click(object sender, EventArgs e)
        {
            if (inputValidate())
            {
                camo = new CategoryMovie(lblShowIDCategoryMovie.Text.ToString().Trim(),
                                            txtNameCategoryMovie.Text.ToString());
                try
                {
                    CategoryMovieDAO.Instance.updateCategoryMovie(camo);
                    loadData();
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Xóa thể loại
        private void btnDeleteCategoryMovie_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc chắn xóa thể loại phim này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 

                if (traloi == DialogResult.Yes)
                {

                    // Thực hiện câu lệnh SQL 
                    bool f = CategoryMovieDAO.Instance.deleteCategoryMovie(this.lblShowIDCategoryMovie.Text.ToString().Trim());
                    if (f)
                    {
                        // Cập nhật lại DataGridView 
                         loadData();

                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
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

        // Xử lý sự kiện tìm kiếm danh sách
        private void txtSearchCategoryMovie_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchCategoryMovie.Text == "")
            {
                // Tải lại danh sách ban đầu
                dgvCategoryMovie.DataSource = CategoryMovieDAO.Instance.loadData();
            }
            else if(cboInfoSearchCaMo.SelectedIndex == 0) // Mã thể loại
            {
                dgvCategoryMovie.DataSource = CategoryMovieDAO.Instance.searchIDCategoryMovie(txtSearchCategoryMovie.Text.ToString());
            }
            else if(cboInfoSearchCaMo.SelectedIndex == 1) // Tên thể loại
            {
                dgvCategoryMovie.DataSource = CategoryMovieDAO.Instance.searchNameCategoryMovie(txtSearchCategoryMovie.Text.ToString());
            }
        }

        // Xử lý sự kiện đóng form để load lại dữ liệu bên form Movie
        private void fCategoryMovie_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
        }
    }
}
