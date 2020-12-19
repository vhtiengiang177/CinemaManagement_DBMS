using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CinemaManagement.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }

        private RoomDAO() { }

        public DataTable loadData()
        {
            string query = "SELECT * FROM dbo.Room where id_cinema= @";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable loadRoomOnCinema(string id)
        {
            string query = "select*from fc_chooseRoomOnCinema( @id )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }
        //select*from fc_chooseRoomOnCinema('ci01')
        //public DataTable countRoomInDay(string date,string idRoom,string idShift)
        //{
        //    string query = "SELECT *FROM fc_countRoomInDay( @date , @idRoom , @idShift ) ";
        //    return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDateTime(date) , idRoom , idShift}) ;
        //}

        public string getNameRoom(string id_room)
        {
            string query = "select name_room from Room where id_room = @id_room ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id_room }).Rows[0][0].ToString();
        }
    }
}
