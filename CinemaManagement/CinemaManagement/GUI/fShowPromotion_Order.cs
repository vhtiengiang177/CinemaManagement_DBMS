using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using CinemaManagement.DAO;
using CinemaManagement.DTO;

namespace CinemaManagement.GUI
{
    public partial class fShowPromotion_Order : Form
    {
        private List<Seat> listSeat = new List<Seat>();

        private Showtimes showtimes;

        private Employee employee;


        MemoryStream ms;

        public static string idEmployee = fMain.idEmployeeMain;
        public static int typeEmployee = fMain.typeEmp;

        List<String> listPromotion = new List<String>();
        public fShowPromotion_Order(Showtimes st, List<Seat> se)
        {
            InitializeComponent();
            this.Showtimes = st;
            this.ListSeat = se;
            LoadInfo();
            loadPromotion();
            //Vé mua măc định là 1, nếu chọn nhiều vé thì đặt biến thêm vô
            txtNumTicket.Text = se.Count.ToString(); ;
            txtTypeCus.Text = "Chưa là thành viên";
            cboCategorySearch.SelectedIndex = 0;
            cboPromotion.SelectedItem = null;
            CalcMoney();
        }

        public fShowPromotion_Order()
        {
            InitializeComponent();
            //this.Showtimes = st;
            //this.ListSeat = se;
            //LoadInfo();
            loadPromotion();
            //Vé mua măc định là 1, nếu chọn nhiều vé thì đặt biến thêm vô
            txtNumTicket.Text = "1";
            txtTypeCus.Text = "Chưa là thành viên";
        }

        public fShowPromotion_Order(int type, string idEmp)
        {

            InitializeComponent();
            fShowPromotion_Order.idEmployee = idEmp;
            fShowPromotion_Order.typeEmployee = type;
            //this.Showtimes = st;
            //this.ListSeat = se;
            //LoadInfo();
            loadPromotion();
            //Vé mua măc định là 1, nếu chọn nhiều vé thì đặt biến thêm vô
            txtNumTicket.Text = "1";
            txtTypeCus.Text = "Chưa là thành viên";
        }
        //tổng giảm
        int sumDes = 0;

        int sum = 0;

        public List<Seat> ListSeat { get => listSeat; set => listSeat = value; }
        public Showtimes Showtimes { get => showtimes; set => showtimes = value; }
        public Employee Employee { get => employee; set => employee = value; }

        //Convert image
        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            ms.Close();
            return returnImage;
        }

        //load chương trình khuyến mãi vào cbo
        private void loadPromotion()
        {
            DataTable dt = new DataTable();
            dt = PromotionDAO.Instance.LoadDataPR();
            cboPromotion.DataSource = dt;
            cboPromotion.DisplayMember= dt.Columns[1].ToString();
            cboPromotion.ValueMember= dt.Columns[0].ToString();
        }

        private void LoadInfo()
        {
            this.lblShowDate_Showtime.Text = this.Showtimes.Date_showtimes.ToShortDateString();
            this.lblShowStarttime.Text = this.Showtimes.Starttime_shiftshow.ToString();
            this.lblShowNameRoom.Text = RoomDAO.Instance.getNameRoom(this.Showtimes.Id_room);


            //label ghế
            this.lblShowNameSeat.Text = "";
            foreach(Seat item in this.ListSeat)
            {
                lblShowNameSeat.Text += item.Name_seat.ToString() + " - ";
            }
            int temp = lblShowNameSeat.Text.Length - 3;
            //MessageBox.Show(temp.ToString());
            if (lblShowNameSeat.Text.Length > 4)
            {
                lblShowNameSeat.Text = lblShowNameSeat.Text.Remove(temp, 3);
            }

            DataTable dt = MovieDAO.Instance.getMovieByID(this.Showtimes.Id_movie);
            // Lấy thông tin phim
            this.lblShowNameMovie.Text = dt.Rows[0][1].ToString();
            if (dt.Rows[0][7] != DBNull.Value)
                this.picImageMovie.Image = byteArrayToImage((byte[])dt.Rows[0][7]);
        }

        
        //Khi chọn giá trị trong cbo Mã khuyến mãi thì giá trị khuyến mãi thay đổi theo
        private void cboPromotion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBoxItem item = (sender as ComboBoxItem)..Content.ToString();
            //string str = item.Content.ToString();

            if (cboPromotion.SelectedItem != null)
            {


                string str = cboPromotion.SelectedValue.ToString();

                if (PromotionDAO.Instance.searchValuePromotion(str).Rows.Count > 0)
                {
                    txtValue.Text = PromotionDAO.Instance.searchValuePromotion(str).Rows[0][0].ToString();
                }
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
            dt = PromotionDAO.Instance.searchCus(cboCus.SelectedValue.ToString());
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

            //if (cbcheckpoint.Checked==true)
            //{
            //    sumDes += Convert.ToInt32(txtPointCus.Text)*1000;
            //}


            sum = Convert.ToInt32(txtNumTicket.Text) * 90000;

            if (nudHSSV.Value != 0)
            {
                sumDes += Convert.ToInt32(nudHSSV.Value) * 18000;
            }
            if (txtValue.Text!="0")
            {
                sumDes += Convert.ToInt32(txtValue.Text) * 90000;
            }

            lbThanhTien.Text = "Thành tiền: " + sum.ToString() + " VNĐ ";
            lbTongGiam.Text = "Tổng giảm: " + sumDes.ToString() + " VNĐ";
            lbTongTra.Text = "Tổng trả: " + (sum - sumDes).ToString() + " VNĐ";
            

        }

