using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CinemaManagement.DAO
{
    public class CinemaDAO
    {

        private static CinemaDAO instance;
        public static CinemaDAO Instance
        {
            get { if (instance == null) instance = new CinemaDAO(); return CinemaDAO.instance; }
            private set { CinemaDAO.instance = value; }
        }

        private CinemaDAO() { }

        public DataTable loadCinema()
        {
            string query = "SELECT * FROM dbo.Cinema";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool addCinema(string id, string name, string address, string city, string phone, string state)
        {
            string query = "exec sp_CinemaInsert @id_cinema , @name_cinema , @address_cinema , @city_cinema , @phone_cinema , @state_cinema ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, address, city,phone,state }) > 0;
        }

        public bool updateCinema(string id, string name, string address, string city, string phone, string state)
        {
            string query = "exec sp_CinemaUpdate @id_cinema , @name_cinema , @address_cinema , @city_cinema , @phone_cinema , @state_cinema ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, address, city, phone, state }) > 0;
        }


        
        public bool deleteCinema(string id)
        {
            string query = "exec sp_CinemeDelete @id_cinema ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }


        public DataTable searchCinema(string name)
        {
            string query = "select*from fc_searchCinema( @text )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }
    }
}
