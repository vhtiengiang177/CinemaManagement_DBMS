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

        public int EditInfoEmployee(Employee emp)
        {
            string query = "exec sp_updateInforEmployee";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { emp.Id_employee, emp.Last_employee, emp.Firstname_employee, 
                emp.Birthday_employee, emp.Sex_employeeloyee, emp.Identitycard_employee, emp.Phone_employee, 
                emp.Email_employee, emp.Address_employee, emp.Salary_employee, emp.Id_typeemployee, emp.Id_cinema, emp.Img_employee});
           
        }

        public bool InsertEmployee()
        {
            return true;
        }
    }
}
