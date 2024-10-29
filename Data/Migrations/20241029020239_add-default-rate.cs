using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class adddefaultrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RateId",
                table: "Parkings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 1,
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 2,
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 3,
                column: "RateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Parkings",
                keyColumn: "Id",
                keyValue: 4,
                column: "RateId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_RateId",
                table: "Parkings",
                column: "RateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parkings_Rates_RateId",
                table: "Parkings",
                column: "RateId",
                principalTable: "Rates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parkings_Rates_RateId",
                table: "Parkings");

            migrationBuilder.DropIndex(
                name: "IX_Parkings_RateId",
                table: "Parkings");

            migrationBuilder.DropColumn(
                name: "RateId",
                table: "Parkings");
        }
    }
}
