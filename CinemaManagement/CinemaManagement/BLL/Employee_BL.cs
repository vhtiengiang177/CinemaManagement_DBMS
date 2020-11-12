using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CinemaManagement.DAO;
using CinemaManagement.DTO;
namespace CinemaManagement.BLL
{

    public class Employee_BL
    {
        private static Employee_BL instance;
        public static Employee_BL Instance
        {
            get { if (instance == null) instance = new Employee_BL();
                return Employee_BL.instance;
            }

            private set { Employee_BL.instance = value; }
        }



        private Employee_BL()
        { }

        public DataTable LoadData()
        {
            string query = "exec sp_showEmployee";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        /// <summary>
        /// Chỉnh sửa thông tin nhân viên
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int EditInfoEmployee(Employee emp)
        {
            string query = "exec sp_updateInforEmployee @id_employee , @name_employee , @birthday_employee , @sex_employee , @identitycard_employee , @phone_employee , @email_employee , @address_employee , @salary_employee , @id_typeemployee , @id_cinema , @img_employee ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { emp.Id_employee, emp.Name_employee,
                emp.Birthday_employee, emp.Sex_employeeloyee, emp.Identitycard_employee, emp.Phone_employee,
                emp.Email_employee, emp.Address_employee, emp.Salary_employee, emp.Id_typeemployee, emp.Id_cinema, emp.Img_employee});

        }


        /// <summary>
        /// Xóa nhân viên theo mã
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool deleteEmployee(string ID)
        {
            string query = "exec sp_deleteEmployee @ID";
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { ID }) > 0;

        }

        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <returns></returns>
        public bool InsertEmployee(Employee emp)
        {
            string query = "exec sp_InsertInfoEmployee @id_employee , @name_employee , @birthday_employee , @sex_employee , @identitycard_employee , @phone_employee , @email_employee , @address_employee , @salary_employee , @id_typeemployee , @id_cinema , @img_employee  ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { emp.Id_employee, emp.Name_employee,
                emp.Birthday_employee, emp.Sex_employeeloyee, emp.Identitycard_employee, emp.Phone_employee,
                emp.Email_employee, emp.Address_employee, emp.Salary_employee, emp.Id_typeemployee, emp.Id_cinema, emp.Img_employee}) > 0;

        }


        /// <summary>
        ///  Lấy dữ liệu từ table loại nhân viên - chức vụ
        /// </summary>
        /// <returns></returns>
        public DataTable getDataTypeEmployee()
        {
            string query = "select * from TypeEmployee";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        /// <summary>
        /// Lấy dữ liệu từ table Cinema
        /// </summary>
        /// <returns></returns>
        public DataTable getDataCinema()
        {
            string query = "select * from Cinema";
            return DataProvider.Instance.ExecuteQuery(query);
        }


        /// <summary>
        /// Tìm kiếm nhân viên theo mã nhân viên, không cần nhập đầy đủ một mã nhân viên
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable search_IDEmployee(string ID)
        {
            string query = "exec sp_search_ID_Employee @ID ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { ID });
        }


        /// <summary>
        /// Tìm kiếm nhân viên theo số điện thoại, không cần nhập đầy đủ một số điện thoại
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public DataTable search_PhoneEmployee(string phone)
        {
            string query = "exec sp_search_Phone_Employee @phone ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { phone });
        }


        /// <summary>
        /// Tìm kiếm nhân viên theo CMND, không cần nhập đầy đủ một số cmnd
        /// </summary>
        /// <param name="identityCard"></param>
        /// <returns></returns>
        public DataTable search_IdentityCardEmployee(string identityCard)
        {
            string query = "exec sp_search_IdentityCard_Employee @identityCard ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { identityCard });
        }

        /// <summary>
        /// Tìm kiếm nhóm nhân viên theo loại nhân viên
        /// </summary>
        /// <param name="idType"></param>
        /// <returns>Danh sách nhân viên</returns>
        public DataTable search_TypeEmployee(string idType)
        {
            string query = "select * from dbo.fun_sort_typeEmployee( @idType )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idType });
        }


        /// <summary>
        /// Tạo một ID cho nhân viên khi vào form để tạo mới nhân viên 
        /// </summary>
        /// <returns> Mã nhân viên: id_employee</returns>
        public object createNewIDEmployee()
        {
            string query = "select dbo.fun_create_newID_Employee()";
            return DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
