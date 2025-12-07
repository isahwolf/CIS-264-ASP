using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportStore.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Watersports", "A boat for one person", "Kayak", 275m },
                    { 2, "Watersports", "Protective and fashionable", "Lifejacket", 48.95m },
                    { 3, "Soccer", "FIF-approved size and weight", "Soccer Ball", 19.50m },
                    { 4, "Soccer", "Give your playing field a professional touch", "Corner Flags", 34.95m },
                    { 5, "Soccer", "Flat-packed 35,000-seat stadium", "Stadium", 79500m },
                    { 6, "Chess", "Improve brain efficiency by 75%", "Thinking Cap", 16m },
                    { 7, "Chess", "Secretly give your opponent a disadvantage", "Unsteady Chair", 29.95m },
                    { 8, "Chess", "A fun game for the family", "Human Chess Board", 75m },
                    { 9, "Chess", "Gold Platted, diamond-studded King", "Bling Bling King", 1200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
