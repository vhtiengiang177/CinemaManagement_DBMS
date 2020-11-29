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
    public partial class fAddTicket : Form
    {
        private Showtimes showtimes;
        private List<Seat> listseat;

        public fAddTicket()
        {
            InitializeComponent();
        }

        public fAddTicket(Showtimes st, List<Seat> se)
        {
            InitializeComponent();
            this.Showtimes = st;
            this.Listseat = se;
            Load();
            createAutoIdTicket();
        }

        public Showtimes Showtimes { get => showtimes; set => showtimes = value; }
        public List<Seat> Listseat { get => listseat; set => listseat = value; }

        void Load()
        {
            this.lbMovie.Text = this.Showtimes.Id_movie;
            this.lbDate.Text = this.Showtimes.Date_showtimes.ToString();
            this.lbRoom.Text = this.Showtimes.Id_room;
            this.lbShiftshow.Text = this.Showtimes.Starttime_shiftshow + " - " + this.Showtimes.Endtime_shiftshow;
            //this.lbSeat.Text = this.Seat.Name_seat;
            this.lbSeat.Text = "";
            foreach(Seat item in this.Listseat)
            {
                lbSeat.Text += item.Name_seat + " - ";
            }    
        }


        string createAutoIdTicket()
        {
            string lastID = TicketDAO.Instance.getLastIdTicket();
            //MessageBox.Show(lastID);
            int id = Convert.ToInt32(lastID[2].ToString() + lastID[3].ToString()) + 1;
            
            if(id<10)
            {
                return "ti0" + id.ToString();
            }
            return "ti" + id.ToString();
        }

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            foreach(Seat item in this.Listseat)
            {
                if(!TicketDAO.Instance.createTicket(createAutoIdTicket(), this.Showtimes.Id_room, this.Showtimes.Id_movie, this.Showtimes.Id_shiftshow, this.Showtimes.Date_showtimes, item.Id_seat))
                {
                    MessageBox.Show(item.Name_seat);
                }
                MessageBox.Show("Thanh Cong");
            }    
        }
    }
}
