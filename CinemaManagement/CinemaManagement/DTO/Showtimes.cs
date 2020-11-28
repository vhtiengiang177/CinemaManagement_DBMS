using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DTO
{
    public class Showtimes
    {
        private DateTime date_showtimes;

        private string id_room;

        private string id_movie;

        private string starttime_shiftshow;

        private string endtime_shiftshow;

        private string id_shiftshow;

        public DateTime Date_showtimes { get => date_showtimes; set => date_showtimes = value; }
        public string Id_room { get => id_room; set => id_room = value; }
        public string Id_movie { get => id_movie; set => id_movie = value; }
        public string Starttime_shiftshow { get => starttime_shiftshow; set => starttime_shiftshow = value; }
        public string Endtime_shiftshow { get => endtime_shiftshow; set => endtime_shiftshow = value; }
        public string Id_shiftshow { get => id_shiftshow; set => id_shiftshow = value; }

        public Showtimes() { }

        public Showtimes(DateTime date, string id_room, string id_movie, string id_shiftshow, string starttime_shiftshow, string endtime_shiftshow)
        {
            this.Date_showtimes = date;
            this.Id_room = id_room;
            this.Id_movie = id_movie;
            this.Id_shiftshow = id_shiftshow;
            this.Starttime_shiftshow = starttime_shiftshow;
            this.Endtime_shiftshow = endtime_shiftshow;
        }

        public Showtimes(DataRow row)
        {
            this.Date_showtimes = Convert.ToDateTime(row["date_showtimes"]);
            this.Id_room = row["id_room"].ToString();
            this.Id_movie = row["id_movie"].ToString();
            this.Id_shiftshow = row["id_shiftshow"].ToString();
            this.Starttime_shiftshow = row["starttime_shiftshow"].ToString();
            this.Endtime_shiftshow = row["endtime_shiftshow"].ToString();
        }
    }


}
