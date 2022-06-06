using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace AddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book Problem!");

            AddressBook add = new AddressBook();
            Person person = new Person();
            
            Console.Write("Enter the First Name : ");
            string name = Console.ReadLine();
            person.First_Name = name;
            
            Console.Write("Enter the Last Name : ");
            string lastName = Console.ReadLine();
            person.Last_Name = lastName;
            
            Console.Write("Enter the Address : ");
            string address = Console.`
            
            Console.Write("Enter the City Name : ");
            string city = Console.ReadLine();
            person.City = city;
            
            Console.Write("Enter the  State Name : ");
            string state = Console.ReadLine();
            person.State = state;
            
            Console.Write("Enter the  Zip Code : ");
            long zip = long.Parse(Console.ReadLine());
            person.Zip_Code = zip;
            
            Console.Write("Enter the Phone Number : ");
            long phone = long.Parse(Console.ReadLine());
            person.Phone_Number = phone;
            
            Console.Write("Enter the  Email ID : ");
            string email = Console.ReadLine();
            person.Email_ID = email;
            
            Console.WriteLine();
            
            add.AddPerson(person);
            add.Display();
        }
    }
}
