using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vande_Ven_Airline_System_GUI
{
    class Customer
    {

        private string firstName;
        private string lastName;
        private string streetAddress;
        private string city;
        private string state;
        private string zipCode;
        private string phone;
        private string creditCardNum;

        //Customer Constructor
        public Customer(string firstName, string lastName, string address, string city, 
            string state, string zipCode, string phone, string creditCardNum) 
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            Phone = phone;
            CreditCardNum = creditCardNum;
        }

        //property of firstName instance variable
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

        //property of lastName instance variable
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

        //property of streetAddress instance variable
        public string StreetAddress 
        {
            get
            {
                return streetAddress;
            }
            set
            {
                streetAddress = value;
            }
        }

        //property of city instance variable
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

        //property of state instance variable
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

        //property of zipCode instance variable
        public string ZipCode 
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }

        //property of phone instance variable
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

        //property of creditCardNum instance variable;
        public string CreditCardNum 
        {
            get
            {
                return creditCardNum;
            }
            set
            {
                creditCardNum = value;
            }
        }

        //returns a confrimation/success message to the GUI 
        override public string ToString()  
        {
            return "Customer " + FirstName + " " + LastName + " has been successfully created.";
        }

    }
}
