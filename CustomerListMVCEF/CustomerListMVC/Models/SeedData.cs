namespace CustomerListMVC.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            CustomerContext db = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<CustomerContext>();

            if (!db.Customers.Any())
            {
                db.Customers.AddRange(CustomerList.Customers);
                db.SaveChanges();
            }
        }
    }
}
