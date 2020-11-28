using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DTO
{
    public class Seat
    {
        private string id_seat;

        private string name_seat;

        private string id_room;

        public string Id_seat { get => id_seat; set => id_seat = value; }
        public string Name_seat { get => name_seat; set => name_seat = value; }
        public string Id_room { get => id_room; set => id_room = value; }

        public Seat() { }

        public Seat(string id_se, string name_se, string id_ro)
        {
            this.Id_seat = id_se;
            this.Name_seat = name_se;
            this.Id_room = id_ro;
        }

        public Seat(DataRow row)
        {
            this.Id_seat = row["id_seat"].ToString();
            this.Name_seat = row["name_seat"].ToString();
            this.Id_room = row["id_room"].ToString();
        }
    }
}
