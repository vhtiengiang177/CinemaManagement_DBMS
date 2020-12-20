using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        //public static DataProvider Instance
        //{
        //    get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
        //    private set { DataProvider.instance = value; }
        //}


        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        public static void unInstance()
        {
            instance = null;
        }



        private DataProvider()
        {
 
        }

   

        //private string connectionString = @"Data Source=localhost;Initial Catalog=DB25;Integrated Security=True";

        public static string username = "";
        public static string pass = "";

   

        private string connectionString = @"Data Source=192.168.1.239,1433;Initial Catalog=DB27;Integrated Security=False;Connect Timeout=30;user ID= "+ username + ";password=" + pass;
        //private string connectionString = @"Data Source=localhost;Initial Catalog=DB24;Integrated Security=False;Connect Timeout=30;user ID= "+ username + ";password=" + pass ;
        /// <summary>
        /// Execute query trả về table. Dùng cho DataSoure của DataGridView.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            // Tạo connect 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở connect
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                // para là ds truyền vào từ hàm. Khác null là có para truyền vào
                if (parameter != null)
                {
                    //cắt từ bằng 2 dấu space
                    string[] listPara = query.Split(' ');       //các từ trong câu query
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        // Nếu từ có dấu @ 
                        if (item.Contains("@"))
                        {
                            // Add giá trị thứ i của para vào câu query thay cho item
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        /// <summary>
        /// Trả về số hàng, CHỈ DÙNG CHO INSERT UPDATE DELETE, không dùng đc cho SELECT
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        // Ví dụ khi insert hay update sql ghi là 1 row affect hoặc 2 rows affect, thì câu này trả ra những số đó như 1 hoặc 2
        // Không dùng được cho đăng nhập, vì không dùng được cho câu select --> đăng nhập dùng execute query, đếm table. row >0 
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        /// <summary>
        /// Trả về ô đầu tiên của hàng đầu tiên --> phù hợp cho câu truy vấn select count()
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
