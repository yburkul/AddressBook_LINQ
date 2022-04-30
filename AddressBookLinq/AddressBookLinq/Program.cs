using System;
using System.Data;

namespace AddressBook_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Using LINQ");
            AddressBook addressbook = new AddressBook();
            int option=0;
            do
            {
                Console.WriteLine("1: For Add the Contact");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DataTable data = addressbook.CreateAddressBookDataTable();
                        addressbook.DisplayContacts(data);
                        break;
                }
            }
            while (option != 0);
        }
    }
}