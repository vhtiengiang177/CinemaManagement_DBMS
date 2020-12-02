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

        //lấy ds lịch chiếu
        public DataTable loadData()
        {
            string query = "SELECT * FROM dbo.fc_loadshowtimes()";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //public DataTable loaddata()
        //{
        //    string query = "SELECT * FROM dbo.ShowtimesView";
        //    return DataProvider.Instance.ExecuteQuery(query);
        //}

        //tìm lịch chiếu theo tên phim
        public DataTable SearchShowtimes_namemovie(string name)
        {
            string query = "SELECT *FROM fc_SearchShowtimes_movie1( @movie ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        //đếm số lượng lich phim dã chiếu trong ngày đc chọn
        public DataTable countMovieInDay(string date)
        {
            string query = "SELECT*FROM dbo.fc_Count_MovieInDay( @date ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDateTime(date) });
        }

        //đém số lượng ca chiếu đã đc chọn trong ngày
        public DataTable countShiftInDay(string idShift,string date)
        {
            string query = "SELECT *FROM dbo.fc_CountShiftShowInDay( @idShift , @date ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idShift,Convert.ToDateTime(date) });
        }

        //lấy ds ca chiếu
        public DataTable loadShiftShow()
        {
            string query = "SELECT *FROM dbo.ShiftShow ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //lấy ds thể loại phim
        public DataTable loadCategoryMovie()
        {
            string query = "SELECT *FROM dbo.CategoryMovie ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //lấy ds phim theo thể loại
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

        //Kiểm tra phim đó đã được xếp lịch vào ngày, ca, phòng đó chưa
        public DataTable checkMovie(string date, string idShift ,  string idRoom)
        {
            string query = "select*from fc_checkMovie( @date , @idRoom , @idShift )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDateTime(date), idShift, idRoom }) ;
        }

        //kiểm tra 2 phim chiếu cùng 1 thời điểm không, mỗi phim chỉ dc chiếu ở 1 phòng cùng thời điểm
        public DataTable checkMovieandRoom(string date, string idShift, string idMovie)
        {
            string query = "select*from fc_checkMovieAndRoom( @date , @idroom , @idmovie )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDateTime(date), idShift, idMovie });
        }

        public bool DeleteSS(string date, string idss,string idroom,string idmovie)
        {
            string query = "exec sp_deleteSS @date , @idshift , @idroom , @idmovie ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { Convert.ToDateTime(date), idss, idroom,idmovie }) > 0;
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
