using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using System.Diagnostics;

namespace SportStore.Controllers
{
    public class HomeController : Controller
    {

        SportStoreContext db ;

        public HomeController(SportStoreContext context)
        {
            db = context;
        }


        public IActionResult Index()
        {
            return View(db.Products);
        }

    }
}