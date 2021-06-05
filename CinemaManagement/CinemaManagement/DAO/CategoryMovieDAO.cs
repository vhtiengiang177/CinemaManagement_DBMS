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
        private static CategoryMovieDAO instance;

        public static CategoryMovieDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryMovieDAO();
                return instance;
            }
            set { instance = value; }
        }

        private CategoryMovieDAO()
        {

        }

        /// <summary>
        /// Tải dữ liệu bảng thể loại phim
        /// </summary>
        /// <returns></returns>
        public DataTable loadData()
        {
            string query = "SELECT * FROM v_LoadDataCategoryMovie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable loadDataCategoryMovie()
        {
            string query = "SELECT * FROM CategoryMovie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        /// <summary>
        /// Sinh ID cho thể loại phim
        /// </summary>
        /// <returns></returns>
        public object createIDCategoryMovie()
        {
            string query = "SELECT dbo.f_CreateIDCategoryMovie()";
            return DataProvider.Instance.ExecuteScalar(query);
        }

        /// <summary>
        /// Lấy thông tin 1 thể loại
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable getCategoryMovie(string id)
        {
            string query = "EXEC sp_GetCategoryMovie @id";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        /// <summary>
        /// Thêm thể loại.
        /// </summary>
        /// <param name="camo"></param>
        /// <returns></returns>
        public bool insertCategoryMovie(CategoryMovie camo)
        {
            string query = "EXEC sp_InsertCategoryMovie @id_categorymovie , @name_categorymovie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { camo.Id_categorymovie, camo.Name_categorymovie }) > 0;
        }

        /// <summary>
        /// Cập nhật thể loại.
        /// </summary>
        /// <param name="camo"></param>
        /// <returns></returns>
        public bool updateCategoryMovie(CategoryMovie camo)
        {
            string query = "EXEC sp_UpdateCategoryMovie @id_categorymovie , @name_categorymovie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { camo.Id_categorymovie, camo.Name_categorymovie }) > 0;
        }

        /// <summary>
        /// Xóa thể loại phim
        /// </summary>
        /// <param name="camo"></param>
        /// <returns></returns>
        public bool deleteCategoryMovie(string id_camo)
        {
            string query = "EXEC sp_DeleteCategoryMovie @id_categorymovie";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_camo }) > 0;
        }
        
        /// <summary>
        /// Tìm kiếm thể loại theo tên
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchNameCategoryMovie(string search)
        {
            string query = "EXEC sp_SearchNameCategoryMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }

        /// <summary>
        /// Tìm kiếm thể loại theo mã thể loại
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        public DataTable searchIDCategoryMovie(string search)
        {
            string query = "EXEC sp_SearchIDCategoryMovie @search";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }
    }
}
