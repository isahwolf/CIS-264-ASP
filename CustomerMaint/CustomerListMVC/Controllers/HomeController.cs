using CustomerListMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace CustomerListMVC.Controllers
{
    public class HomeController : Controller
    {
        HalloweenContext db;

        public HomeController(HalloweenContext context)
        {
            db = context;
        }

        public IActionResult Index(string state = "IL")
        {
            return View("List", new ListViewModel()
            {
                Customers = db.Customers.Where(c => c.State == state || state == null).ToList(),
                States = new SelectList(db.States, "StateID", "StateName", state)
            });
        }

        public IActionResult Edit(int customerid)
        {
            Customer customer = db.Customers.Where(p => p.CustomerID == customerid).FirstOrDefault();
            return View(customer);
        }

        public IActionResult Save(Customer customer)
        {
            if (customer.CustomerID == 0)
            {
                db.Customers.Add(customer);
            }
            else
            {
                Customer c = db.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
                if (c != null)
                {
                    c.Email = customer.Email;
                    c.FirstName = customer.FirstName;
                    c.LastName = customer.LastName;
                    c.State = customer.State;
                }
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View("Edit", new Customer());
        }

        public IActionResult Delete(int cid)
        {
            Customer c = db.Customers.Find(cid);
            db.Customers.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}