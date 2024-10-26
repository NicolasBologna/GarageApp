using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addseedactiveparking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parkings",
                columns: new[] { "Id", "Cost", "EntryTime", "EntryUserId", "ExitTime", "ExitUserId", "IsDeleted", "LicensePlate", "ParkingSpotId" },
                values: new object[,]
                {
                    { 3, null, "2024-10-01T09:00:00", "1", null, null, false, "GHY456", 1 },
                    { 4, null, "2022-11-01T09:00:00", "1", null, null, false, "AGR405", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
