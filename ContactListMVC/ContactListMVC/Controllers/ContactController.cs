using ContactListMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ContactListMVC.Controllers
{
    public class ContactController : Controller
    {
        ContactListContext db;

        public ContactController(ContactListContext context)
        {
            db = context;
        }

        public IActionResult Contact()
        {
            return View("Contact");
        }

        public IActionResult SelectCustomers()
        {
            return View("~/Views/Customer/customer.cshtml");
        }
    }
}
