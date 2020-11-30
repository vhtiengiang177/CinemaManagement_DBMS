﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CinemaManagement.DTO;
namespace CinemaManagement.DAO
{
    class ShowTimeOrderDAO
    {
        private static ShowTimeOrderDAO instance;
        public static ShowTimeOrderDAO Instance
        {
            get
            {
                if (instance == null) instance = new ShowTimeOrderDAO();
                return ShowTimeOrderDAO.instance;
            }

            private set { ShowTimeOrderDAO.instance = value; }
        }



        private ShowTimeOrderDAO()
        { 

        }

        public List<DateTime> getDateShiftShow(string idMovie)
        {
            List<DateTime> listDateShiftShow = new List<DateTime>();

            string query = "select date_showtimes from Showtimes where id_movie = @idMovie ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idMovie});

            foreach (DataRow item in data.Rows)
            {
                DateTime date = (DateTime)item[0];
                listDateShiftShow.Add(date);
            }

            return listDateShiftShow;
        }
    }
}
