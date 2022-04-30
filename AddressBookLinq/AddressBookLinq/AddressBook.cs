using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AddressBookLinq
{
    class AddressBook
    {
        DataTable dataTable = new DataTable();
        public AddressBook()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(long));
            dataTable.Columns.Add("Email", typeof(string));
        }
        public void AddContact()
        {
            
            dataTable.Rows.Add("Yogesh", "Burkul", "Asola", "Surat", "Gujrat", 38117, 9017658987, "yogesh@gmail.com");
            dataTable.Rows.Add("Atish", "Patil", "Akola", "Nagpur", "Maharshtra", 84113, 8015870002, "atish123@gmail.com");
            dataTable.Rows.Add("Nikita", "Pawar", "Jalna", "Beed", "Telangana", 88352, 2699626511, "nikitapawar@gmail.com");
            dataTable.Rows.Add("Ganesh", "Shelke", "Chikhali", "Pune", "Maharshtra", 49546, 6165758233, "ganesh987@gmail.com");
            dataTable.Rows.Add("Aniket", "Mante", "Javli", "Mumbai", "Maharshtra", 46214, 3174103617, "aniket678@gmail.com");
            Console.WriteLine("Contact is Added in Address Book ");
            
        }
        public void DisplayContacts()
        {
            foreach (var contact in dataTable.AsEnumerable())
            {
                Console.WriteLine("FirstName:" + contact.Field<string>("FirstName"));
                Console.WriteLine("LastName:-" + contact.Field<string>("LastName"));
                Console.WriteLine("Address:-" + contact.Field<string>("Address"));
                Console.WriteLine("City:-" + contact.Field<string>("City"));
                Console.WriteLine("State:-" + contact.Field<string>("State"));
                Console.WriteLine("ZipCode:-" + contact.Field<int>("Zip"));
                Console.WriteLine("PhoneNumber:-" + contact.Field<long>("PhoneNumber"));
                Console.WriteLine("Email:-" + contact.Field<string>("Email"));
                Console.WriteLine();
            }
        }
        public void EditContact()
        {
            var contacts = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Aniket");
            int count = contacts.Count();
            if (count > 0)
            {
                foreach (var contact in contacts)
                {
                    contact.SetField("LastName", "Surushe");
                    contact.SetField("City", "Surat");
                    contact.SetField("State", "Gujrat");
                    contact.SetField("Zip", 23212);
                }
                Console.WriteLine("Contact is Changed Successfully");
            }
            else
            {
                Console.WriteLine("Contact Does not Found!");                
            }
        }
        public void RemoveContact()
        {
            var contact = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Aniket");
            int count = contact.Count();
            if(count > 0)
            {
                foreach(var row in contact.ToList())
                {
                    row.Delete();
                    Console.WriteLine("Contact Is Deleted Successfully");
                }
            }
            else
            {
                Console.WriteLine("Contact Does not Found!");
            }
        }
        public void GetContactByUsingCityAndState()
        {
            var contacts = dataTable.AsEnumerable().Where(x => x.Field<string>("City") == "Surat" && x.Field<string>("State") == "Gujrat");
            int count = contacts.Count();
            if( count > 0)
            {
                foreach( var contact in contacts)
                {
                    Console.WriteLine("First Name:" + contact.Field<string>("FirstName"));
                    Console.WriteLine("LastName:-" + contact.Field<string>("LastName"));
                    Console.WriteLine("Address:-" + contact.Field<string>("Address"));
                    Console.WriteLine("City:-" + contact.Field<string>("City"));
                    Console.WriteLine("State:-" + contact.Field<string>("State"));
                    Console.WriteLine("ZipCode:-" + contact.Field<int>("Zip"));
                    Console.WriteLine("PhoneNumber:-" + contact.Field<long>("PhoneNumber"));
                    Console.WriteLine("Email:-" + contact.Field<string>("Email"));
                    Console.WriteLine();

                }
            }
        }
    }
}