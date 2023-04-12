using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Djvaleting.Server.Migrations
{
    public partial class DjvaletingServerAppDbContextApplicationDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "valeting");

            migrationBuilder.CreateTable(
                name: "Account",
                schema: "valeting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValetBooking",
                schema: "valeting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Flexibility = table.Column<int>(type: "int", nullable: false),
                    VehicleSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValetBooking", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "valeting",
                table: "Account",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "066591C0952CF23C410C267525704D9451B803983EB68319CED1BCDC2E6365EED5AA70A0279709837C55C02A219EF0DFBD54E79302D7687277731C99D466E972", "djvalte" });

            migrationBuilder.InsertData(
                schema: "valeting",
                table: "ValetBooking",
                columns: new[] { "Id", "BookingDate", "ContactNumber", "EmailAddress", "Flexibility", "Name", "VehicleSize" },
                values: new object[] { 1, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "999-888-7777", "uncle.bob@gmail.com", 3, "Uncle Bob", "Large" });

            migrationBuilder.InsertData(
                schema: "valeting",
                table: "ValetBooking",
                columns: new[] { "Id", "BookingDate", "ContactNumber", "EmailAddress", "Flexibility", "Name", "VehicleSize" },
                values: new object[] { 2, new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "111-222-3333", "jan.kirsten@gmail.com", 1, "Jan Kirsten", "Medium" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account",
                schema: "valeting");

            migrationBuilder.DropTable(
                name: "ValetBooking",
                schema: "valeting");
        }
    }
}
