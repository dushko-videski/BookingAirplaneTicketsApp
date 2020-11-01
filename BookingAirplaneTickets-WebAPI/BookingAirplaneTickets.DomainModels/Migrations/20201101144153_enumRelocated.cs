using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingAirplaneTickets.DomainModels.Migrations
{
    public partial class enumRelocated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 11, 1, 14, 41, 53, 441, DateTimeKind.Utc), new DateTime(2020, 11, 1, 14, 41, 53, 441, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 11, 1, 14, 41, 53, 441, DateTimeKind.Utc), new DateTime(2020, 11, 1, 14, 41, 53, 441, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 31, 21, 37, 7, 998, DateTimeKind.Utc), new DateTime(2020, 10, 31, 21, 37, 7, 998, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2020, 10, 31, 21, 37, 7, 998, DateTimeKind.Utc), new DateTime(2020, 10, 31, 21, 37, 7, 998, DateTimeKind.Utc) });
        }
    }
}
