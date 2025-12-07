using CustomerListMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomerListMVC.Controllers
{
    public class HomeController : Controller
    {
        List<Customer> custs = CustomerList.Customers;

        CustomerContext db;

        public HomeController(CustomerContext context)
        {
            db = context;
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View(custs);
        //}
        //[HttpPost]
        public IActionResult Index(string state)
        {
            return View(custs.Where(c => c.State == state || state == null));
        }
    }
}