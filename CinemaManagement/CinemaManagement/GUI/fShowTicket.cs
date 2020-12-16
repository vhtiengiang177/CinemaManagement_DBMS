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
    public partial class fShowTicket : Form
    {
        private Showtimes showtime;
        private Seat seat;

        public Showtimes Showtime { get => showtime; set => showtime = value; }
        public Seat Seat { get => seat; set => seat = value; }

        public fShowTicket(Showtimes st, Seat se, string cu,string promotion, string cost, string discount, string totalcost)
        {
            
            InitializeComponent();
            LoadInit();
            this.Showtime = st;
            this.Seat = se;
            string nameMovie = MovieDAO.Instance.getMovieByID(this.Showtime.Id_movie).Rows[0][1].ToString();
            string nameRoom = RoomDAO.Instance.getNameRoom(this.Showtime.Id_room).ToString();
            string nameCustomer = "";
            if (cu != "cu00" )
            {
                nameCustomer = CustomerDAO.Instance.getNameCustomerByID(cu);
            }
            string promotionShow = "";
            if (promotion != "null")
                promotionShow = PromotionDAO.Instance.getNamePromotion(promotion);
            LoadData("CGV Thủ Đức", this.Showtime.Date_showtimes.ToShortDateString(), nameMovie, this.Showtime.Starttime_shiftshow, this.Showtime.Endtime_shiftshow, nameRoom, this.Seat.Name_seat, nameCustomer, cost, promotionShow, discount, totalcost);
        }

        public fShowTicket(Showtimes st, Seat se, string idEmp, string cu, string promotion, string cost, string discount, string totalcost)
        {

            InitializeComponent();
            LoadInit();
            this.Showtime = st;
            this.Seat = se;
            string nameMovie = MovieDAO.Instance.getMovieByID(this.Showtime.Id_movie).Rows[0][1].ToString();
            string nameRoom = RoomDAO.Instance.getNameRoom(this.Showtime.Id_room).ToString();
            string nameCustomer = CustomerDAO.Instance.getNameCustomerByID(cu);
            string promotionShow = "";
            if (promotion != "null")
                promotionShow = PromotionDAO.Instance.getNamePromotion(promotion);
            LoadData("CGV Thủ Đức", this.Showtime.Date_showtimes.ToShortDateString(), nameMovie, this.Showtime.Starttime_shiftshow, this.Showtime.Endtime_shiftshow, nameRoom, this.Seat.Name_seat, nameCustomer, cost, promotionShow, discount, totalcost);
        }

        public fShowTicket(Showtimes st, Seat se, string cu, string cost, string totalcost)
        {

            InitializeComponent();
            LoadInit();
            this.Showtime = st;
            this.Seat = se;
            string nameMovie = MovieDAO.Instance.getMovieByID(this.Showtime.Id_movie).Rows[0][1].ToString();
            string nameRoom = RoomDAO.Instance.getNameRoom(this.Showtime.Id_room).ToString();
            string nameCustomer = "";
            if (cu != "cu00")
            {
                nameCustomer = CustomerDAO.Instance.getNameCustomerByID(cu);
            }
            LoadData("CGV Thủ Đức", this.Showtime.Date_showtimes.ToShortDateString(), nameMovie, this.Showtime.Starttime_shiftshow, this.Showtime.Endtime_shiftshow, nameRoom, this.Seat.Name_seat, nameCustomer, cost, "", 0.ToString(), totalcost);
        }

        public fShowTicket(Showtimes st, Seat se, string idEmp, string cu, string cost, string totalcost)
        {

            InitializeComponent();
            LoadInit();
            this.Showtime = st;
            this.Seat = se;
            string nameMovie = MovieDAO.Instance.getMovieByID(this.Showtime.Id_movie).Rows[0][1].ToString();
            string nameRoom = RoomDAO.Instance.getNameRoom(this.Showtime.Id_room).ToString();
            string nameCustomer = "";
            if (cu != "cu00")
            {
                nameCustomer = CustomerDAO.Instance.getNameCustomerByID(cu);
            }
            LoadData("CGV Thủ Đức", this.Showtime.Date_showtimes.ToShortDateString(), nameMovie, this.Showtime.Starttime_shiftshow, this.Showtime.Endtime_shiftshow, nameRoom, this.Seat.Name_seat, nameCustomer, cost, "", 0.ToString(), totalcost);
        }

        void LoadInit()
        {
            this.lbCinema.Text = "";
            this.lbCost.Text = "";
            this.lbCustomer.Text = "";
            this.lbDate.Text = "";
            this.lbDiscount.Text = "";
            this.lbEndtime.Text = "";
            this.lbMovie.Text = "";
            this.lbPromotion.Text = "";
            this.lbRoom.Text = "";
            this.lbSeat.Text = "";
            this.lbStarttime.Text = "";
            this.lbTotalcost.Text = "";
        }

        void LoadData(string cinema, string date, string movie, string starttime, string endtime, string room, string seat, string customer, string cost, string promotion, string discount, string totalcost)
        {
            this.lbCinema.Text= cinema;
            this.lbDate.Text = date;
            this.lbMovie.Text = movie;
            this.lbStarttime.Text = starttime;
            this.lbEndtime.Text = endtime;
            this.lbRoom.Text = room;
            this.lbSeat.Text = seat;
            this.lbCustomer.Text = customer;
            this.lbCost.Text = cost;
            this.lbPromotion.Text = promotion;
            this.lbDiscount.Text = discount;
            this.lbTotalcost.Text = totalcost;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
