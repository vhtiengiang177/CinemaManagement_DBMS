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

namespace CinemaManagement
{
    public partial class fPromotion : Form
    {
        int role; // cập nhật thông tin
        public fPromotion()
        {
            InitializeComponent();
            LoadPromotion();
            
            
            toolTip_start.SetToolTip(txt_DateStart, "Nhập mm/dd/yyyy");
            toolTip_start.SetToolTip(txt_DateEnd, "Nhập mm/dd/yyyy");
        }

        public void LoadPromotion()
        {
            try
            {

                dgvPromotion.DataSource = PromotionDAO.Intance.LoadData();
                

            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung trong table Promotion. Lỗi !!!");
            }
            role = 0;
            btnCancelAdd.Hide();
            
            dgvPromotion.AutoResizeColumns();
           
        }

        private void dgvPromotion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvPromotion.CurrentCell.RowIndex;

            // Chuyển thông tin lên panel 
            this.txt_IDPromotion.Text =
            dgvPromotion.Rows[r].Cells[0].Value.ToString();
            this.txt_NamePromotion.Text =
            dgvPromotion.Rows[r].Cells[2].Value.ToString();
            this.txt_DateStart.Text =
            dgvPromotion.Rows[r].Cells[1].Value.ToString();
            
            this.txt_DateEnd.Text =
            dgvPromotion.Rows[r].Cells[3].Value.ToString();
            this.txtObjectPromotion.Text=
            dgvPromotion.Rows[r].Cells[4].Value.ToString();
            this.txtValuePromotion.Text= 
            dgvPromotion.Rows[r].Cells[5].Value.ToString();

            btnDelete.Show();
            btnEdit.Show();
        }

        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {


            role = 1;
            txt_IDPromotion.ResetText();
            txt_NamePromotion.ResetText();
            txt_DateStart.ResetText();
            txt_DateEnd.ResetText();
            txtObjectPromotion.ResetText();
            txtValuePromotion.ResetText();
            btnCancelAdd.Show();
            

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            role = 2;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
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
                    bool f = PromotionDAO.Intance.DeletePromotion(txt_IDPromotion.Text.Trim());
                    if (f)
                    {
                        // Cập nhật lại DataGridView 
                        LoadPromotion();

                        // Thông báo 
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được!" );
                    }
                }
            }

         catch(Exception)
            {
                MessageBox.Show("Không xóa được!! Lỗi kĩ thuật rồi!");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            bool f = false;
            // Thêm dữ liệu 
           
            if (role==1)
            {
                
                
                    if (txt_IDPromotion.Text.Trim() == " " || txt_NamePromotion.Text.Trim() == "" || txt_DateStart.Text.Trim() == "" || txt_DateEnd.Text.Trim() == "" || txtObjectPromotion.Text.Trim() == "" || txtValuePromotion.Text.Trim() == "") 
                    {
                        MessageBox.Show("Phải nhập đầy đủ thông tin");
                    }
                    else
                    {
                        // Lệnh Insert 
                        f = PromotionDAO.Intance.AddPromotion(
                       this.txt_IDPromotion.Text.ToString(),
                       this.txt_NamePromotion.Text.ToString(),
                       Convert.ToDateTime(this.txt_DateStart.Text.ToString()),
                       Convert.ToDateTime(this.txt_DateEnd.Text.ToString()),
                       this.txtObjectPromotion.Text.ToString(),
                       Convert.ToDouble(this.txtValuePromotion.Text.ToString()));

                        if (f)
                        {
                            // Load lại dữ liệu trên DataGridView 
                            LoadPromotion();
                            txt_IDPromotion.ResetText();
                            txt_NamePromotion.ResetText();
                            txt_DateStart.ResetText();
                            txt_DateEnd.ResetText();
                            txtObjectPromotion.ResetText();
                            txtValuePromotion.ResetText();

                            // Thông báo 
                            MessageBox.Show("Đã thêm xong!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm chưa xong!");
                        }
                    }
                    
                
                
            }
            if (role==2) // Sua du lieu
            {
                

                    // Gọi method UpdateFood từu DBFood và thực hiện lệnh
                    f = PromotionDAO.Intance.UpdatePromotion(
                   this.txt_IDPromotion.Text.ToString(),
                   this.txt_NamePromotion.Text.ToString(),
                   Convert.ToDateTime(this.txt_DateStart.Text.ToString()),
                   Convert.ToDateTime(this.txt_DateEnd.Text.ToString()),
                   this.txtObjectPromotion.Text.ToString(),
                   Convert.ToDouble(this.txtValuePromotion.Text.ToString()));
                    if (f)
                    {
                        // Load lại dữ liệu trên DataGridView 
                        LoadPromotion();

                        // Thông báo 
                        MessageBox.Show("Đã cập nhật xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã cập nhật chưa xong!");
                    }
                
            }
            if (role==3)
            {
                MessageBox.Show("Chưa có thông tin để cập nhật!");
            }                
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            role = 3;
            LoadPromotion();
        }

        
    }
}
