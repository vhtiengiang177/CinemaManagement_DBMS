using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaManagement.DAO
{
    class ShowtimesDAO
    {
        private static ShowtimesDAO intance;
        public static ShowtimesDAO Intance
        {
            get { if (intance == null) intance = new ShowtimesDAO(); return ShowtimesDAO.intance; }
            private set { ShowtimesDAO.intance = value; }
        }

        private ShowtimesDAO() { }

        public DataTable loadData()
        {
            string query = "SELECT * FROM dbo.ShowtimesView";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchShowtimes_namemovie(string name)
        {
            string query = "SELECT *FROM fc_SearchShowtimes_movie( @movie ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable countMovieInDay(string date)
        {
            string query = "SELECT*FROM dbo.fc_Count_MovieInDay( @date ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDateTime(date) });
        }

        public DataTable countShiftInDay(string number)
        {
            string query = "SELECT *FROM dbo.fc_CountShiftShow( @idShift ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { number });
        }

        public DataTable loadShiftShow()
        {
            string query = "SELECT *FROM dbo.ShiftShow ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable loadCategoryMovie()
        {
            string query = "SELECT *FROM dbo.CategoryMovie ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable loadMovie(string idcategory)
        {
            string query = "SELECT *FROM dbo.fc_loadMovie( @idCategory )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idcategory });
        }

    }
}
