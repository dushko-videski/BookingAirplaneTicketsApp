using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingAirplaneTickets.DomainModels.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirLine = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PassportNo = table.Column<string>(nullable: false),
                    Origin = table.Column<string>(nullable: false),
                    Destination = table.Column<string>(nullable: false),
                    Departure = table.Column<DateTime>(nullable: false),
                    Return = table.Column<DateTime>(nullable: false),
                    FreeCarryOnBag = table.Column<int>(nullable: false),
                    TrolleyBag = table.Column<int>(nullable: false),
                    CheckedInBag = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false),
                    LoyalMemberId = table.Column<int>(nullable: false),
                    UseLoyalMemberCredits = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "AirLine", "CheckedInBag", "CreatedOn", "DateOfBirth", "Departure", "Destination", "FirstName", "FreeCarryOnBag", "LastName", "LoyalMemberId", "Origin", "PassportNo", "Return", "TrolleyBag", "UpdatedOn", "UseLoyalMemberCredits" },
                values: new object[] { 1, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami", "Dushko", 1, "Videski", 0, "Skopje", "B123456789", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "AirLine", "CheckedInBag", "CreatedOn", "DateOfBirth", "Departure", "Destination", "FirstName", "FreeCarryOnBag", "LastName", "LoyalMemberId", "Origin", "PassportNo", "Return", "TrolleyBag", "UpdatedOn", "UseLoyalMemberCredits" },
                values: new object[] { 2, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami", "Ljupka", 2, "Postolova", 123456, "Skopje", "B987654321", new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");
        }
    }
}
