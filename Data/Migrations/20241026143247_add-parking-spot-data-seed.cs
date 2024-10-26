using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addparkingspotdataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ParkingSpots",
                columns: new[] { "Id", "Deleted", "Description", "Disabled" },
                values: new object[,]
                {
                    { 1, 0, "1A", 0 },
                    { 2, 0, "1B", 0 },
                    { 3, 0, "1C", 0 },
                    { 4, 0, "2A", 0 }
                });

            migrationBuilder.InsertData(
                table: "Parkings",
                columns: new[] { "Id", "Cost", "EntryTime", "EntryUserId", "ExitTime", "ExitUserId", "IsDeleted", "LicensePlate", "ParkingSpotId" },
                values: new object[,]
                {
                    { 1, 20.0, "2023-10-01T08:00:00", "1", "2023-10-01T10:00:00", "1", false, "ABC123", 1 },
                    { 2, 20.0, "2023-10-01T09:00:00", "1", "2023-10-01T11:00:00", "1", false, "DEF456", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkingSpots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkingSpots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkingSpots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkingSpots",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
