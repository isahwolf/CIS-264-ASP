using Microsoft.AspNetCore.Mvc.Rendering;

namespace SportStore.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = new List<Product>();

        public IEnumerable<string> Category { get; set; }
    }
}
