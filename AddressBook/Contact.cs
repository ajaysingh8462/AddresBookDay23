using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public Contact(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNum)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            PhoneNumber = phoneNum;
        }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + ", Address: " + Address + ", City: " + City + ", State: " + State + ", Zip: " + Zip + ", Email: " + Email + ", Phone: " + PhoneNumber;
        }

    }
}
