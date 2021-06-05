using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CinemaManagement.DAO
{
    public class StatisticDAO
    {
        private static StatisticDAO instance;
        public static StatisticDAO Instance
        {
            get { if (instance == null) instance = new StatisticDAO(); return StatisticDAO.instance; }
            private set { StatisticDAO.instance = value; }
        }

        private StatisticDAO() { }



        public DataTable countMovie()
        {
            string query = "select * from Movie";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //load doanh số all năm
        public DataTable loadAll()
        {
            string query = "select*from fc_CalTotalAll()";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //load doanh số theo thời gian
        public DataTable loadTotalByTime(string datefrom,string dateto)
        {
            string query = "select* from fc_CalByTime( @datefrom , @dateto )"; 
            return DataProvider.Instance.ExecuteQuery(query, new object[] { datefrom, dateto });
        }
        

        public DataTable loadTotalByCategory(string idcategory)
        {
            string query = "select* from fc_CalByCategory( @idCategory )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idcategory});
        }

        public DataTable loadTotalByMovie(string idmovie)
        {
            string query = "select* from fc_CalByMovie( @idMovie )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idmovie });
        }

        public DataTable loadTotalByTimeByCategory(string datefrom, string dateto,string idcategoty)
        {
            string query = "select* from fc_CalByTimeByCategory( @datefrom , @dateto , @idCategory )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { datefrom, dateto, idcategoty });
        }


        public DataTable loadTotalByTimeByMovie(string datefrom, string dateto, string idmovie)
        {
            string query = "select* from fc_CalByTimeByMovie( @datefrom , @dateto , @idMovie )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { datefrom, dateto, idmovie });
        }



        //load các năm hoạt động của hệ thống
        public DataTable loadYear()
        {
            string query = "exec sp_loadYear";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //load doanh số của rạp được chọn, năm đc chọn trong tháng đc chọn
        public DataTable countTotalOnCinemabyMonthbyYear(string id_year, string id_month, string id_cinema)
        {
            string query = "select*from dbo.fc_countTotalOnCinemabyMonthbyYear( @id_year , @id_month , @id_cinema )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDouble(id_year), Convert.ToDouble(id_month), id_cinema });
        }

        //load doanh số của rạp được chọn trong năm đc chọn
        public DataTable loadOnCinemabyYear(string id_cinema, string id_year)
        {
            string query = "select*from dbo.fc_countTotalOnCinemabyYear( @id_cinema , @id_year )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id_cinema, Convert.ToDouble(id_year) });
        }


        //load doanh số của rạp được chọn trong các năm
        public DataTable loadOnCinema(string id_cinema)
        {
            string query = "select*from fc_countTotalOnCinemaAllMonth( @id )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { id_cinema });
        }

        //load doanh số của năm được chọn
        public DataTable countTotalbyYear(string id_year)
        {
            string query = "select*from dbo.fc_countTotalbyYear( @id_year )";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { Convert.ToDouble(id_year) });
        }





    }
}
