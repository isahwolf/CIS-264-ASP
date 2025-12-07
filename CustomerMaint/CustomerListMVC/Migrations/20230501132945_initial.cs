using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustomerListMVC.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Email", "FirstName", "LastName", "State" },
                values: new object[,]
                {
                    { 1, "PaulPlodder@student.swic.edu", "Paul", "Plodder", "MO" },
                    { 2, "GeorgeArfuss@student.swic.edu", "George", "Arfuss", "MO" },
                    { 3, "TomTurtle@student.swic.edu", "Tom", "Turtle", "MO" },
                    { 4, "WilliamJones@student.swic.edu", "William", "Jones", "MO" },
                    { 5, "JohnJones@student.swic.edu", "John", "Jones", "MO" },
                    { 6, "AnthonyJones@student.swic.edu", "Anthony", "Jones", "MO" },
                    { 7, "KyleJones@student.swic.edu", "Kyle", "Jones", "MO" },
                    { 8, "KelleyBerty@student.swic.edu", "Kelley", "Berty", "MO" },
                    { 9, "GeorgeMacElroy@student.swic.edu", "George", "MacElroy", "IL" },
                    { 10, "JamesMcDunnel@student.swic.edu", "James", "McDunnel", "MO" },
                    { 11, "ThomasMcDunnel@student.swic.edu", "Thomas", "McDunnel", "MO" },
                    { 12, "ThomasSmith@student.swic.edu", "Thomas", "Smith", "MO" },
                    { 13, "MartinJukes@student.swic.edu", "Martin", "Jukes", "MO" },
                    { 14, "AugustSmith@student.swic.edu", "August", "Smith", "MO" },
                    { 15, "RichardArfuss@student.swic.edu", "Richard", "Arfuss", "IL" },
                    { 16, "SeanArfuss@student.swic.edu", "Sean", "Arfuss", "MO" },
                    { 17, "ArthurMueller@student.swic.edu", "Arthur", "Mueller", "MO" },
                    { 18, "JamesMiller@student.swic.edu", "James", "Miller", "MO" },
                    { 19, "DanielMueller@student.swic.edu", "Daniel", "Mueller", "MO" },
                    { 20, "ThomasSmith@student.swic.edu", "Thomas", "Smith", "MO" },
                    { 21, "MichaelMilkwagin@student.swic.edu", "Michael", "Milkwagin", "MO" },
                    { 22, "MichaelNeuner@student.swic.edu", "Michael", "Neuner", "MO" },
                    { 23, "KennOrtega@student.swic.edu", "Kenn", "Ortega", "IL" },
                    { 24, "PhilWill@student.swic.edu", "Phil", "Will", "MO" },
                    { 25, "SallySellum@student.swic.edu", "Sally", "Sellum", "MO" },
                    { 26, "BarneyVarfuss@student.swic.edu", "Barney", "Varfuss", "MO" },
                    { 27, "JosephTummyfill@student.swic.edu", "Joseph", "Tummyfill", "Mo" },
                    { 28, "SteveRockford@student.swic.edu", "Steve", "Rockford", "IL" },
                    { 29, "DanielDaly@student.swic.edu", "Daniel", "Daly", "MO" },
                    { 30, "SalvatoreMalt@student.swic.edu", "Salvatore", "Malt", "MO" },
                    { 31, "RichardSmythe@student.swic.edu", "Richard", "Smythe", "MO" },
                    { 32, "ThomasSmiley@student.swic.edu", "Thomas", "Smiley", "IL" },
                    { 33, "GeorgeRockford@student.swic.edu", "George", "Rockford", "MO" },
                    { 34, "JeffreyFawlty@student.swic.edu", "Jeffrey", "Fawlty", "MO" },
                    { 35, "DanielSteadman@student.swic.edu", "Daniel", "Steadman", "MO" },
                    { 36, "GregoryJones@student.swic.edu", "Gregory", "Jones", "MO" },
                    { 37, "GregoryEliot@student.swic.edu", "Gregory", "Eliot", "MO" },
                    { 38, "JeffreyWillow@student.swic.edu", "Jeffrey", "Willow", "MO" },
                    { 39, "RobertStiner@student.swic.edu", "Robert", "Stiner", "MO" },
                    { 40, "LawrenceNessman@student.swic.edu", "Lawrence", "Nessman", "MO" },
                    { 41, "RobertSulley@student.swic.edu", "Robert", "Sulley", "MO" },
                    { 42, "LeonardBirdwall@student.swic.edu", "Leonard", "Birdwall", "MO" },
                    { 43, "TerryKubick@student.swic.edu", "Terry", "Kubick", "IL" },
                    { 44, "JamesWebster@student.swic.edu", "James", "Webster", "MO" },
                    { 45, "ArthurWaffles@student.swic.edu", "Arthur", "Waffles", "MO" },
                    { 46, "MerrellVarfuss@student.swic.edu", "Merrell", "Varfuss", "MO" },
                    { 47, "JamesWilliams@student.swic.edu", "James", "Williams", "MO" },
                    { 48, "RobertWalleye@student.swic.edu", "Robert", "Walleye", "MO" },
                    { 49, "KennyFeltz@student.swic.edu", "Kenny", "Feltz", "MO" },
                    { 50, "AndrewVarfuss@student.swic.edu", "Andrew", "Varfuss", "MO" },
                    { 51, "TerryFitzgerald@student.swic.edu", "Terry", "Fitzgerald", "MO" },
                    { 52, "LawrenceWiner@student.swic.edu", "Lawrence", "Winer", "MO" },
                    { 53, "SteveMaverick@student.swic.edu", "Steve", "Maverick", "IL" },
                    { 54, "KarlKong@student.swic.edu", "Karl", "Kong", "MO" },
                    { 55, "JosephWiliams@student.swic.edu", "Joseph", "Wiliams", "MO" },
                    { 56, "JulesBilliard@student.swic.edu", "Jules", "Billiard", "MO" },
                    { 57, "MichaelSmith@student.swic.edu", "Michael", "Smith", "IL" },
                    { 58, "JosephJones@student.swic.edu", "Joseph", "Jones", "MO" },
                    { 59, "JamesCaline@student.swic.edu", "James", "Caline", "MO" },
                    { 60, "KevinPlodder@student.swic.edu", "Kevin", "Plodder", "MO" },
                    { 61, "KimTaylor@student.swic.edu", "Kim", "Taylor", "MO" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateID", "StateName" },
                values: new object[,]
                {
                    { "AK", "Alaska" },
                    { "AL", "Alabama" },
                    { "AR", "Arkansas" },
                    { "AZ", "Arizona" },
                    { "CA", "California" },
                    { "CO", "Colorado" },
                    { "CT", "Connecticut" },
                    { "DC", "District of Columbia" },
                    { "DE", "Delaware" },
                    { "FL", "Florida" },
                    { "GA", "Georgia" },
                    { "HI", "Hawaii" },
                    { "IA", "Iowa" },
                    { "ID", "Idaho" },
                    { "IL", "Illinois" },
                    { "IN", "Indiana" },
                    { "KS", "Kansas" },
                    { "KY", "Kentucky" },
                    { "LA", "Lousiana" },
                    { "MA", "Massachusetts" },
                    { "MD", "Maryland" },
                    { "ME", "Maine" },
                    { "MI", "Michigan" },
                    { "MN", "Minnesota" },
                    { "MO", "Missouri" },
                    { "MS", "Mississippi" },
                    { "MT", "Montana" },
                    { "NC", "North Carolina" },
                    { "ND", "North Dakota" },
                    { "NE", "Nebraska" },
                    { "NH", "New Hampshire" },
                    { "NJ", "New Jersey" },
                    { "NM", "New Mexico" },
                    { "NV", "Nevada" },
                    { "NY", "New York" },
                    { "OH", "Ohio" },
                    { "OK", "Oklahoma" },
                    { "OR", "Oregon" },
                    { "PA", "Pennsylvania" },
                    { "RI", "Rhode Island" },
                    { "SC", "South Carolina" },
                    { "SD", "South Dakota" },
                    { "TN", "Tennessee" },
                    { "TX", "Texas" },
                    { "UT", "Utah" },
                    { "VA", "Virginia" },
                    { "VI", "Virgin Islands" },
                    { "VT", "Vermont" },
                    { "WA", "Washington" },
                    { "WI", "Wisconsin" },
                    { "WV", "West Virginia" },
                    { "WY", "Wyoming" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
