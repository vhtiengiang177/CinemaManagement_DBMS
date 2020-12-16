using CinemaManagement.DAO;
using CinemaManagement.DTO;
using CinemaManagement.Ticket1;
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
    public partial class fShowSeat_Order : Form
    {
        DataTable dt = new DataTable();

        MemoryStream ms;
        private Movie mo;
        public static string idEmployee;
        public static int typeEmployee;

        private List<Seat> listSeat = new List<Seat>();

        private Showtimes showtimes;
        public fShowSeat_Order()
        {
            InitializeComponent();
        }

        public fShowSeat_Order(int type, string idEmp)
        {
            InitializeComponent();
            fShowSeat_Order.idEmployee = idEmp;
            fShowSeat_Order.typeEmployee = type;
        }

        public fShowSeat_Order(Showtimes so)
        {
            InitializeComponent();
            this.Showtimes = so;
            loadSeat(this.Showtimes.Id_room);
            loadMovie();
           
        }
        public Showtimes Showtimes { get => showtimes; set => showtimes = value; }
        public List<Seat> ListSeat { get => listSeat; set => listSeat = value; }
        public Movie Mo { get => mo; set => mo = value; }

        public void loadMovie()
        {
            dt = MovieDAO.Instance.getMovieByID(this.Showtimes.Id_movie);
            // Lấy thông tin phim
            foreach (DataRow item in dt.Rows)
            {
                this.Mo = new Movie(item);
            }
            this.lblShowNameMovie.Text = dt.Rows[0][1].ToString();
            if (dt.Rows[0][7] != DBNull.Value)
                this.picImageMovie.Image = byteArrayToImage((byte[])dt.Rows[0][7]);
            this.lblShowDate_Showtime.Text = this.Showtimes.Date_showtimes.ToShortDateString();
            this.lblShowStarttime.Text = this.Showtimes.Starttime_shiftshow;
            this.lblShowNameRoom.Text = (String)ShowTimeOrderDAO.Instance.getNameRoomForShowTime(this.Showtimes.Id_room);
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            ms.Close();
            return returnImage;
        }

        void loadSeat(string id_room)
        {
            List < Seat > list = SeatDAO.Instance.getListSeat(id_room);
            foreach(Seat item in list)
            {
                Button btn = new Button() { Width = 50, Height = 50 };
                btn.Tag = item;
                btn.BackColor = Color.Gray;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                if(SeatDAO.Instance.CheckTicket(this.Showtimes, item.Id_seat))
                {
                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }

                btn.Click += Btn_Click;

                btn.Text = item.Name_seat;

                flpSeatTicket.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //Seat se = (Seat)((sender as Button).Tag);
            //fAddTicket f = new fAddTicket(this.Showtimes, se);
            //this.Hide();
            //f.Show();

            if((sender as Button).BackColor == Color.Gray)
            {
                (sender as Button).BackColor = Color.Green;
                this.ListSeat.Add(((Seat)(sender as Button).Tag));
            }    
            else
            {
                if((sender as Button).BackColor==Color.Green)
                {
                    (sender as Button).BackColor = Color.Gray;
                    this.ListSeat.Remove((Seat)(sender as Button).Tag);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            fShowPromotion_Order f = new fShowPromotion_Order(this.Showtimes, this.ListSeat);
            //this.Hide();
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

 



        //void subtractSeat(string id)
        //{
        //    for(int i=0; i<this.ListSeat.Count; i++)
        //    {
        //        if(ListSeat[i].Id_seat == id)
        //        {
        //            this.ListSeat.Remove()
        //            for(int j = i; j<this.ListSeat.Count; j++)
        //            {
        //                ListSeat[j] = ListSeat[j + 1];
        //            }
        //            break;
        //        }    
        //    }
        //}
    }
}
