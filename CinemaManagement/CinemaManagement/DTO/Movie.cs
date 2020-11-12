﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DTO
{
    public class Movie
    {
        private string id_movie; 
        private string name_movie;
        private string director_movie;
        private string id_categorymovie;
        private string runningtime_movie;
        private DateTime releasedate_movie;
        private string language_movie;
        private string state_movie;
        private MemoryStream poster_movie;

        // Mã phim
        public string Id_movie
        {
            get { return id_movie; }
            set { id_movie = value; }
        }

        // Tên phim
        public string Name_movie
        {
            get { return name_movie; }
            set { name_movie = value; }
        }

        // Đạo diễn
        public string Director_movie
        {
            get { return director_movie; }
            set { director_movie = value; }
        }

        // Mã thể loại phim 
        public string Id_categorymovie
        {
            get { return id_categorymovie; }
            set { id_categorymovie = value; }
        }

        // Thời lượng 
        public string Runningtime_movie
        {
            get { return runningtime_movie; }
            set { runningtime_movie = value; }
        }

        // Ngày khởi chiếu
        public DateTime Releasedate_movie
        {
            get { return releasedate_movie; }
            set { releasedate_movie = value; }
        }

        // Ngôn ngữ
        public string Language_movie
        {
            get { return language_movie; }
            set { language_movie = value; }
        }

        // Trạng thái 1 - hoạt động, 0 - ngừng hoạt động
        public string State_movie
        {
            get { return state_movie; }
            set { state_movie = value; }
        }

        // Poster phim 
        public MemoryStream Poster_movie
        {
            get { return poster_movie; }
            set { poster_movie = value; }
        }

        public Movie(string id_movie, string name_movie, string language_movie, string director_movie, string runningtime_movie, DateTime releasedate_movie, string id_categorymovie, MemoryStream poster_movie)
        {
            this.Id_movie = id_movie;
            this.Name_movie = name_movie;
            this.Language_movie = language_movie;
            this.Director_movie = director_movie;
            this.Runningtime_movie = runningtime_movie;
            this.Releasedate_movie = releasedate_movie;
            this.Id_categorymovie = id_categorymovie;
            this.Poster_movie = poster_movie;
        }
    }
}