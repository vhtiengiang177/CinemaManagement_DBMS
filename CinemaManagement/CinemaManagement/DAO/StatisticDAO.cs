using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CinemaManagement.DAO
{
    public class StatisticDAO
    {
        private static StatisticDAO instance;
        public static StatisticDAO Instance
        {
            get { if (instance == null) instance = new StatisticDAO(); return StatisticDAO.instance; }
            private set { StatisticDAO.instance = value; }
        }

        private StatisticDAO() { }

        public DataTable loaddata()
        {
            string query = "exec sp_CalMoneyInMonth";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable countMovie()
        {
            string query = "select*from Movie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable loadAll()
        {
            string query = "select*from fc_CalTotalAll()";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable loadInMonth(int month)
        {
            string query = "select*from fc_CalTotalInMonth( @num )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { month });
        }

        public int deleteTicket()
        {
            string query = "delete from dbo.Ticket";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int deleteShowtimes()
        {
            string query = "delete from dbo.Showtimes";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }


        public DataTable loadOnCinema(string id)
        {
            string query = "select*from fc_countTotalOnCinemaAllMonth( @id )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }


        public DataTable loadOnCinemaInMonth(int num,string id)
        {
            string query = "select*from fc_countTotalOnCinemaInMonth( @num , @id )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { num,id });
        }



    }
}
