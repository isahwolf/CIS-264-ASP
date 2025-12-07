using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;

namespace ContactListMVC.Models
{
    public class CustomerViewModel
    {
        public IEnumerable<Customer> Customers { get; set; } = new List<Customer>();

        public SelectList Name { get; set; }

        public SelectList CustomerID { get; set; }
    }
}