        void CalcMoney()
        {
            sum = Convert.ToInt32(txtNumTicket.Text) * 90000;
            double txtval = 0;
            if (txtValue.Text != "0" || txtValue.Text !="")
            {
                txtval = Convert.ToDouble(txtValue.Text);
            }

            sumDes = Convert.ToInt32(nudHSSV.Value) * 18000 + Convert.ToInt32(nudPromotion.Value) * Convert.ToInt32(90000 * txtval);

            

            lbThanhTien.Text = "Thành tiền: " + sum.ToString() + " VNĐ ";
            lbTongGiam.Text = "Tổng giảm: " + sumDes.ToString() + " VNĐ";
            lbTongTra.Text = "Tổng trả: " + (sum - sumDes).ToString() + " VNĐ";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIDcus.ResetText();
            txtNameCus.ResetText();
            txtPointCus.ResetText();
            txtTypeCus.ResetText();
            
            
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            loadListPromotion();

            loadTicket();
            this.Close();
        }

        void loadTicket()
        {
            for (int i = 0; i < this.ListSeat.Count; i++)
            {
                string id_ticket = createAutoIdTicket();
                string id_seat = this.ListSeat[i].Id_seat;
                string id_promotion = this.listPromotion[i];
                string id_customer = "cu00";
                if (txtIDcus.Text != "")
                {
                    id_customer = this.txtIDcus.Text;
                }
                double valuePromotion = 0;
                if (id_promotion != "null")
                {
                    valuePromotion = Convert.ToDouble(PromotionDAO.Instance.searchValuePromotion(id_promotion).Rows[0][0]);

                    int total_cost = Convert.ToInt32(90000 * (1 - valuePromotion));
                    if (TicketDAO.Instance.createTicket(id_ticket, 90000, total_cost, this.Showtimes.Id_room, this.Showtimes.Id_movie, this.Showtimes.Id_shiftshow, this.Showtimes.Date_showtimes, this.ListSeat[i].Id_seat, id_customer, idEmployee, this.listPromotion[i]))
                    {
                        fShowTicket f = new fShowTicket(this.Showtimes, this.ListSeat[i], idEmployee, id_customer, id_promotion, "90000", (valuePromotion * 90000).ToString(), total_cost.ToString());
                        f.ShowDialog();
                    }
                }
                else
                {
                    
                    int total_cost = Convert.ToInt32(90000 * (1 - valuePromotion));
                    if (TicketDAO.Instance.createTicketWithoutPromotion(id_ticket, 90000, total_cost, this.Showtimes.Id_room, this.Showtimes.Id_movie, this.Showtimes.Id_shiftshow, this.Showtimes.Date_showtimes, this.ListSeat[i].Id_seat, id_customer, idEmployee))
                    {
                        fShowTicket f = new fShowTicket(this.Showtimes, this.ListSeat[i], idEmployee,  id_customer, "90000", total_cost.ToString());
                        f.ShowDialog();
                    }
                }
            }
            //Environment.Exit(1);
        }

        void loadListPromotion()
        {
            this.listPromotion = new List<string>();
            for (int i = 0; i < nudHSSV.Value; i++)
            {
                this.listPromotion.Add("pr02");
            }
            for (int j = 0; j < nudPromotion.Value; j++)
            {
                this.listPromotion.Add(cboPromotion.SelectedValue.ToString());
            }
            for (int k = 0; k < (this.listSeat.Count - nudHSSV.Value - nudPromotion.Value); k++)
            {
                this.listPromotion.Add("null");
            }
        }
        string createAutoIdTicket()
        {
            string lastID = TicketDAO.Instance.getLastIdTicket();
            //MessageBox.Show(lastID);
            int id = Convert.ToInt32(lastID[2].ToString() + lastID[3].ToString()) + 1;

            if (id < 10)
            {
                return "ti0" + id.ToString();
            }
            return "ti" + id.ToString();
        }

        private void cboPromotion_TextChanged(object sender, EventArgs e)
        {
            if(cboPromotion.Text ==  "")
            {
                txtValue.Text = "0";
            }    
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nudPromotion_ValueChanged(object sender, EventArgs e)
        {
            this.nudHSSV.Maximum = this.ListSeat.Count - this.nudPromotion.Value;
            CalcMoney();
        }

        private void nudHSSV_ValueChanged(object sender, EventArgs e)
        {
            this.nudPromotion.Maximum = this.ListSeat.Count - this.nudHSSV.Value;
            CalcMoney();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
