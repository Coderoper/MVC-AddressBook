using System.Collections.Generic;
using System.IO;
using System;

namespace AddressBook.Models
{
  //main class
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private int _id;
    private static List<Contact>_contacts = new List<Contact> {};

    //constructor
    public Contact (string name, string phone, string address)
    {
      //this is where I add contacts to the list
      _contacts.Add(this);
      _name = name;
      _phone = phone;
      _address = address;
      _id=_contacts.Count;
    }
    //Add my getters and setters
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address=newAddress;
    }
    public static List<Contact> GetAll()
    {
      return _contacts;
    }

    public int GetId()
    {
      return _id;
    }


    public static Contact Find(int searchId)
    {
      return _contacts[searchId-1];
    }
    public static void ClearAll()
    {
      // _id=1;
      _contacts.Clear();
    }
  }
}
