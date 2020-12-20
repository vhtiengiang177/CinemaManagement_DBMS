using CinemaManagement.DAO;
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
    public partial class fShowTime : Form
    {
        public fShowTime()
        {
            InitializeComponent();
            resetdgvShowtimes();
            loadShowtimes();
            cboSearchST.SelectedIndex = 0;
        }

        #region Load  và Reset dữ liệu
        /// <summary>
        /// Load lại dgvShowtimes
        /// </summary>
        public void loadShowtimes()
        {
            try
            {
                dgvShowtimes.DataSource = ShowtimesDAO.Instance.loadShowtimes();
                //dgvShowtimes.Columns[0].Visible = false;
                //dgvShowtimes.Columns[1].Visible = false;
                //dgvShowtimes.Columns[2].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong table Showtimes. Lỗi !!!");
            }

            dgvShowtimes.AutoResizeColumns();

        }


        /// <summary>
        /// Hàm reset lại các textbox và load lại dgv
        /// </summary>
        private void resetdgvShowtimes()
        {
            loadShowtimes();
            cboNameMovie.ResetText();
            cboRoom.ResetText();
            
            cboShiftShow.ResetText();
            
        }


        ///// <summary>
        ///// biểu tượng load lại dữ liệu
        ///// </summary>
        private void picReload_Click(object sender, EventArgs e)
        {
            resetdgvShowtimes();
        }


        ///// <summary>
        ///// Thực hiện đưa dữ liệu từ dgv lên các textbox bằng cách click vào dòng cần lấy dữ liệu
        ///// </summary>
        private void dgvShowtimes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvShowtimes.CurrentCell.RowIndex;

            // Chuyển thông tin lên panel 
            this.dtmDateShow.Value =
            Convert.ToDateTime(dgvShowtimes.Rows[r].Cells[3].Value.ToString());
            this.cboRoom.Text =
            dgvShowtimes.Rows[r].Cells[4].Value.ToString();
            this.cboNameMovie.Text =
            dgvShowtimes.Rows[r].Cells[5].Value.ToString();
            this.cboShiftShow.Text =
            dgvShowtimes.Rows[r].Cells[6].Value.ToString();

          //  MessageBox.Show(cboNameMovie.SelectedValue.ToString());
        }



        #endregion

        private void btnSearchShowtimes_Click(object sender, EventArgs e)
        {
        }



        /// <summary>
        /// Nhấn Enter để tìm kiếm
        /// </summary>
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchShowtimes.PerformClick();
            }
        }

        private void picReloadShowtimes_Click(object sender, EventArgs e)
        {
            loadShowtimes();
        }

        private void btnAddShowtimes_Click(object sender, EventArgs e)
        {
            fAddShowtimes frm = new fAddShowtimes();  
            frm.ShowDialog();
            loadShowtimes();
            
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditShowtimes_Click(object sender, EventArgs e)
        {
            fAddShowtimes frm = new fAddShowtimes();
            frm.Show();
        }

        

        private void btnDeleteSS_Click(object sender, EventArgs e)
        {
            if (cboRoom.Text==" ")
            {
                MessageBox.Show("Chưa chọn lịch chiếu để xóa!");
                
            }
            else
            {
                bool f;
                // Thứ tự dòng hiện hành 
                int r = dgvShowtimes.CurrentCell.RowIndex;
                
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Bạn có chắc chắn xóa lịch chiếu này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                try
                {
                    if (traloi == DialogResult.Yes)
                    {

                        // Thực hiện câu lệnh SQL 
                        f = ShowtimesDAO.Instance.deleteShowtimes(dtmDateShow.Value.ToString(), dgvShowtimes.Rows[r].Cells[0].Value.ToString(), dgvShowtimes.Rows[r].Cells[2].Value.ToString(), dgvShowtimes.Rows[r].Cells[1].Value.ToString());

                        if (f)
                        {
                            // Cập nhật lại DataGridView 
                            resetdgvShowtimes();

                            // Thông báo 
                            MessageBox.Show("Đã xóa xong!");
                        }
                        else
                        {
                            MessageBox.Show("Lịch chiếu này đã bán vé. Không xóa được!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Suất chiếu này không thể hủy do đã bán vé");
                }

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" && cboSearchST.Text != "")
            {
                resetdgvShowtimes();
            }
            if (cboSearchST.Text == "" && txtSearch.Text == "")
            {
                MessageBox.Show("Phải chọn thông tin tìm kiếm");
            }
            else
            {
                if (cboSearchST.SelectedIndex == 0) //Tìm theo tên phim
                {
                    dgvShowtimes.DataSource = ShowtimesDAO.Instance.searchShowtimesbyNameMovie(txtSearch.Text.ToString().Trim());
                }

            }
        }
    }
}
