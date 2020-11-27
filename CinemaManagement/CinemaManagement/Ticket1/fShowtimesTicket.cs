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
    public partial class fShowtimesTicket : Form
    {
        private Movie movie;
        public fShowtimesTicket()
        {
            InitializeComponent();
        }

        public fShowtimesTicket(Movie mo)
        {
            InitializeComponent();
            this.lbTenPhim.Text = mo.Name_movie;
            this.Movie = mo;
            LoadShowtimes(this.Movie.Id_movie);
        }

        public Movie Movie { get => movie; set => movie = value; }

        void LoadShowtimes(string idMovie)
        {
            List<Showtimes> list = ShowtimesDAO.Instance.getListShowtimesByIdMovie(idMovie);

            foreach(Showtimes item in list)
            {
                Button btn = new Button() { Width = 200, Height = 200 };
                btn.Text = item.Date_showtimes.ToString() + Environment.NewLine + item.Starttime_shiftshow + " - " + item.Endtime_shiftshow;
                btn.Tag = item;

                btn.Click += Btn_Click;

                flpShowtimesTicket.Controls.Add(btn);
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Showtimes st = (Showtimes)((sender as Button).Tag);
            fSeatTicket f = new fSeatTicket(st);
            this.Hide();
            f.Show();
        }
    }
}
