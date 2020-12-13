using CinemaManagement.DAO;
using CinemaManagement.DTO;
using CinemaManagement.Ticket1;
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
    public partial class fShowSeat_Order : Form
    {
        private List<Seat> listSeat = new List<Seat>();

        private Showtimes showtimes;
        public fShowSeat_Order()
        {
            InitializeComponent();
        }

        public fShowSeat_Order(Showtimes so)
        {
            InitializeComponent();
            this.Showtimes = so;
            loadSeat(this.Showtimes.Id_room);
        }
        public Showtimes Showtimes { get => showtimes; set => showtimes = value; }
        public List<Seat> ListSeat { get => listSeat; set => listSeat = value; }
        

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
