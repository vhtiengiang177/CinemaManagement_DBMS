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

        public fAddTicket()
        {
            InitializeComponent();
        }

        public fAddTicket(Showtimes st, string id_seat)
        {
            InitializeComponent();
        }
    }
}
