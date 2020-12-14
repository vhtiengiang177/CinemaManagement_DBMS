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

        public bool createTicket(string id_ticket, int cost_ticket, int totalcost_ticket, string id_room, string id_movie, string id_shiftshow, DateTime date_showtimes, string id_seat, string id_customer, string id_employee, string id_promotion)
        {
            string query = " exec sp_InsertTicket @id_ticket , @cost_ticket , @totalcost_ticket , @id_room , @id_movie , @id_shiftshow , @date_showtimes , @id_seat , @id_customer , @id_employee , @id_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_ticket, cost_ticket, totalcost_ticket, id_room, id_movie, id_shiftshow, date_showtimes, id_seat, id_customer, id_employee, id_promotion}) > 0;
        }

        public bool createTicketWithoutPromotion(string id_ticket, int cost_ticket, int totalcost_ticket, string id_room, string id_movie, string id_shiftshow, DateTime date_showtimes, string id_seat, string id_customer, string id_employee)
        {
            string query = " exec sp_InsertTicket_Without_Promotion @id_ticket , @cost_ticket , @totalcost_ticket , @id_room , @id_movie , @id_shiftshow , @date_showtimes , @id_seat , @id_customer , @id_employee  ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_ticket, cost_ticket, totalcost_ticket, id_room, id_movie, id_shiftshow, date_showtimes, id_seat, id_customer, id_employee }) > 0;
        }

        public string getLastIdTicket()
        {
            string query = "select * from Ticket";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows[data.Rows.Count - 1][0].ToString();
        }

    }
}
