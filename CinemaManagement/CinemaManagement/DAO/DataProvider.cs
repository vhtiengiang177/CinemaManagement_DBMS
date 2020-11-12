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

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider()
        {
 
        }

        private string connectionString = @"Data Source=localhost;Initial Catalog=cinemaDBMS;Integrated Security=True";


        // execute query trả về table, nên là return table. dùng cho datasoure của dgv
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            //tạo connect 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //mở connect
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                //para là ds truyền vào từ hàm. Khác null là có para truyền vào
                if (parameter != null)
                {
                    //cắt từ bằng 2 dấu space
                    string[] listPara = query.Split(' ');       //các từ trong câu query
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        //nếu từ có dấu @ 
                        if (item.Contains("@"))
                        {
                            //add giá trị thứ i của para vào câu query thay cho item
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


        // execute non query trả về số hàng, CHỈ DÙNG CHO INSERT UPDATE DELETE, hk dùng đc cho SELECT
        //ví dụ khi insert hay update sql ghi là 1 row affect hoặc 2 rows affect, thì câu này trả ra những số đó như 1 hoặc 2
        //không dùng được cho đăng nhập, vì hk dùng đc cho câu select --> đăng nhập dùng execute query, đếm table. row >0 
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


        //trả về ô đầu tiên của hàng đầu tiên --> phù hợp cho câu truy vấn select count() ...  ít xài
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
