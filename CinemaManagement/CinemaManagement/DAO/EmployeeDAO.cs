using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CinemaManagement.DTO;
namespace CinemaManagement.DAO
{

    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO();
                return EmployeeDAO.instance;
            }

            private set { EmployeeDAO.instance = value; }
        }



        private EmployeeDAO()
        { }

        public DataTable loadData()
        {
            string query = "exec sp_showEmployee";
            return DataProvider.Instance.ExecuteQuery(query);
        }




        public DataTable loadDataForCinemaCurrent(string idCinema)
        {
            string query = "exec sp_showEmployeeForCinemaCurrent @id_cinema ";
            return DataProvider.Instance.ExecuteQuery(query , new object[] { idCinema });
        }


        /// <summary>
        /// Chỉnh sửa thông tin nhân viên
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public int editInfoEmployee(Employee emp)
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
        public bool insertEmployee(Employee emp)
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
            string query = "select * from TypeEmployee where id_typeemployee not like 'tyem04' ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getDataTypeForAddEmployee()
        {
            string query = "select * from TypeEmployee where id_typeemployee not like 'tyem04' ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable getDataTypeForAddEmployeeOfCinemaAcurrent()
        {
            string query = "select * from TypeEmployee where id_typeemployee not like 'tyem04' and id_typeemployee not like 'tyem03' ";
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

        public DataTable getDataCinemaForCinemaCurrent(string idCinema)
        {
            string query = "select * from Cinema where id_cinema  = @idCinema ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { @idCinema });
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

        public DataTable search_EmailEmployee(string email)
        {
            string query = "select * from Employee where email_employee  = @email ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { email });
        }


        /// <summary>
        /// Tìm kiếm nhân viên theo tên
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable search_NameEmployee(string name)
        {
            string query = "exec sp_search_name_Employee @name ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name });
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


        public object getIdCinema(string idEmp)
        {
            string query = "select id_cinema from Employee where id_employee = @idEmp ";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { idEmp });
        }

        public bool createShiftOfMonth(string idEmployee, int month, int year, string idShift)
        {
            string query = "exec sp_createShiftAllMonth @id , @month , @year ,  @idShift ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idEmployee,  month, year , idShift }) > 0;
        }

        public object selectWeekOnMonth(int month, int  year, int indexWeek)
        {
            string query = "select dbo.fun_selectDayOfIndexWeek( @month , @year , @indexWeek )";
            return DataProvider.Instance.ExecuteScalar(query, new object[] {month, year, indexWeek });
        }

        public object selectDateEndWeek(DateTime date, int indexDay)
        {
            string query = "select dbo.fun_findDate( @date  , @indexDay )";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { date, indexDay });
        }

        public bool createShitfOnlyOneDay(DateTime date, int indexDay, string idEmployee, string idShitf)
        {
            string query = "exec createShiftOfDate @date , @indexDay , @idEmployee , @idShift ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { date, indexDay, idEmployee, idShitf }) > 0;
        }

        public bool createShitfFullWeek(DateTime date, string idEmployee, string idShitf)
        {
            string query = "exec sp_createShiftFullWeek @date , @idEmployee , @idShift ";
            return  DataProvider.Instance.ExecuteNonQuery(query, new object[] { date, idEmployee , idShitf}) > 0;
        }

        public bool updatePassLogin(string username, string pass, string newPass)
        {
            string query = " exec sp_updatePass @username ,  @pass , @newPass ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, pass, newPass}) > 0;
           
        }

        public object getNameById(string id)
        {
            string query = "select name_employee from Employee where id_employee = @id ";
            return DataProvider.Instance.ExecuteScalar(query , new object[] { id });
        }
    }
}
