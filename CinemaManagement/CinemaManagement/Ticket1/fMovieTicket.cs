using CinemaManagement.DAO;
using CinemaManagement.DTO;
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

namespace CinemaManagement.Ticket1
{
    public partial class fMovieTicket : Form
    {
        public fMovieTicket()
        {
            InitializeComponent();
            LoadMovie();

        }

        void LoadMovie()
        {
            List<Movie> listMovie = MovieDAO.Instance.getListMovie();

            foreach(Movie item in listMovie)
            {
                Button btn = new Button() { Width = MovieDAO.MoiveWidth, Height = MovieDAO.MoiveHeight } ;

                try
                {
                    MemoryStream ms = new MemoryStream(item.Img_movie);
                    btn.Image = Image.FromStream(ms);

                }
                catch
                { }
                //btn.Text = item.Name_movie;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Microsoft Sans Serif", 18);
                btn.BackgroundImageLayout = ImageLayout.Stretch;

                btn.Tag = item;
                //MessageBox.Show(btn.Tag.GetType().ToString());
                btn.Click += btn_Click;

                flpMovie.Controls.Add(btn);

            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Movie mo = (Movie)((sender as Button).Tag);
            fShowtimesTicket f = new fShowtimesTicket(mo);
            this.Hide();
            f.Show();
        }
    }
}
