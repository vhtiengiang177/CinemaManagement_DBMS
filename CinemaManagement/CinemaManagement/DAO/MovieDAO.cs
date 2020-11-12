using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
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

        // Thêm phim 
        public bool addMovie(Movie mo)
        {
            string query = "EXEC sp_InsertMovie @id_movie, @name_movie, @language_movie, @director_movie, @runningtime_movie, @releasedate_movie, @id_categorymovie, @poster_movie, @state_movie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { mo.Id_movie, mo.Name_movie, mo.Language_movie, mo.Director_movie, mo.Runningtime_movie, Convert.ToDateTime(mo.Releasedate_movie), mo.Id_categorymovie, mo.Poster_movie, mo.State_movie }) > 0;
        }
           
    }
}
