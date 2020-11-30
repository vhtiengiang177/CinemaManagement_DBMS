using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaManagement.DTO;


namespace CinemaManagement.DAO
{
    class ShowtimesDAO
    {
        private static ShowtimesDAO instance;
        public static ShowtimesDAO Instance
        {
            get { if (instance == null) instance = new ShowtimesDAO(); return ShowtimesDAO.instance; }
            private set { ShowtimesDAO.instance = value; }
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

        public DataTable countShiftInDay(string idShift,string date)
        {
            string query = "SELECT *FROM dbo.fc_CountShiftShowInDay( @idShift , @date ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idShift,Convert.ToDateTime(date) });
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

        //Thêm lịch chiếu
        public bool addShowtimes(string date,string idRoom, string idMovie,string idShift)
        {
            string query = "exec sp_Showtimes_Insert  @date , @idRoom , @idMovie , @idShift ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {  Convert.ToDateTime(date),idRoom,idMovie,idShift }) > 0;
        }

        //Kiểm tra trùng phim
        public DataTable checkMovie(string date, string idShift ,  string idRoom)
        {
            string query = "select*from fc_checkMovie( @date , @idRoom , @idShift )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDateTime(date), idShift, idRoom }) ;
        }

        public List<Showtimes> getListShowtimesByIdMovie(string idMovie)
        {
            List<Showtimes> listShowtimes = new List<Showtimes>();

            string query = "select date_showtimes, id_room, id_movie, Shiftshow.id_shiftshow, starttime_shiftshow, endtime_shiftshow from Showtimes, ShiftShow where Showtimes.id_shiftshow = ShiftShow.id_shiftshow and id_movie = @id_movie ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idMovie });

            foreach (DataRow item in data.Rows)
            {
                Showtimes st = new Showtimes(item);
                listShowtimes.Add(st);
            }
            return listShowtimes;
        }
    }
}
