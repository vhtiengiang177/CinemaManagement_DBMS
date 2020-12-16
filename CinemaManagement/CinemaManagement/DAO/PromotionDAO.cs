using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CinemaManagement.DAO
{
    public class PromotionDAO
    {
        private static PromotionDAO instance;
        public static PromotionDAO Instance
        {
            get { if (instance == null) instance = new PromotionDAO(); return PromotionDAO.instance; }
            private set { PromotionDAO.instance = value; }
        }

        private PromotionDAO() { }


        public DataTable LoadData()
        {
            string query = "SELECT * FROM dbo.Promotion";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool addPromotion(string id, string name, string start, string end, string objects, double values)
        {
            string query = "exec sp_insertPromotion @id_promotion , @name_promotion , @starttime_promotion , @endtime_promotion , @object_promotion , @value_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,name, Convert.ToDateTime(start), Convert.ToDateTime(end), objects, Convert.ToDouble(values) }) > 0;
        }

        
        public bool updatePromotion(string id, string name, string start, string end, string objects, double values)
        {
            string query = "exec sp_updatePromotion @id_promotion , @name_promotion , @starttime_promotion , @endtime_promotion , @object_promotion , @value_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, Convert.ToDateTime(start), Convert.ToDateTime(end), objects, Convert.ToDouble(values) }) > 0;
        }

        public bool deletePromotion(string id)
        {
            string query = "exec sp_deletePromotion @id_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable searchPromotionbyname(string name)
        {
            string query = "SELECT *FROM dbo.fc_searchPromotionbyname( @namepromotion ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable searchPromotionbyobject(string name)
        {
            string query = "SELECT *FROM dbo.fc_searchPromotionbyobject( @nameobject ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable searchPromotionbyvalue(string value)
        {
            string query = "SELECT *FROM dbo.fc_searchPromotionbyvalue( @value ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDouble(value) });
        }

        ///Mấy hàm dưới này của form chọn ưu đãi
        //tìm giá tri khueysen mãi theo mã KM
        public DataTable searchValuePromotion(string id)
        {
            string query = "select*from  dbo.fc_SearchProInOrder( @id ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        //Tìm khách hàng theo số điện thoại
        public DataTable searchCus(string id)
        {
            string query = "select*from  dbo.fc_SearchCus( @id ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

       




    }
}
