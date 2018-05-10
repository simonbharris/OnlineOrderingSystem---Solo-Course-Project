using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Customer
    {
        int customerId;
        string firstName;
        string lastName;
        string email;
        string phone = "";
        string address = "";
        string city = "";
        string state = "";
        string zip = "";

        // I don't think this should be stored in itself.
        public static Customer activeCustomer;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }

            set
            {
                zip = value;
            }
        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public Customer()
        {

        }

        public Customer(string firstName, string lastName, string email, string phone, string address, string city, string state, string zip)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
        }

        public Customer(string firstName, string lastName, string email, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
        }

    }
}
