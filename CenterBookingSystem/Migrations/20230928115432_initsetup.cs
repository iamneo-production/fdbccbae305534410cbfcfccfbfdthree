using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CenterBookingSystem.Migrations
{
    public partial class initsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventSpaces",
                columns: table => new
                {
                    SpaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventSpaces", x => x.SpaceID);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpaceID = table.Column<int>(type: "int", nullable: false),
                    OrgaizerID = table.Column<int>(type: "int", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeSlot = table.Column<TimeSpan>(type: "time", nullable: false),
                    EventSpaceSpaceID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Bookings_EventSpaces_EventSpaceSpaceID",
                        column: x => x.EventSpaceSpaceID,
                        principalTable: "EventSpaces",
                        principalColumn: "SpaceID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_EventSpaceSpaceID",
                table: "Bookings",
                column: "EventSpaceSpaceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "EventSpaces");
        }
    }
}
