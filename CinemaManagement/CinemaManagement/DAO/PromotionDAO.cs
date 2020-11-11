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

        public bool AddPromotion(string id, string name, DateTime start, DateTime end, string objects, double values)
        {
            string query = "exec sp_Promotion_Insert @id_promtion , @name_promotion , @starttime_promotion , @endtime_promotion , @object_promotion , @value_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,name, Convert.ToDateTime(start), Convert.ToDateTime(end), objects, Convert.ToDouble(values) }) > 0;
        }

        
        public bool UpdatePromotion(string id, string name, DateTime start, DateTime end, string objects, double values)
        {
            string query = "exec sp_UpdateCustomer @id_promtion , @name_promotion , @starttime_promotion , @endtime_promotion , @object_promotion , @value_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, Convert.ToDateTime(start), Convert.ToDateTime(end), objects, Convert.ToDouble(values) }) > 0;
        }

        public bool DeletePromotion(string id)
        {
            string query = "exec sp_DeletePromotion @id_promotion ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0;
        }
    }
}
