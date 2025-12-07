using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CustSurveyMVC.Migrations
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    SurveyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<int>(type: "int", nullable: false),
                    Response = table.Column<int>(type: "int", nullable: false),
                    Efficiency = table.Column<int>(type: "int", nullable: false),
                    Resolution = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.SurveyID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "City", "Email", "Name", "Phone", "State" },
                values: new object[,]
                {
                    { 1, "PO Box 96621", "Washington", "ania@mma.nidc.com", "Ania Irvin", "(301) 555-8950", "DC" },
                    { 2, "1990 Westwood Blvd Ste 260", "Los Angeles", "kenzie@mma.jobtrak.com", "Kenzie Quinn", "(800) 555-8725", "CA" },
                    { 3, "3255 Ramos Cir", "Sacramento", "amauro@mma.ccc.org", "Anton Mauro", "(916) 555-6670", "CA" },
                    { 4, "Box 52001", "San Francisco", "kanthoni@mma.pge.com", "Kaitlyn Anthoni", "(800) 555-6081", "CA" },
                    { 5, "7700 Forsyth", "St Louis", "malia@mma.TheLibraryLtd.com", "Malia Marques", "(314) 555-8834", "MO" },
                    { 6, "1555 W Lane Ave", "Columbus", "Emily@mma.MicroCenter.com", "Emily Evan", "(614) 555-4435", "OH" },
                    { 7, "12 Daniel Road", "Fairfield", "Ingrid@mma.richadvertizing.com", "Ingrid Neil", "(201) 555-9742", "NJ" },
                    { 8, "1483 Chain Bridge Rd, Ste 202", "Mclean", "eLawrence@mma.ecomm.com", "Eileen Lawrence", "eLawrence@mma.ecomm.com", "VA" },
                    { 9, "PO Box 31", "East Brunswick", "messence@mma.rrbowker.com", "Marjorie Essence", "(800) 555-8110", "NJ" },
                    { 10, "60 Madison Ave", "New York", "tneftaly@mma.venture.com", "Thalia Neftaly", "(212) 555-4800", "NY" },
                    { 11, "PO Box 7028", "St Louis", "harley@mma.cprinting.com", "Harley Myles", "(301) 555-1494", "MO" },
                    { 12, "PO Box 39046", "Minneapolis", "jmaxwell@mma.ccredit.com", "Jayda Maxwell", "(612) 555-0057", "MN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
