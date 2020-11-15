using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{
    public class CategoryMovieDAO
    {
        public static CategoryMovieDAO instance;

        public CategoryMovieDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryMovieDAO();
                return instance;
            }
            set { instance = value; }
        }

        // Thêm thể loại
        public bool InsertCategoryMovie(CategoryMovie camo)
        {
            string query = "EXEC sp_InsertCategoryMovie @id_categorymovie, @name_categorymovie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { camo.Id_categorymovie, camo.Name_categorymovie }) > 0;
        }
    }
}
