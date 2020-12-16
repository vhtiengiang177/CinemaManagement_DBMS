using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
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
    public partial class fCinema : Form
    {
        public fCinema()
        {
            InitializeComponent();
            resetdgv();
        }


        #region Load  và Reset dữ liệu
        /// <summary>
        /// Load lại dgvCinema
        /// </summary>
        public void loadCinema()
        {
            try
            {
                dgvCinema.DataSource = CinemaDAO.Instance.loadCinema();
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong table Promotion. Lỗi !!!");
            }

            dgvCinema.AutoResizeColumns();
        }



        /// <summary>
        /// Hàm reset lại các textbox và load lại dgv
        /// </summary>
        private void resetdgv()
        {
            loadCinema();
            txtID.ResetText();
            txtName.ResetText();
            txtAddress.ResetText();
            txtNum.ResetText();
            txtStt.ResetText();
            txtCity.ResetText();
        }

        /// <summary>
        /// Thực hiện đưa dữ liệu từ dgv lên các textbox bằng cách click vào dòng cần lấy dữ liệu
        /// </summary>

        private void dgvCinema_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvCinema.CurrentCell.RowIndex;

            // Chuyển thông tin lên panel 
            this.txtID.Text =
            dgvCinema.Rows[r].Cells[0].Value.ToString();
            this.txtName.Text =
            dgvCinema.Rows[r].Cells[1].Value.ToString();
            this.txtAddress.Text =
            dgvCinema.Rows[r].Cells[2].Value.ToString();
            this.txtCity.Text =
            dgvCinema.Rows[r].Cells[3].Value.ToString();
            this.txtNum.Text =
            dgvCinema.Rows[r].Cells[4].Value.ToString();
            this.txtStt.Text =
            dgvCinema.Rows[r].Cells[5].Value.ToString();
        }
        #endregion

        #region Thêm, sửa, xóa

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Thêm dữ liệu          

            if (txtID.Text.Trim() == " " || txtNum.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtName.Text.Trim() == "" || txtStt.Text.Trim() == "")
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin");
            }
            else
            {
                // Lệnh Insert 
                bool f = CinemaDAO.Instance.addCinema(
                this.txtID.Text.ToString(),
                this.txtName.Text.ToString(),
                 this.txtAddress.Text.ToString(),
                 this.txtCity.Text.ToString(),
                this.txtNum.Text.ToString(),
                this.txtStt.Text.ToString());

                if (f)
                {
                    // Load lại dữ liệu trên DataGridView 
                    resetdgv();

                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                else
                {
                    MessageBox.Show("Thêm chưa xong!");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == " " || txtNum.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtName.Text.Trim() == "" || txtStt.Text.Trim() == "")
            {
                MessageBox.Show("Phải chọn thông tin để sửa");
            }
            else
            {


                // Gọi method UpdatePromotion  và thực hiện lệnh
                bool f = CinemaDAO.Instance.updateCinema(
               this.txtID.Text.ToString(),
               this.txtName.Text.ToString(),
                this.txtAddress.Text.ToString(),
                this.txtCity.Text.ToString(),
               this.txtNum.Text.ToString(),
               this.txtStt.Text.ToString());
                if (f)
                {
                    // Load lại dữ liệu trên DataGridView 
                    resetdgv();

                    // Thông báo 
                    MessageBox.Show("Đã cập nhật xong!");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật chưa xong!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtID.Text.Trim() == " " || txtNum.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtName.Text.Trim() == "" || txtStt.Text.Trim() == "")
                {
                    MessageBox.Show("Phải chọn thông tin để xóa");
                }
                else
                {
                    // Lấy thứ tự record hiện hành 
                    int r = dgvCinema.CurrentCell.RowIndex;
                    // Lấy id của record hiện hành 
                    string id =
                    dgvCinema.Rows[r].Cells[0].Value.ToString();
                    // Viết câu lệnh SQL 
                    // Hiện thông báo xác nhận việc xóa mẫu tin 
                    // Khai báo biến traloi 
                    DialogResult traloi;
                    // Hiện hộp thoại hỏi đáp 
                    traloi = MessageBox.Show("Bạn có chắc chắn xóa chương trình khuyến mãi này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    // Kiểm tra có nhắp chọn nút Ok không? 

                    if (traloi == DialogResult.Yes)
                    {

                        // Thực hiện câu lệnh SQL 
                        bool f = CinemaDAO.Instance.deleteCinema(id);
                        if (f)
                        {
                            // Cập nhật lại DataGridView 
                            resetdgv();

                            // Thông báo 
                            MessageBox.Show("Đã xóa xong!");
                        }
                        else
                        {
                            MessageBox.Show("Không xóa được!");
                        }
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Không xóa được!! Lỗi kĩ thuật rồi!");
            }

        }





        #endregion

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CinemaDAO.Instance.searchCinema(txtSearch.Text.Trim());
            dgvCinema.DataSource = dt;
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            resetdgv();
        }
    }
}
