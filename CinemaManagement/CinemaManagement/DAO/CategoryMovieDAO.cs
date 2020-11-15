using CinemaManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// Thêm thể loại.
        /// </summary>
        /// <param name="camo"></param>
        /// <returns></returns>
        public bool InsertCategoryMovie(CategoryMovie camo)
        {
            string query = "EXEC sp_InsertCategoryMovie @id_categorymovie, @name_categorymovie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { camo.Id_categorymovie, camo.Name_categorymovie }) > 0;
        }

        /// <summary>
        /// Cập nhật thể loại.
        /// </summary>
        /// <param name="camo"></param>
        /// <returns></returns>
        public bool UpdateCategoryMovie(CategoryMovie camo)
        {
            string query = "EXEC sp_UpdateCategoryMovie @id_categorymovie, @name_categorymovie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { camo.Id_categorymovie, camo.Name_categorymovie }) > 0;
        }

        /// <summary>
        /// Xóa thể loại phim
        /// </summary>
        /// <param name="camo"></param>
        /// <returns></returns>
        public bool DeleteCategoryMovie(CategoryMovie camo)
        {
            string query = "EXEC sp_DeleteCategoryMovie @id_categorymovie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { camo.Id_categorymovie, camo.Name_categorymovie }) > 0;
        }

        /// <summary>
        /// Tải dữ liệu bảng thể loại phim
        /// </summary>
        /// <returns></returns>
        public DataTable LoadData()
        {
            string query = "SELECT * FROM CategoryMovie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        /// <summary>
        /// Tìm kiếm thể loại theo tên
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable SearchCategoryMovie(string search)
        {
            string query = "EXEC sp_SearchNameCategoryMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }
    }
}
