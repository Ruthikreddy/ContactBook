using System;
using System.Collections.Generic;


class AddressBook
{
    List<Address> addresses;

    public AddressBook()
    {
        addresses = new List<Address>();
    }

    public bool add(string Firstname, string Lastname, string address, string city, string state, int zip, double phoneNo, string email)
    {
        Address addr = new Address(Firstname, Lastname, address, city, state, zip, phoneNo, email);
        Address result = find(Firstname);

        if (result == null)
        {
            addresses.Add(addr);
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool remove(string Firstname)
    {
        Address addr = find(Firstname);

        if (addr != null)
        {
            addresses.Remove(addr);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void list(Action<Address> action)
    {
        addresses.ForEach(action);
    }

    public bool isEmpty()
    {
        return (addresses.Count == 0);
    }

    public Address find(string name)
    {
        Address addr = addresses.Find((a) => a.Firstname == name);
        return addr;
    }
}