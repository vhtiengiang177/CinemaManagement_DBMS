using System;

namespace CinemaManagement.DTO
{
    class Customer
    {

        public Customer()
        {
            
        }

        public string Id_Customer { get => id_Customer; set => id_Customer = value; }
        public string Lname_Customer { get => lname_Customer; set => lname_Customer = value; }
        public string Fname_Customer { get => fname_Customer; set => fname_Customer = value; }
        public DateTime Birthday_Customer { get => birthday_Customer; set => birthday_Customer = value; }
        public string Sex_Customer { get => sex_Customer; set => sex_Customer = value; }
        public string Identitycard_Customer { get => identitycard_Customer; set => identitycard_Customer = value; }
        public string Phone_Customer { get => phone_Customer; set => phone_Customer = value; }
        public string Email_Customer { get => email_Customer; set => email_Customer = value; }
        public string Address_Customer { get => address_Customer; set => address_Customer = value; }
        public int Point_Customer { get => point_Customer; set => point_Customer = value; }
        public string Id_TypeCustomer { get => id_TypeCustomer; set => id_TypeCustomer = value; }
        public string Qr_Customer { get => qr_Customer; set => qr_Customer = value; }

        private string id_Customer;
        private string lname_Customer;
        private string fname_Customer;
        private DateTime birthday_Customer;
        private string sex_Customer;
        private string identitycard_Customer;
        private string phone_Customer;
        private string email_Customer;
        private string address_Customer;
        private int point_Customer;
        private string id_TypeCustomer;
        private string qr_Customer;

    }
}
