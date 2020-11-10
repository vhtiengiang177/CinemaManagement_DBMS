using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }

        private CustomerDAO()
        {

        }

        public bool AddCustomer(string id_Customer, string name_Customer, string phone_Customer, string birthday_Customer, string address_Customer, string email_Customer, string point_Customer, string id_Typecustomer)
        {
            string query = "exec sp_InsertCustomer @id , @name , @birthday , @phone , @email , @address , @point , @type ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_Customer, name_Customer, Convert.ToDateTime(birthday_Customer), phone_Customer, email_Customer, address_Customer, Convert.ToInt32(point_Customer), id_Typecustomer }) > 0;
        }


        public bool UpdateCustomer(string id_Customer, string name_Customer, string phone_Customer, string birthday_Customer, string address_Customer, string email_Customer, string point_Customer, string id_Typecustomer)
        {
            string query = "exec sp_UpdateCustomer @id , @name , @birthday , @phone , @email , @address , @point , @type ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_Customer, name_Customer, Convert.ToDateTime(birthday_Customer), phone_Customer, email_Customer, address_Customer, Convert.ToInt32(point_Customer), id_Typecustomer }) > 0;
        }

        public bool DeleteCustomer(string id_Customer)
        {
            string query = "exec sp_DeleteCustomer @id";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id_Customer }) > 0;
        }

        public DataTable LoadData()
        {
            string query = "select * from customer";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchCustomer(string search)
        {
            string query = "select * from fu_SearchCustomer('% @search %')";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }
    }
}
