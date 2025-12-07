namespace CustSurveyMVC.Models
{
    public class FakeCustomerRepository
    {

        public static List<Customer> Customers = new List<Customer>
        {
            new Customer {
                CustomerID = 1,Name = "Ania Irvin", Phone = "(301) 555-8950",
                Address="PO Box 96621", City="Washington",
                State = "DC",Email="ania@mma.nidc.com" },
            new Customer {
                CustomerID = 2,Name = "Kenzie Quinn", Phone = "(800) 555-8725",
                Address="1990 Westwood Blvd Ste 260", City="Los Angeles",
                State = "CA",Email="kenzie@mma.jobtrak.com" },
            new Customer {
                CustomerID = 3,Name = "Anton Mauro", Phone = "(916) 555-6670",
                 Address="3255 Ramos Cir", City="Sacramento",
               State = "CA",Email="amauro@mma.ccc.org" },
            new Customer {
                CustomerID = 4,Name = "Kaitlyn Anthoni", Phone = "(800) 555-6081",
                Address="Box 52001", City="San Francisco",
                State = "CA",Email="kanthoni@mma.pge.com" },
            new Customer {
                CustomerID = 5,Name = "Malia Marques", Phone = "(314) 555-8834",
                Address="7700 Forsyth", City="St Louis",
                State = "MO",Email="malia@mma.TheLibraryLtd.com" },
            new Customer {
                CustomerID = 6,Name = "Emily Evan", Phone = "(614) 555-4435",
                Address="1555 W Lane Ave", City="Columbus",
                State = "OH",Email="Emily@mma.MicroCenter.com" },
            new Customer {
                CustomerID = 7,Name = "Ingrid Neil", Phone = "(201) 555-9742",
                Address="12 Daniel Road", City="Fairfield",
                State = "NJ",Email="Ingrid@mma.richadvertizing.com" },
            new Customer {
                CustomerID = 8,Name = "Eileen Lawrence", Phone = "eLawrence@mma.ecomm.com",
                Address="1483 Chain Bridge Rd, Ste 202", City="Mclean",
                State = "VA",Email="eLawrence@mma.ecomm.com" },
            new Customer {
                CustomerID = 9,Name = "Marjorie Essence", Phone = "(800) 555-8110",
                Address="PO Box 31", City="East Brunswick",
                State = "NJ",Email="messence@mma.rrbowker.com" },
            new Customer {
                CustomerID = 10,Name = "Thalia Neftaly", Phone = "(212) 555-4800",
                Address="60 Madison Ave", City="New York",
                State = "NY",Email="tneftaly@mma.venture.com" },
            new Customer {
                CustomerID = 11,Name = "Harley Myles", Phone = "(301) 555-1494",
                Address="PO Box 7028", City="St Louis",
                State = "MO",Email="harley@mma.cprinting.com" },
            new Customer {
                CustomerID = 12,Name = "Jayda Maxwell", Phone = "(612) 555-0057",
                Address="PO Box 39046", City="Minneapolis",
                State = "MN",Email="jmaxwell@mma.ccredit.com" }
        };

    }
}
