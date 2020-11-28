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

namespace CinemaManagement.Ticket1
{
    public partial class fSeatTicket : Form
    {

        private Showtimes showtimes;
        public fSeatTicket()
        {
            InitializeComponent();
        }

        public fSeatTicket(Showtimes so)
        {
            InitializeComponent();
            this.Showtimes = so;
            loadSeat(this.Showtimes.Id_room);
        }
        public Showtimes Showtimes { get => showtimes; set => showtimes = value; }

        void loadSeat(string id_room)
        {
            List < Seat > list = SeatDAO.Instance.getListSeat(id_room);
            foreach(Seat item in list)
            {
                Button btn = new Button() { Width = 50, Height = 50 };
                btn.Tag = item;

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
            fAddTicket f = new fAddTicket();
            this.Hide();
            f.Show();
        }
    }
}
