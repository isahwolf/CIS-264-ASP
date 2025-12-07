using ContactListMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;

namespace ContactListMVC.Controllers
{
    public class CustomerController : Controller
    {
        ContactListContext db;

        public CustomerController(ContactListContext context)
        {
            db = context;
        }

        public IActionResult Customer(string nam)
        {
            return View(new CustomerViewModel()
            {
                Customers = db.Customers.Where(c => c.Name == nam || nam == null || nam == string.Empty),
                Name = new SelectList(db.Customers.Select(c => c.Name).Distinct()),
                CustomerID = new SelectList(db.Customers.Select(c => c.CustomerID).Distinct())
            });

        }

        public IActionResult DisplayContactList()
        {
            var contactList = HttpContext.Session.GetJson<List<Customer>>("Contact") ?? new List<Customer>();
            return View("~/Views/Contact/contact.cshtml", contactList);
        }

        [HttpPost]
        public IActionResult AddToContactList(int customerID)
        {
            List<Customer> contactList = HttpContext.Session.GetJson<List<Customer>>("Contact") ?? new List<Customer>();

            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerID);
            if (customer != null && !contactList.Any(c => c.CustomerID == customerID))
            {
                contactList.Add(customer);
            }

            HttpContext.Session.SetJson("Contact", contactList);

            return RedirectToAction("Customer");
        }

    }
}
