using AddressBookLinq;
using System;
using System.Data;

namespace AddressBookLinq
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
                Console.WriteLine("2: For Display Contact");
                Console.WriteLine("3: For Edit the Contact");
                Console.WriteLine("4: For Delete The Contact");
                Console.WriteLine("0: For Exist");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.AddContact();                        
                        break;
                    case 2:
                        addressbook.DisplayContacts();
                        break;
                    case 3:
                        addressbook.EditContact();
                        break;
                    case 4:
                        addressbook.RemoveContact();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Input Please Choose Correct Option");
                        break ;
                }
            }
            while (option != 0);
        }
    }
}