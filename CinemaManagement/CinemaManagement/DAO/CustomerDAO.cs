using CinemaManagement.DTO;
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


        //cách viết 
        //viết câu query như bìnhthuongwf
        //return dataprovrder . instance (Thằng nào cũng v, hk cần khai báo, cứ gọi class.instance là ra) . execute(tùy loại) (query, new object[]{ các object, viết theo thứ tự của câu query}

        public bool AddCustomer(Customer cus)
        {
            string query = "exec sp_InsertCustomer @id_customer , @lname_customer , @fname_customer , @birthday_customer , @sex_customer , @identitycard_customer , @phone_customer , @email_customer , @address_customer , @point_customer , @id_typecustomer , @qr_customer ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { cus.Id_Customer, cus.Lname_Customer, cus.Fname_Customer, Convert.ToDateTime(cus.Birthday_Customer), cus.Sex_Customer, cus.Identitycard_Customer, cus.Phone_Customer, cus.Email_Customer, cus.Address_Customer, Convert.ToInt32(cus.Point_Customer), cus.Id_TypeCustomer, cus.Qr_Customer}) > 0;
        }


        public bool UpdateCustomer(Customer cus)
        {
            string query = "exec sp_UpdateCustomer @id_customer , @lname_customer , @fname_customer , @birthday_customer , @sex_customer , @identitycard_customer , @phone_customer , @email_customer , @address_customer , @point_customer , @id_typecustomer , @qr_customer ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { cus.Id_Customer, cus.Lname_Customer, cus.Fname_Customer, Convert.ToDateTime(cus.Birthday_Customer), cus.Sex_Customer, cus.Identitycard_Customer, cus.Phone_Customer, cus.Email_Customer, cus.Address_Customer, Convert.ToInt32(cus.Point_Customer), cus.Id_TypeCustomer, cus.Qr_Customer }) > 0;
        }

        public bool DeleteCustomer(Customer cus)
        {
            string query = "exec sp_DeleteCustomer @id ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { cus.Id_Customer }) > 0;
        }

        public DataTable LoadData()
        {
            string query = "select * from vLoadListCustomer";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchCustomer(string search)
        {
            string query = "select * from fu_SearchCustomer( @search )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { search });
        }
        

        public DataTable GetTypeCustomer()
        {
            string query = "select * from TypeCustomer";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetCustomerById(string id)
        {
            string query = "exec sp_findCustomerById @id ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id });
        }


        //hàm này dành cho load khách hàng bên đặt vé
        public DataTable loadCustomerforOrder()
        {
            string query = "select * from Customer";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
