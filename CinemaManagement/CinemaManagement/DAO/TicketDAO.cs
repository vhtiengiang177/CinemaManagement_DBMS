using System;
using System.Collections.Generic;
using System.Data;
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

        public string getLastIdTicket()
        {
            string query = "select * from Ticket";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows[data.Rows.Count - 1][0].ToString();
        }
    }
}
