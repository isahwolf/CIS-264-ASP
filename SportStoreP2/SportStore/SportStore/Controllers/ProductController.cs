using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        SportStoreContext db;

        public ProductController(SportStoreContext context)
        {
            db = context;
        }

        public IActionResult List(string cat)
        {
            return View(new ProductsListViewModel()
            {
                Products = db.Products.Where(p => p.Category == cat || cat == null || cat == string.Empty),
                Category = db.Products.Select(p => p.Category).Distinct()
            });
        }
    }
}
