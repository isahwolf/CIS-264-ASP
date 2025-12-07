namespace CustSurveyMVC.Models
{
    public class CustomerSurveyViewModel
    {
        public IEnumerable<Customer> Customers { get; set; } = new List<Customer>();
        public Survey Survey { get; set; }
    }
}
