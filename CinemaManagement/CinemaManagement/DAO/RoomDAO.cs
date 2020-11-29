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
            string query = "SELECT * FROM dbo.Room";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable countRoomInDay(string date,string idRoom,string idShift)
        {
            string query = "SELECT *FROM fc_countRoomInDay( @date , @idRoom , @idShift ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDateTime(date) , idRoom , idShift}) ;
        }
    }
}
