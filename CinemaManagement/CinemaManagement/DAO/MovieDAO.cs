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
        /// Thêm phim. 
        /// </summary>
        /// <param name="mo"></param>
        /// <returns></returns>
        public bool insertMovie(Movie mo)
        {
            string query = "EXEC sp_InsertMovie @id_movie, @name_movie, @language_movie, @director_movie, @runningtime_movie, @releasedate_movie, @id_categorymovie, @img_movie, @state_movie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mo.Id_movie, mo.Name_movie, mo.Language_movie, mo.Director_movie, mo.Runningtime_movie, Convert.ToDateTime(mo.Releasedate_movie), mo.Id_categorymovie, mo.Img_movie, mo.State_movie }) > 0;
        }

        /// <summary>
        /// Cập nhật phim.
        /// </summary>
        /// <param name="mo"></param>
        /// <returns></returns>
        public bool updateMovie(Movie mo)
        {
            string query = "EXEC sp_UpdateMovie @id_movie, @name_movie, @language_movie, @director_movie, @runningtime_movie, @releasedate_movie, @id_categorymovie, @img_movie, @state_movie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mo.Id_movie, mo.Name_movie, mo.Language_movie, mo.Director_movie, mo.Runningtime_movie, Convert.ToDateTime(mo.Releasedate_movie), mo.Id_categorymovie, mo.Img_movie, mo.State_movie }) > 0;
        }

        /// <summary>
        /// Xóa phim.
        /// </summary>
        /// <param name="mo"></param>
        /// <returns></returns>
        public bool deleteMovie(Movie mo)
        {
            string query = "EXEC sp_DeleteMovie @id_movie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mo.Id_movie }) > 0;
        }

        /// <summary>
        /// Tải tất cả dữ liệu.
        /// </summary>
        /// <returns></returns>
        public DataTable loadData()
        {
            string query = "SELECT * FROM v_LoadData";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        /// <summary>
        /// Tìm kiếm phim theo tên/đạo diễn
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchMovie(string search)
        {
            string query = "EXEC sp_SearchMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }

    }
}
