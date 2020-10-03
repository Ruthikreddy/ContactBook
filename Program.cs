using System;
using System.Collections.Generic;

class AddressPrompt
{
    AddressBook book;

    public AddressPrompt()
    {
        book = new AddressBook();
    }

    static void Main(string[] args)
    {
        string selection = "";
        AddressPrompt prompt = new AddressPrompt();

        prompt.displayMenu();
        while (!selection.ToUpper().Equals("Q"))
        {
            Console.WriteLine("Selection: ");
            selection = Console.ReadLine();
            prompt.performAction(selection);
        }
    }

    void displayMenu()
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("=========");
        Console.WriteLine("A - Add an Address");
          }

    void performAction(string selection)
    {
        string Firstname = "";
        string lastName = "";
        string address = "";
        string city = "";
        string state = "";
        int zip = 0;
        double phoneNo = 0;
        string eMail = "";
        switch (selection.ToUpper())
        {
            case "A":
                Console.WriteLine("Enter Name: ");
                Firstname = Console.ReadLine();
                lastName = Console.ReadLine();
                address = Console.ReadLine();
                city = Console.ReadLine();
                state = Console.ReadLine();
                zip = Convert.ToInt32(Console.ReadLine());
                phoneNo = Convert.ToDouble(Console.ReadLine());
                eMail = Console.ReadLine();


                if (book.add(Firstname, lastName, address, city, state, zip, phoneNo, eMail))
                {
                    Console.WriteLine("Address successfully added!");
                }
                else
                {
                    Console.WriteLine("An address is already on file for {0}.", Firstname);
                }
                break;
            case "E":
                Console.WriteLine("Enter Name to Edit: ");
                Firstname = Console.ReadLine();
                Address addr = book.find(Firstname);
                if (addr == null)
                {
                    Console.WriteLine("Address for {0} count not be found.", Firstname);
                }
                else
                {
                    Console.WriteLine("Enter new New name: ");
                    addr.Firstname = Console.ReadLine();
                    Console.WriteLine("Name updated for {0}", Firstname);
                }
                break;

        }
    }
}