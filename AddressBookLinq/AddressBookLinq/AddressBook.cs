using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AddressBook_LINQ
{
    class AddressBook
    {
        DataTable dataTable = new DataTable();
        
        public DataTable CreateAddressBookDataTable()
        {
            Console.Write("Enter the First Name: ");
            string FirstName = Console.ReadLine();
            Console.Write("Enter the Last Name: ");
            string LastName = Console.ReadLine();
            Console.Write("Enter the Address: ");
            string Address = Console.ReadLine();
            Console.Write("Enter the City: ");
            string City = Console.ReadLine();
            Console.Write("Enter the State: ");
            string State = Console.ReadLine();
            Console.Write("Enter the Zip code: ");
            int Zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Phone Number: ");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter the Email id: ");
            string Email = Console.ReadLine();

            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Rows.Add(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
            return dataTable;
        }
        public void DisplayContacts(DataTable addresstable)
        {
            var contacts = addresstable.Rows.Cast<DataRow>();

            foreach (var contact in contacts)
            {
                Console.WriteLine("First Name : " + contact.Field<string>("FirstName") + " - " + "Last Name : " + contact.Field<string>("LastName") + " - " + "Address : " + contact.Field<string>("Address") + " - " + "City : " + contact.Field<string>("City") + " - " + "State : " + contact.Field<string>("State")
                    + " - " + "Zip : " + contact.Field<int>("Zip") + " - " + "Phone Number : " + contact.Field<long>("PhoneNumber") + " - " + "Email : " + contact.Field<string>("Email") + " ");
                Console.WriteLine();
            }
        }
    }
}