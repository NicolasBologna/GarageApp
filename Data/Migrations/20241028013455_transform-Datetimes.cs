using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class transformDatetimes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EntryTime", "ExitTime" },
                values: new object[] { new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EntryTime", "ExitTime" },
                values: new object[] { new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EntryTime", "ExitTime" },
                values: new object[] { new DateTime(2024, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EntryTime", "ExitTime" },
                values: new object[] { new DateTime(2022, 11, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EntryTime", "ExitTime" },
                values: new object[] { "2023-10-01T08:00:00", "2023-10-01T10:00:00" });

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EntryTime", "ExitTime" },
                values: new object[] { "2023-10-01T09:00:00", "2023-10-01T11:00:00" });

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EntryTime", "ExitTime" },
                values: new object[] { "2024-10-01T09:00:00", null });

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EntryTime", "ExitTime" },
                values: new object[] { "2022-11-01T09:00:00", null });
        }
    }
}
