using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    //controller class
    public class HomeController : Controller
    {
        //Get and post routes
        //this will be the homepage
        [HttpGet("/")]
        public ActionResult Index()
        {
          //define list as allcontacts
          List<Contact> allContacts = Contact.GetAll();
          //passes allContacts to view and looks for Index.cshtml under view folder
          return View(allContacts);
        }
        //this is where you are routed when you click add new contact
        [HttpGet("/contacts/new")]
        public ActionResult CreateForm()
        {
          //when you submit the form you are returned to the homepage with View()
          return View();
        }
        [HttpPost("/contacts")]
        //creates a new contact and adds to list allcontacts
        public ActionResult Create()
        {
          //takes user input to create newContact
          Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone"], Request.Form["new-address"]);
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
        }
        [HttpGet("/contacts/{id}")]
        public ActionResult Details(int id)
        {
            Contact contact = Contact.Find(id);
            return View(contact);
        }
        [HttpPost("/contacts/clearall")]
        public ActionResult ClearAll()
        {
          Contact.ClearAll();
          return View();

        }
    }
}
