using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{
    public class ShowtimesDAO
    {
        private static ShowtimesDAO instance;

        public static ShowtimesDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShowtimesDAO();
                return instance;
            }
            set { instance = value; }
        }

        private ShowtimesDAO()
        {

        }

        public List<Showtimes> getListShowtimesByIdMovie(string idMovie)
        {
            List<Showtimes> listShowtimes = new List<Showtimes>();

            string query = "select date_showtimes, id_room, id_movie, Showtimes.id_shiftshow, starttime_shiftshow, endtime_shiftshow from Showtimes, ShiftShow where Showtimes.id_shiftshow = ShiftShow.id_shiftshow and id_movie = @id_movie ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idMovie });

            foreach(DataRow item in data.Rows)
            {
                Showtimes st = new Showtimes(item);
                listShowtimes.Add(st);
            }
            return listShowtimes;
        }


    }
}
