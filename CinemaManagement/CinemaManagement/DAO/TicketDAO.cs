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

        public bool createTicket(string id_ticket, string id_room, string id_movie, string id_shiftshow, DateTime date_showtimes, string id_seat)
        {
            string query = " insert into Ticket(id_ticket, cost_ticket, totalcost_ticket, id_room, id_movie, id_shiftshow, date_showtimes, id_seat, id_customer, id_employee, id_promotion) values( @id_ticket , 100, 100, @id_room , @id_movie , @id_shiftshow , @date_showtimes , @id_seat , 'cu01', 'em01', null)";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_ticket, id_room, id_movie, id_shiftshow, date_showtimes, id_seat}) > 0;
        }

        public string getLastIdTicket()
        {
            string query = "select * from Ticket";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows[data.Rows.Count - 1][0].ToString();
        }
    }
}
