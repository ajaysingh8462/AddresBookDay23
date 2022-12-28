using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public interface IContact
    {
        public void CreateContact(string firstName, string lastName, string address, string city, string state,
            string Email, int zip, long phoneNumber, string BookName);
        public void EditContact(string name, string BookName);
        public void DeleteContact(string name, string BookName);
        public void ViewContact(string name, string BookName);
        public void AddAddressBook(string BookName);
    }
}
