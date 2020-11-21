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
        private static PromotionDAO intance;
        public static PromotionDAO Intance
        {
            get { if (intance == null) intance = new PromotionDAO(); return PromotionDAO.intance; }
            private set { PromotionDAO.intance = value; }
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



    }
}
