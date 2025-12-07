using Microsoft.AspNetCore.Mvc.Rendering;

namespace CustomerListMVC.Models
{
    public class ListViewModel
    {
        public List<Customer> Customers {  get; set; } = new List<Customer>();
        public SelectList States { get; set; }

    }
}
