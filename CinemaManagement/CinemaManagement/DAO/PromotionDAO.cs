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

        public bool AddPromotion(string id, string name, string start, string end, string objects, double values)
        {
            string query = "exec sp_Promotion_Insert @id_promotion , @name_promotion , @starttime_promotion , @endtime_promotion , @object_promotion , @value_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,name, Convert.ToDateTime(start), Convert.ToDateTime(end), objects, Convert.ToDouble(values) }) > 0;
        }

        
        public bool UpdatePromotion(string id, string name, string start, string end, string objects, double values)
        {
            string query = "exec sp_Promotion_Update @id_promotion , @name_promotion , @starttime_promotion , @endtime_promotion , @object_promotion , @value_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, Convert.ToDateTime(start), Convert.ToDateTime(end), objects, Convert.ToDouble(values) }) > 0;
        }

        public bool DeletePromotion(string id)
        {
            string query = "exec sp_Promotion_Delete @id_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }

        public DataTable SearchPromotion_name(string name)
        {
            string query = "SELECT *FROM dbo.fc_SearchPromotion_name( @namepromotion ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable SearchPromotion_object(string name)
        {
            string query = "SELECT *FROM dbo.fc_SearchPromotion_object( @nameobject ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
        }

        public DataTable SearchPromotion_value(string value)
        {
            string query = "SELECT *FROM dbo.fc_SearchPromotion_value( @value ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDouble(value) });
        }

        ///Mấy hàm dưới này của form chọn ưu đãi
        //tìm giá tri khueysen mãi theo mã KM
        public DataTable SearchValue_Promotion(string id)
        {
            string query = "select*from  dbo.fc_SearchProInOrder( @id ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

        //Tìm khách hàng theo số điện thoại
        public DataTable SearchCus(string id)
        {
            string query = "select*from  dbo.fc_SearchCus( @id ) ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }

       
        public string getNamePromotion(string id)
        {
            string query = "select name_promotion from Promotion where id_promotion = @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id }).Rows[0][0].ToString();
        }



    }
}
