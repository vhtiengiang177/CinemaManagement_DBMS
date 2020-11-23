using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{
    public class LoginDAO
    {
        private static LoginDAO instance;

        public static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return LoginDAO.instance; }
            private set { LoginDAO.instance = value; }
        }


        /// <summary>
        /// Hàm kiểm tra login có thành công hay không, nếu không thanh công trả về giá trị rỗng
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns>username</returns>
        public object isLogin(string userName, string passWord)
        {
            string query = "select dbo.fun_isLogin( @user , @pass )";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { userName, passWord });
        }

        public object getTypeEmployee(string userName)
        {
            string query = "select dbo.fun_selectTypeEmployee( @user )";
            return DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
        }
    }
}
