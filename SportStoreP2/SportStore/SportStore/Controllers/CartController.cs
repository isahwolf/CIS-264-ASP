using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportStore.Models;

namespace SportStore.Controllers
{
    public class CartController : Controller
    {
        SportStoreContext db;

        public CartController(SportStoreContext context)
        {
            db = context;
        }

        public RedirectToActionResult AddToCart(int pid)
        {
            Product product = db.Products.Where(p => p.ProductId == pid).First();

            List<Product> cart;
            if (HttpContext.Session.GetJson<List<Product>>("Cart") == null)
            {
                cart = new List<Product>();
            }
            else
            {
                cart = HttpContext.Session.GetJson<List<Product>>("Cart");
            }


            Product line = cart.Where(x =>  x.ProductId == pid).FirstOrDefault();
            if (line == null)
            {
                cart.Add(product);
            }

            HttpContext.Session.SetJason("Cart", cart);

            return RedirectToAction("Cart");
        }

        public IActionResult Cart() 
        {
            List<Product> cart;
            if (HttpContext.Session.GetJson<List<Product>>("Cart") == null)
            { 
                cart = new List<Product>();
            }
            else
            {
                cart = HttpContext.Session.GetJson<List<Product>>("Cart");
            }

            return View(new ProductsListViewModel()
            {
                Products = cart,
                Category = db.Products.Select(p => p.Category).Distinct()
            });
        }
    }
}
