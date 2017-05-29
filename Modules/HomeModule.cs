using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["contacts.cshtml", allContacts];
      };
      Get["/contact/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contacts"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone"], Request.Form["new-address"], Request.Form["new-email"]);
        return View["contact_added.cshtml", newContact];
      };
      Get["/contacts/clear"] = _ => {
        return View["/clear_contacts.cshtml"];
      };
      Post["/contacts/empty"] = _ => {
        Contact.ClearAll();
        return View["/contacts_cleared.cshtml"];
      };
    }
  }
}
