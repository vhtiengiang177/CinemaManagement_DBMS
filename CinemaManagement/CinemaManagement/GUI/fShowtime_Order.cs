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
    public partial class fShowtime_Order : Form
    {
        private string sIdMovie;
        public string idMovie
        {
            get { return this.sIdMovie; }
            set { this.sIdMovie = value; }
        }
        public fShowtime_Order(string id_movie)
        {
            InitializeComponent();
            this.idMovie = id_movie;
        }
    }
}
