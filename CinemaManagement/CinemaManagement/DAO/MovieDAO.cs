using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{
    public class MovieDAO
    {
        public static int MoiveWidth = 80;
        public static int MoiveHeight = 200;


        private static MovieDAO instance;

        public static MovieDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MovieDAO();
                return instance;
            }
            set { instance = value; }
        }

        private MovieDAO()
        {

        }

        /// <summary>
        /// Tải tất cả dữ liệu. Sử dụng View dưới dtb để hiển thị
        /// </summary>
        /// <returns></returns>
        public DataTable loadData()
        {
            string query = "SELECT * FROM v_LoadDataMovie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable showMovieActive()
        {
            string query = "SELECT * FROM v_ShowMovieActive";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        /// <summary>
        /// Sinh ID mới cho phim
        /// </summary>
        /// <returns></returns>
        public object createIDMovie()
        {
            string query = "SELECT dbo.f_CreateIDMovie()";
            return DataProvider.Instance.ExecuteScalar(query);
        }

        /// <summary>
        /// Lấy thông tin 1 phim (phần thể loại lấy tên, không lấy id)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable getMovie(string id)
        {
            string query = "EXEC sp_GetMovie @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        public DataTable getMovieByID(string id)
        {
            string query = "EXEC sp_GetMovieByID @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        /// <summary>
        /// Thêm phim. 
        /// </summary>
        /// <param name="mo"></param>
        /// <returns></returns>
        public bool insertMovie(Movie mo)
        {
            string query = "EXEC sp_InsertMovie @id_movie , @name_movie , @language_movie , @director_movie , @runningtime_movie , @releasedate_movie , @id_categorymovie , @img_movie , @state_movie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mo.Id_movie, mo.Name_movie, mo.Language_movie, mo.Director_movie, mo.Runningtime_movie, Convert.ToDateTime(mo.Releasedate_movie), mo.Id_categorymovie, mo.Img_movie, mo.State_movie }) > 0;
        }

        /// <summary>
        /// Cập nhật phim.
        /// </summary>
        /// <param name="mo"></param>
        /// <returns></returns>
        public bool updateMovie(Movie mo)
        {
            string query = "EXEC sp_UpdateMovie @id_movie , @name_movie , @language_movie , @director_movie , @runningtime_movie , @releasedate_movie , @id_categorymovie , @img_movie , @state_movie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mo.Id_movie, mo.Name_movie, mo.Language_movie, mo.Director_movie, mo.Runningtime_movie, Convert.ToDateTime(mo.Releasedate_movie), mo.Id_categorymovie, mo.Img_movie, mo.State_movie }) > 0;
        }

        /// <summary>
        /// Xóa phim.
        /// </summary>
        /// <param name="mo"></param>
        /// <returns></returns>
        public bool deleteMovie(string id_movie)
        {
            string query = "EXEC sp_DeleteMovie @id_movie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_movie }) > 0;
        }

        /// <summary>
        /// Tìm kiếm phim theo ID
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchIDMovie(string search)
        {
            string query = "EXEC sp_SearchIDMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }

        /// <summary>
        /// Tìm kiếm phim theo tên
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchNameMovie(string search)
        {
            string query = "EXEC sp_SearchNameMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }

        /// <summary>
        /// Tìm kiếm phim theo đạo diễn
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchDirectorMovie(string search)
        {
            string query = "EXEC sp_SearchDirectorMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }

        /// <summary>
        /// Tìm kiếm phim theo tên thể loại
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchNameCamoMovie(string search)
        {
            string query = "EXEC sp_SearchNameCamoMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }

        /// <summary>
        /// Tìm kiếm phim theo thời lượng
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchRunningTimeMovie(string search)
        {
            string query = "EXEC sp_SearchRunningTimeMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }

        /// <summary>
        /// Tìm kiếm phim theo ngôn ngữ
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchLanguageMovie(string search)
        {
            string query = "EXEC sp_SearchLanguageMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }

        /// <summary>
        /// Tìm kiếm phim theo phim đang hoạt động
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchActiveStateMovie()
        {
            string query = "EXEC sp_SearchActiveStateMovie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        /// <summary>
        /// Tìm kiếm phim theo phim ngưng hoạt động
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchInactiveMovie()
        {
            string query = "EXEC sp_SearchInactiveMovie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Movie> getListMovie()
        {
            List<Movie> listMovie = new List<Movie>();

            string query = "SELECT * FROM Movie";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Movie movie = new Movie(item);
                listMovie.Add(movie);
            }

            return listMovie;
        }

        public DataTable loadCategory()
        {
            string query = "SELECT * FROM dbo.CategoryMovie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
