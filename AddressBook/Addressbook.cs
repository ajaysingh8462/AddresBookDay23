using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Addressbook
    {
        public string FirstName, LastName, Address, City, State , Email;
        public int Zip;
        public long PhoneNumber;
        public Addressbook(string firstName, string lastName, string address, string city, string state,string Email, int zip, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = Email;
            Zip = zip;
            PhoneNumber = phoneNumber;
        }
        public void DisplayContect()
        {
            Console.WriteLine("Name {0} {1},",FirstName,LastName);
            Console.WriteLine("Adrdess {0} " , Address);
            Console.WriteLine("City {0}", City);
            Console.WriteLine("State {0} ", State);
            Console.WriteLine("Email {0}", Email);
            Console.WriteLine("Zip {0}", Zip);
            Console.WriteLine("PhoneNumber {0}", PhoneNumber);
        }
    }
}
