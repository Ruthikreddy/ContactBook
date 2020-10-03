using System;
using System.Collections;
using System.Dynamic;
namespace AddressBook
{
    public class contact
    {
        String FirstName;
        String LastName;
        String PhoneNumber;
        String Address;
        String zipCode;
        String Email;

        public contact(String FirstName, String LastName, String PhoneNumber, String Address, String zipCode, String Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.zipCode = zipCode;
            this.Email = Email;
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string zipCode { get; set; }
            public string Email { get; set; }
        }
        static void Main(string[] args)
        {
            contact person = new contact("Ruthik", "Reddy", "1234", "Place", "462003", "abcd@gmail.com");
            Console.WriteLine("Enter Your First Name" + person.FirstName);
            Console.WriteLine("Enter Your Last Name" + person.LastName);
            Console.WriteLine("Enter PhoneNumber" + person.PhoneNumber);
            Console.WriteLine("Enter Your Zipcode" + person.zipCode);
            Console.WriteLine("Enter Your Email" + person.Email);


        }
    }

}