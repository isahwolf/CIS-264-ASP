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
            new Customer {LastName = "Plodder", FirstName = "Paul", Email = "PaulPlodder@student.swic.edu", State = "MO"},
            new Customer {LastName = "Arfuss", FirstName = "George", Email = "GeorgeArfuss@student.swic.edu", State = "MO"},
            new Customer {LastName = "Turtle", FirstName = "Tom", Email = "TomTurtle@student.swic.edu", State = "MO"},
            new Customer {LastName = "Jones", FirstName = "William", Email = "WilliamJones@student.swic.edu", State = "MO"},
            new Customer {LastName = "Jones", FirstName = "John", Email = "JohnJones@student.swic.edu", State = "MO"},
            new Customer {LastName = "Jones", FirstName = "Anthony", Email = "AnthonyJones@student.swic.edu", State = "MO"},
            new Customer {LastName = "Jones", FirstName = "Kyle", Email = "KyleJones@student.swic.edu", State = "MO"},
            new Customer {LastName = "Berty", FirstName = "Kelley", Email = "KelleyBerty@student.swic.edu", State = "MO"},
            new Customer {LastName = "MacElroy", FirstName = "George", Email = "GeorgeMacElroy@student.swic.edu", State = "IL"},
            new Customer {LastName = "McDunnel", FirstName = "James", Email = "JamesMcDunnel@student.swic.edu", State = "MO"},
            new Customer {LastName = "McDunnel", FirstName = "Thomas", Email = "ThomasMcDunnel@student.swic.edu", State = "MO"},
            new Customer {LastName = "Smith", FirstName = "Thomas", Email = "ThomasSmith@student.swic.edu", State = "MO"},
            new Customer {LastName = "Jukes", FirstName = "Martin", Email = "MartinJukes@student.swic.edu", State = "MO"},
            new Customer {LastName = "Smith", FirstName = "August", Email = "AugustSmith@student.swic.edu", State = "MO"},
            new Customer {LastName = "Arfuss", FirstName = "Richard", Email = "RichardArfuss@student.swic.edu", State = "IL"},
            new Customer {LastName = "Arfuss", FirstName = "Sean", Email = "SeanArfuss@student.swic.edu", State = "MO"},
            new Customer {LastName = "Mueller", FirstName = "Arthur", Email = "ArthurMueller@student.swic.edu", State = "MO"},
            new Customer {LastName = "Miller", FirstName = "James", Email = "JamesMiller@student.swic.edu", State = "MO"},
            new Customer {LastName = "Mueller", FirstName = "Daniel", Email = "DanielMueller@student.swic.edu", State = "MO"},
            new Customer {LastName = "Milkwagin", FirstName = "Michael", Email = "MichaelMilkwagin@student.swic.edu", State = "MO"},
            new Customer {LastName = "Neuner", FirstName = "Michael", Email = "MichaelNeuner@student.swic.edu", State = "MO"},
            new Customer {LastName = "Ortega", FirstName = "Kenn", Email = "KennOrtega@student.swic.edu", State = "IL"},
            new Customer {LastName = "Will", FirstName = "Phil", Email = "PhilWill@student.swic.edu", State = "MO"},
            new Customer {LastName = "Sellum", FirstName = "Sally", Email = "SallySellum@student.swic.edu", State = "MO"},
            new Customer {LastName = "Varfuss", FirstName = "Barney", Email = "BarneyVarfuss@student.swic.edu", State = "MO"},
            new Customer {LastName = "Tummyfill", FirstName = "Joseph", Email = "JosephTummyfill@student.swic.edu", State = "Mo"},
            new Customer {LastName = "Rockford", FirstName = "Steve", Email = "SteveRockford@student.swic.edu", State = "IL"},
            new Customer {LastName = "Daly", FirstName = "Daniel", Email = "DanielDaly@student.swic.edu", State = "MO"},
            new Customer {LastName = "Malt", FirstName = "Salvatore", Email = "SalvatoreMalt@student.swic.edu", State = "MO"},
            new Customer {LastName = "Smith", FirstName = "Thomas", Email = "ThomasSmith@student.swic.edu", State = "MO"},
            new Customer {LastName = "Smythe", FirstName = "Richard", Email = "RichardSmythe@student.swic.edu", State = "MO"},
            new Customer {LastName = "Smiley", FirstName = "Thomas", Email = "ThomasSmiley@student.swic.edu", State = "IL"},
            new Customer {LastName = "Rockford", FirstName = "George", Email = "GeorgeRockford@student.swic.edu", State = "MO"},
            new Customer {LastName = "Fawlty", FirstName = "Jeffrey", Email = "JeffreyFawlty@student.swic.edu", State = "MO"},
            new Customer {LastName = "Steadman", FirstName = "Daniel", Email = "DanielSteadman@student.swic.edu", State = "MO"},
            new Customer {LastName = "Jones", FirstName = "Gregory", Email = "GregoryJones@student.swic.edu", State = "MO"},
            new Customer {LastName = "Eliot", FirstName = "Gregory", Email = "GregoryEliot@student.swic.edu", State = "MO"},
            new Customer {LastName = "Willow", FirstName = "Jeffrey", Email = "JeffreyWillow@student.swic.edu", State = "MO"},
            new Customer {LastName = "Stiner", FirstName = "Robert", Email = "RobertStiner@student.swic.edu", State = "MO"},
            new Customer {LastName = "Nessman", FirstName = "Lawrence", Email = "LawrenceNessman@student.swic.edu", State = "MO"},
            new Customer {LastName = "Sulley", FirstName = "Robert", Email = "RobertSulley@student.swic.edu", State = "MO"},
            new Customer {LastName = "Birdwall", FirstName = "Leonard", Email = "LeonardBirdwall@student.swic.edu", State = "MO"},
            new Customer {LastName = "Kubick", FirstName = "Terry", Email = "TerryKubick@student.swic.edu", State = "IL"},
            new Customer {LastName = "Webster", FirstName = "James", Email = "JamesWebster@student.swic.edu", State = "MO"},
            new Customer {LastName = "Waffles", FirstName = "Arthur", Email = "ArthurWaffles@student.swic.edu", State = "MO"},
            new Customer {LastName = "Varfuss", FirstName = "Merrell", Email = "MerrellVarfuss@student.swic.edu", State = "MO"},
            new Customer {LastName = "Williams", FirstName = "James", Email = "JamesWilliams@student.swic.edu", State = "MO"},
            new Customer {LastName = "Walleye", FirstName = "Robert", Email = "RobertWalleye@student.swic.edu", State = "MO"},
            new Customer {LastName = "Feltz", FirstName = "Kenny", Email = "KennyFeltz@student.swic.edu", State = "MO"},
            new Customer {LastName = "Varfuss", FirstName = "Andrew", Email = "AndrewVarfuss@student.swic.edu", State = "MO"},
            new Customer {LastName = "Fitzgerald", FirstName = "Terry", Email = "TerryFitzgerald@student.swic.edu", State = "MO"},
            new Customer {LastName = "Winer", FirstName = "Lawrence", Email = "LawrenceWiner@student.swic.edu", State = "MO"},
            new Customer {LastName = "Maverick", FirstName = "Steve", Email = "SteveMaverick@student.swic.edu", State = "IL"},
            new Customer {LastName = "Kong", FirstName = "Karl", Email = "KarlKong@student.swic.edu", State = "MO"},
            new Customer {LastName = "Wiliams", FirstName = "Joseph", Email = "JosephWiliams@student.swic.edu", State = "MO"},
            new Customer {LastName = "Billiard", FirstName = "Jules", Email = "JulesBilliard@student.swic.edu", State = "MO"},
            new Customer {LastName = "Smith", FirstName = "Michael", Email = "MichaelSmith@student.swic.edu", State = "IL"},
            new Customer {LastName = "Jones", FirstName = "Joseph", Email = "JosephJones@student.swic.edu", State = "MO"},
            new Customer {LastName = "Caline", FirstName = "James", Email = "JamesCaline@student.swic.edu", State = "MO"},
            new Customer {LastName = "Plodder", FirstName = "Kevin", Email = "KevinPlodder@student.swic.edu", State = "MO"},
            new Customer {LastName = "Taylor", FirstName = "Kim", Email = "KimTaylor@student.swic.edu", State = "MO"},
        };



    }
}
