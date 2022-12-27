using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Addressbook
    {
        public string FirstName, LastName, Address, City, State , Email;
        public int Zip;
        public long PhoneNumber;
        public Addressbook[] ContactArray;
        public int Contact = 0;
        public Addressbook()
        {
            this.ContactArray= new Addressbook[5];
        }
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
        public void CreatContact(string firstName, string lastName, string address, string city, string state, string Email, int zip, long phoneNumber)
        {
            ContactArray[this.Contact] = new Addressbook( firstName, lastName,address,city,state,Email,zip,phoneNumber);
            Contact++;
            program pr = new program();
            pr.DisplayContact(ContactArray, Contact);
        }
        
    }
}
