using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Address Book program");
            Addressbook Add = new Addressbook("Ajay","Singh","Sector 45","Gurgaon","Haryana","ajay8462@gamil.com",402001,7898234604);
            Add.DisplayContect();

        }
    }
}