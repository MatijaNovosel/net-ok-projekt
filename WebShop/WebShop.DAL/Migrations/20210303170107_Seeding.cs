using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.DAL.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Discount", "Name", "Price" },
                values: new object[,]
                {
                    { 2, "Monitor 2 description", 0.0, "Monitor 2", 2500.5 },
                    { 3, "Monitor 3 description", 0.0, "Monitor 3", 1060.5 },
                    { 4, "Monitor 4 description", 0.0, "Monitor 4", 1006.5 },
                    { 5, "Monitor 5 description", 0.0, "Monitor 5", 5000.5 },
                    { 6, "Monitor 6 description", 0.0, "Monitor 6", 1020.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
