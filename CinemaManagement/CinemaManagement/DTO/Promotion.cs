using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagement.DTO
{
    public class Promotion
    {
        private string id_promotion;
        private string name_promotion;
        private DateTime  timeStart_promotion;
        private DateTime timeEnd_promotion;
        private string object_promotion;
        private double value_promotion;
       

        public string Id_promotion
        {
            get { return this.id_promotion; }
            set { this.id_promotion = value; }
        }

        public string Name_promotion
        {
            get { return this.name_promotion; }
            set { this.name_promotion = value; }
        }

        public DateTime TimeStart_promotion
        {
            get { return this.timeStart_promotion; }
            set { this.timeStart_promotion = value; }
        }

        public DateTime TimeEnd_promotion
        {
            get { return this.timeEnd_promotion; }
            set { this.timeEnd_promotion = value; }
        }

        public string Object_promotion
        {
            get { return this.object_promotion; }
            set { this.object_promotion = value; }
        }

        public double Value_promotion
        {
            get { return this.value_promotion; }
            set { this.value_promotion = value; }
        }

        
        public Promotion(string id, string name,  DateTime start, DateTime end, string objects, double values)
        {
            this.Id_promotion = id;
            this.Name_promotion = name;
            this.TimeStart_promotion = start;
            this.TimeEnd_promotion = end;
            this.Object_promotion = objects;
            this.Value_promotion = values;
        }
    }
}
