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

    
    public partial class fPromotion : Form
    {
        
        bool f = false;
        public fPromotion()
        {
            InitializeComponent();
            resetdgvPromotion();
            
        }

        #region Load  và Reset dữ liệu
        /// <summary>
        /// Load lại dgvPromotion
        /// </summary>
        public void LoadPromotion()
        {
            try
            {
                dgvPromotion.DataSource = PromotionDAO.Instance.LoadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong table Promotion. Lỗi !!!");
            }
          
            dgvPromotion.AutoResizeColumns();
           
        }


        /// <summary>
        /// Hàm reset lại các textbox và load lại dgv
        /// </summary>
        private void resetdgvPromotion()
        {
            LoadPromotion();
            txtIDPromotion.ResetText();
            txtNamePromotion.ResetText();
            txtObjectPromotion.ResetText();
            txtValuePromotion.ResetText();
            txtSearchPromotion.ResetText();
        }


        /// <summary>
        /// biểu tượng load lại dữ liệu
        /// </summary>
        private void picReload_Click(object sender, EventArgs e)
        {
            resetdgvPromotion();
        }


        /// <summary>
        /// Thực hiện đưa dữ liệu từ dgv lên các textbox bằng cách click vào dòng cần lấy dữ liệu
        /// </summary>
        private void dgvPromotion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvPromotion.CurrentCell.RowIndex;

            // Chuyển thông tin lên panel 
            this.txtIDPromotion.Text =
            dgvPromotion.Rows[r].Cells[0].Value.ToString();
            this.txtNamePromotion.Text =
            dgvPromotion.Rows[r].Cells[1].Value.ToString();
            this.dtmStart.Value =
            Convert.ToDateTime(dgvPromotion.Rows[r].Cells[2].Value.ToString());         
            this.dtmEnd.Value =
            Convert.ToDateTime(dgvPromotion.Rows[r].Cells[3].Value.ToString());
            this.txtObjectPromotion.Text=
            dgvPromotion.Rows[r].Cells[4].Value.ToString();
            this.txtValuePromotion.Text =
            dgvPromotion.Rows[r].Cells[5].Value.ToString();
        }
        #endregion

        #region Thêm, Sửa, Xóa, Cancel
        /// <summary>
        /// Thực hiện thêm dữ liệu khi nhấn button THÊM
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {

           
            // Thêm dữ liệu          
                
                if (txtIDPromotion.Text.Trim() == " " || txtNamePromotion.Text.Trim() == ""   || txtObjectPromotion.Text.Trim() == "" || txtValuePromotion.Text.Trim() == "")
                {
                    MessageBox.Show("Phải nhập đầy đủ thông tin");
                }
                else
                {
                    // Lệnh Insert 
                    f = PromotionDAO.Instance.addPromotion(
                   this.txtIDPromotion.Text.ToString(),
                   this.txtNamePromotion.Text.ToString(),
                    this.dtmStart.Value.ToString(),
                    this.dtmEnd.Value.ToString(),
                   this.txtObjectPromotion.Text.ToString(),
                   Convert.ToDouble(this.txtValuePromotion.Text.ToString()));

                    if (f)
                    {
                    // Load lại dữ liệu trên DataGridView 
                    resetdgvPromotion();

                        // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm chưa xong!");
                    }
                }
        }




        /// <summary>
        /// Thực hiện hủy thêm dữ liệu trong quá trình THÊM
        /// </summary>
      
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {

            resetdgvPromotion();
        }


        /// <summary>
        /// Thực hiện sửa dữ liệu khi nhấn button SỬA
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtIDPromotion.Text.Trim() == " " || txtNamePromotion.Text.Trim() == "" ||  txtObjectPromotion.Text.Trim() == "" || txtValuePromotion.Text.Trim() == "")
            {
                MessageBox.Show("Phải chọn thông tin để sửa");
            }
            else
            {


                // Gọi method UpdatePromotion  và thực hiện lệnh
                f = PromotionDAO.Instance.updatePromotion(
                   this.txtIDPromotion.Text.ToString(),
                   this.txtNamePromotion.Text.ToString(),
                    this.dtmStart.Value.ToString(),
                    this.dtmEnd.Value.ToString(),
                   this.txtObjectPromotion.Text.ToString(),
                   Convert.ToDouble(this.txtValuePromotion.Text.ToString()));
                if (f)
                {
                    // Load lại dữ liệu trên DataGridView 
                    resetdgvPromotion();

                    // Thông báo 
                    MessageBox.Show("Đã cập nhật xong!");
                }
                else
                {
                    MessageBox.Show("Đã cập nhật chưa xong!");
                }
            }

        }



        /// <summary>
        /// Thực hiện xóa dữ liệu khi nhấn button XÓA
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtIDPromotion.Text.Trim() == " " || txtNamePromotion.Text.Trim() == "" ||   txtObjectPromotion.Text.Trim() == "" || txtValuePromotion.Text.Trim() == "")
                {
                    MessageBox.Show("Phải chọn thông tin để xóa");
                }
                else
                {
                    // Lấy thứ tự record hiện hành 
                    int r = dgvPromotion.CurrentCell.RowIndex;
                    // Lấy id của record hiện hành 
                    string id =
                    dgvPromotion.Rows[r].Cells[0].Value.ToString();
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
                        bool f = PromotionDAO.Instance.deletePromotion(id);
                        if (f)
                        {
                            // Cập nhật lại DataGridView 
                            resetdgvPromotion();

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

         catch(Exception)
            {
                MessageBox.Show("Không xóa được!! Lỗi kĩ thuật rồi!");
            }


        }
        #endregion

        #region Tìm kiếm

        /// <summary>
        /// Tìm kiếm thông tin 
        /// </summary>
        private void btnSearchPromotion_Click(object sender, EventArgs e)
        {
            if (cboPromotion.Text=="" || txtSearchPromotion.Text=="")
            {
                MessageBox.Show("Phải nhập thông tin tìm kiếm");
            }    
            else
            {
                if (cboPromotion.SelectedIndex==0) //Tìm theo tên chương trình
                {
                    dgvPromotion.DataSource = PromotionDAO.Instance.searchPromotionbyname(txtSearchPromotion.Text.ToString().Trim());
                }
                if (cboPromotion.SelectedIndex == 1) //Tìm theo đối tượng
                {
                    dgvPromotion.DataSource = PromotionDAO.Instance.searchPromotionbyobject(txtSearchPromotion.Text.ToString());
                }
                if (cboPromotion.SelectedIndex == 2) //Tìm theo mức khuyến mãi
                {
                    dgvPromotion.DataSource = PromotionDAO.Instance.searchPromotionbyvalue(txtSearchPromotion.Text.ToString());
                }
            }    
        }

        /// <summary>
        /// Nhấn Enter để tìm kiếm
        /// </summary>
        
        private void txtSearchPromotion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchPromotion.PerformClick();
            }
        }

        #endregion

        

        

        
    }
}
