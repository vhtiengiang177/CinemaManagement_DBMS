using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{
    public class SeatDAO
    {
        private static SeatDAO instance;

        public static SeatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SeatDAO();
                return instance;
            }
            set { instance = value; }
        }

        private SeatDAO()
        {

        }

        public List<Seat> getListSeat(string id_room)
        {
            List<Seat> list = new List<Seat>();

            string query = "select * from Seat, Room where Seat.id_room = Room.id_room and Room.id_room = @id_room ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id_room });

            foreach(DataRow row in data.Rows)
            {
                Seat se = new Seat(row);
                list.Add(se);
            }    


            return list;
        }


        public bool CheckTicket(Showtimes st, string id_seat)
        {
            string query = "select * from Ticket where Ticket.id_room = @id_room and Ticket.id_movie = @id_movie and Ticket.id_shiftshow = @id_shiftshow and Ticket.date_showtimes = @date_showtimes and Ticket.id_seat = @id_seat ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { st.Id_room, st.Id_movie, st.Id_shiftshow, st.Date_showtimes, id_seat }).Rows.Count > 0;
        }
    }
}
