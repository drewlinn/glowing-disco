using System;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contacts"] = _ => {
        Contact newContact = new Contact(Request.Form["new-contact"]);
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
    }
  }
}
