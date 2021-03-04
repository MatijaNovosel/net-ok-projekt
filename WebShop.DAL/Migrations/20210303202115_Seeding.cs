using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShop.DAL.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "Discount", "MadeAt", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Monitor 1 description", 0.0, new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor 1", 2000.5 },
                    { 2, "Monitor 2 description", 0.0, new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor 2", 2500.5 },
                    { 3, "Monitor 3 description", 0.0, new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor 3", 1060.5 },
                    { 4, "Monitor 4 description", 0.0, new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor 4", 1006.5 },
                    { 5, "Monitor 5 description", 0.0, new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor 5", 5000.5 },
                    { 6, "Monitor 6 description", 0.0, new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor 6", 1020.5 },
                    { 7, "Monitor 7 description", 0.0, new DateTime(1969, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monitor 7", 220.5 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Monitor" },
                    { 2, "Graphics card" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
