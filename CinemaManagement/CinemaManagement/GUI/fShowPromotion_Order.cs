using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaManagement.DAO;
namespace CinemaManagement.GUI
{
    public partial class fShowPromotion_Order : Form
    {
        public fShowPromotion_Order()
        {
            InitializeComponent();
            loadPromotion();
            //Vé mua măc định là 1, nếu chọn nhiều vé thì đặt biến thêm vô
            txtNumTicket.Text = "1";
            txtTypeCus.Text = "Chưa là thành viên";
        }
        //tổng giảm
        double sumDes = 0;
        

        //load chương trình khuyến mãi vào cbo
        private void loadPromotion()
        {
            DataTable dt = new DataTable();
            dt = PromotionDAO.Instance.LoadData();
            cboPromotion.DataSource = dt;
            cboPromotion.DisplayMember= dt.Columns[1].ToString();
            cboPromotion.ValueMember= dt.Columns[0].ToString();
        }

        
        //Khi chọn giá trị trong cbo Mã khuyến mãi thì giá trị khuyến mãi thay đổi theo
        private void cboPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cboPromotion.SelectedValue.ToString();

            if (PromotionDAO.Instance.SearchValue_Promotion(str).Rows.Count>0)
            {
                txtValue.Text = PromotionDAO.Instance.SearchValue_Promotion(str).Rows[0][0].ToString();
            }    
            else
            {
                txtValue.Text = "0";
            }    
            
        }

        
        //Khi thay đổi tìm kiếm :theo SĐT hoặc theo CMND thì bảng giá trị thay đổi theo
        private void cboCategorySearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CustomerDAO.Instance.loadCustomerforOrder();
            if (cboCategorySearch.SelectedIndex == 0) //Tìm theo SĐT
            {
                
                cboCus.DataSource = dt;
                cboCus.DisplayMember = dt.Columns[6].ToString();
                cboCus.ValueMember = dt.Columns[0].ToString();
            }
            else //Tìm theo CMND
            {
                cboCus.DataSource = dt;
                cboCus.DisplayMember = dt.Columns[5].ToString();
                cboCus.ValueMember = dt.Columns[0].ToString();
            }
        }


        //Sau khi có mã khách hàng lấy đc các thông tin của khách
        private void cboCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = PromotionDAO.Instance.SearchCus(cboCus.SelectedValue.ToString());
            if (dt.Rows.Count>0)
            {
                txtIDcus.Text = dt.Rows[0][0].ToString();
                txtPointCus.Text = dt.Rows[0][9].ToString();
                txtNameCus.Text = dt.Rows[0][1].ToString() + dt.Rows[0][2].ToString();
                if (dt.Rows[0][10].ToString() == "tycu01")
                {
                    txtTypeCus.Text = "Thường";
                }
                if (dt.Rows[0][10].ToString()=="tycu02")
                {
                    txtTypeCus.Text = "Bạc";
                }
                if (dt.Rows[0][10].ToString() == "tycu03")
                {
                    txtTypeCus.Text = "Vàng";
                }
                if (dt.Rows[0][10].ToString() == "tycu04")
                {
                    txtTypeCus.Text = "VIP";
                }


            }
            else
            {
                txtIDcus.ResetText();
                txtPointCus.ResetText();
                txtNameCus.ResetText();
                txtTypeCus.ResetText();
            }    

           
        }


        //KHi chọn btn Tính toán thì sẽ tính đc tổng giảm trên vé
        private void btnCal_Click(object sender, EventArgs e)
        {
            
            if (cbcheckpoint.Checked==true)
            {
                sumDes += Convert.ToInt32(txtPointCus.Text)*1000;
            }
            if (nudHSSV.Value != 0)
            {
                sumDes += 20000* Convert.ToInt32(nudHSSV.Value);
            }
            if (txtValue.Text!="0")
            {
                sumDes += Convert.ToDouble(txtValue.Text) * 90000;
            }

            double sum = Convert.ToInt32(txtNumTicket.Text) * 90000;
            lbThanhTien.Text = "Thành tiền: " + sum.ToString() + " VNĐ ";
            lbTongGiam.Text = "Tổng giảm: " + sumDes.ToString() + " VNĐ";
            lbTongTra.Text = "Tổng trả: " + (sum - sumDes).ToString() + " VNĐ";
            

        }
    }
}
