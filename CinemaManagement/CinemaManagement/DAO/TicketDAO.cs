using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{
    public class TicketDAO
    {


        private static TicketDAO instance;

        public static TicketDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TicketDAO();
                return instance;
            }
            set { instance = value; }
        }

        private TicketDAO()
        {

        }

        public void createTicket()
        {
            
        }
    }
}
