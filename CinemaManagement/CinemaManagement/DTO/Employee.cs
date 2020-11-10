using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaManagement.DTO
{
    public class Employee
    {
        private string id_employee;
        private string last_employee;
        private string firstname_employee;
        private DateTime birthday_employee;
        private string sex_employee;
        private string identitycard_employee;
        private string phone_employee;
        private string email_employee;
        private string address_employee;
        private Double salary_employee;
        private string id_typeemployee;
        private string id_cinema;
        private MemoryStream img_employee;
        private string qr_employee;
        private string state_employee;
        private string username_employee;
        private string password;

        public string Id_employee {
            get { return this.id_employee; }
            set { this.id_employee = value; } 
        }

        public string Last_employee
        {
            get { return this.last_employee; }
            set { this.last_employee = value; }
        }

        public string Firstname_employee
        {
            get { return this.firstname_employee; }
            set { this.firstname_employee = value; }
        }

        public DateTime Birthday_employee
        {
            get { return this.birthday_employee; }
            set { this.birthday_employee = value; }
        }

        public string Sex_employeeloyee
        {
            get { return this.sex_employee; }
            set { this.sex_employee = value; }
        }

        public string Identitycard_employee
        {
            get { return this.identitycard_employee; }
            set { this.identitycard_employee = value; }
        }

        public string Phone_employee
        {
            get { return this.phone_employee; }
            set { this.phone_employee = value; }
        }

        public string Email_employee
        {
            get { return this.Email_employee; }
            set { this.Email_employee = value; }
        }

        public string Address_employee
        {
            get { return this.address_employee; }
            set { this.address_employee = value; }
        }

        public Double Salary_employee
        {
            get { return this.salary_employee; }
            set { this.salary_employee = value; }
        }

        public string Id_typeemployee
        {
            get { return this.id_typeemployee; }
            set { this.id_typeemployee = value; }
        }

        public string Id_cinema
        {
            get { return this.id_cinema; }
            set { this.id_cinema = value; }
        }

        public MemoryStream Img_employee
        {
            get { return this.img_employee; }
            set { this.img_employee = value; }
        }

        public string Qr_employee
        {
            get { return this.qr_employee; }
            set { this.qr_employee = value; }
        }

        public string State_employee
        {
            get { return this.state_employee; }
            set { this.state_employee = value; }
        }

        public string Username_employee
        {
            get { return this.username_employee; }
            set { this.username_employee = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }


        public Employee(string id, string lastName, string firstname, DateTime birthDay, string gender, string identity, string phone, string email, string address, double salary, string idType, string idCinema, MemoryStream img, string qr, string state, string userName, string pass)
        {
            this.Id_employee = id;
            this.Last_employee = lastName;
            this.Firstname_employee = firstname;
            this.Birthday_employee = birthDay;
            this.Sex_employeeloyee = gender;
            this.Identitycard_employee = identity;
            this.Phone_employee = phone;
            this.Email_employee = email;
            this.Address_employee = address;
            this.Salary_employee = salary;
            this.Id_typeemployee = idType;
            this.Id_cinema = idCinema;
            this.Img_employee = img;
            this.Qr_employee = qr;
            this.State_employee = state;
            this.Username_employee = userName;
            this.Password = pass;
        }
    }
}
