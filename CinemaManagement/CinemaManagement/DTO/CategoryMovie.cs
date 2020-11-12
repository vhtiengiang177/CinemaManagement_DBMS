using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DTO
{
    public class CategoryMovie
    {
        private string id_categorymovie;
        private string name_categorymovie;

        // Mã thể loại phim
        public string Id_categorymovie
        {
            get { return id_categorymovie; }
            set { id_categorymovie = value; }
        }

        // Tên phim
        public string Name_categorymovie
        {
            get { return name_categorymovie; }
            set { name_categorymovie = value; }
        }
    }
}
