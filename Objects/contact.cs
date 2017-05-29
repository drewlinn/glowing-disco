using System;
using System.Collections.Generic;

namespace AddressBook.Objects
{

  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private string _email;
    private static List<Contact> _contacts = new List<Contact> {};

    public Contact(string name, string phone, string address, string email)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _email = email;
      _contacts.Add(this);
    }

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
      _address = newAddress;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public void Save()
    {
      _contacts.Add(this);
    }
    public static List<Contact> GetAll()
    {
      return _contacts;
    }
    public static void ClearAll()
    {
      _contacts.Clear();
    }
  }
}
