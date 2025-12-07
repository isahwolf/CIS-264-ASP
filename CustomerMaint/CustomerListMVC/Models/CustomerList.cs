using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerListMVC.Models
{
    public class CustomerList
    {

        public static List<Customer> Customers = new List<Customer>
        {
            new Customer {CustomerID = 1,LastName = "Plodder", FirstName = "Paul", Email = "PaulPlodder@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 2,LastName = "Arfuss", FirstName = "George", Email = "GeorgeArfuss@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 3,LastName = "Turtle", FirstName = "Tom", Email = "TomTurtle@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 4,LastName = "Jones", FirstName = "William", Email = "WilliamJones@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 5,LastName = "Jones", FirstName = "John", Email = "JohnJones@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 6,LastName = "Jones", FirstName = "Anthony", Email = "AnthonyJones@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 7,LastName = "Jones", FirstName = "Kyle", Email = "KyleJones@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 8,LastName = "Berty", FirstName = "Kelley", Email = "KelleyBerty@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 9,LastName = "MacElroy", FirstName = "George", Email = "GeorgeMacElroy@student.swic.edu", State = "IL"},
            new Customer {CustomerID = 10,LastName = "McDunnel", FirstName = "James", Email = "JamesMcDunnel@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 11,LastName = "McDunnel", FirstName = "Thomas", Email = "ThomasMcDunnel@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 12,LastName = "Smith", FirstName = "Thomas", Email = "ThomasSmith@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 13,LastName = "Jukes", FirstName = "Martin", Email = "MartinJukes@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 14,LastName = "Smith", FirstName = "August", Email = "AugustSmith@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 15,LastName = "Arfuss", FirstName = "Richard", Email = "RichardArfuss@student.swic.edu", State = "IL"},
            new Customer {CustomerID = 16,LastName = "Arfuss", FirstName = "Sean", Email = "SeanArfuss@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 17,LastName = "Mueller", FirstName = "Arthur", Email = "ArthurMueller@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 18,LastName = "Miller", FirstName = "James", Email = "JamesMiller@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 19,LastName = "Mueller", FirstName = "Daniel", Email = "DanielMueller@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 20,LastName = "Smith", FirstName = "Thomas", Email = "ThomasSmith@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 21,LastName = "Milkwagin", FirstName = "Michael", Email = "MichaelMilkwagin@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 22,LastName = "Neuner", FirstName = "Michael", Email = "MichaelNeuner@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 23,LastName = "Ortega", FirstName = "Kenn", Email = "KennOrtega@student.swic.edu", State = "IL"},
            new Customer {CustomerID = 24,LastName = "Will", FirstName = "Phil", Email = "PhilWill@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 25,LastName = "Sellum", FirstName = "Sally", Email = "SallySellum@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 26,LastName = "Varfuss", FirstName = "Barney", Email = "BarneyVarfuss@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 27,LastName = "Tummyfill", FirstName = "Joseph", Email = "JosephTummyfill@student.swic.edu", State = "Mo"},
            new Customer {CustomerID = 28,LastName = "Rockford", FirstName = "Steve", Email = "SteveRockford@student.swic.edu", State = "IL"},
            new Customer {CustomerID = 29,LastName = "Daly", FirstName = "Daniel", Email = "DanielDaly@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 30,LastName = "Malt", FirstName = "Salvatore", Email = "SalvatoreMalt@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 31,LastName = "Smythe", FirstName = "Richard", Email = "RichardSmythe@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 32,LastName = "Smiley", FirstName = "Thomas", Email = "ThomasSmiley@student.swic.edu", State = "IL"},
            new Customer {CustomerID = 33,LastName = "Rockford", FirstName = "George", Email = "GeorgeRockford@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 34,LastName = "Fawlty", FirstName = "Jeffrey", Email = "JeffreyFawlty@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 35,LastName = "Steadman", FirstName = "Daniel", Email = "DanielSteadman@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 36,LastName = "Jones", FirstName = "Gregory", Email = "GregoryJones@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 37,LastName = "Eliot", FirstName = "Gregory", Email = "GregoryEliot@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 38,LastName = "Willow", FirstName = "Jeffrey", Email = "JeffreyWillow@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 39,LastName = "Stiner", FirstName = "Robert", Email = "RobertStiner@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 40,LastName = "Nessman", FirstName = "Lawrence", Email = "LawrenceNessman@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 41,LastName = "Sulley", FirstName = "Robert", Email = "RobertSulley@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 42,LastName = "Birdwall", FirstName = "Leonard", Email = "LeonardBirdwall@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 43,LastName = "Kubick", FirstName = "Terry", Email = "TerryKubick@student.swic.edu", State = "IL"},
            new Customer {CustomerID = 44,LastName = "Webster", FirstName = "James", Email = "JamesWebster@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 45,LastName = "Waffles", FirstName = "Arthur", Email = "ArthurWaffles@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 46,LastName = "Varfuss", FirstName = "Merrell", Email = "MerrellVarfuss@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 47,LastName = "Williams", FirstName = "James", Email = "JamesWilliams@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 48,LastName = "Walleye", FirstName = "Robert", Email = "RobertWalleye@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 49,LastName = "Feltz", FirstName = "Kenny", Email = "KennyFeltz@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 50,LastName = "Varfuss", FirstName = "Andrew", Email = "AndrewVarfuss@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 51,LastName = "Fitzgerald", FirstName = "Terry", Email = "TerryFitzgerald@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 52,LastName = "Winer", FirstName = "Lawrence", Email = "LawrenceWiner@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 53,LastName = "Maverick", FirstName = "Steve", Email = "SteveMaverick@student.swic.edu", State = "IL"},
            new Customer {CustomerID = 54,LastName = "Kong", FirstName = "Karl", Email = "KarlKong@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 55,LastName = "Wiliams", FirstName = "Joseph", Email = "JosephWiliams@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 56,LastName = "Billiard", FirstName = "Jules", Email = "JulesBilliard@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 57,LastName = "Smith", FirstName = "Michael", Email = "MichaelSmith@student.swic.edu", State = "IL"},
            new Customer {CustomerID = 58,LastName = "Jones", FirstName = "Joseph", Email = "JosephJones@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 59,LastName = "Caline", FirstName = "James", Email = "JamesCaline@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 60,LastName = "Plodder", FirstName = "Kevin", Email = "KevinPlodder@student.swic.edu", State = "MO"},
            new Customer {CustomerID = 61,LastName = "Taylor", FirstName = "Kim", Email = "KimTaylor@student.swic.edu", State = "MO"},
        };



    }
}
