using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisClub.Migrations
{
    public partial class eReservationsTableAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFullDay",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ThemeColor",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Court",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Court",
                table: "Reservations");

            migrationBuilder.AddColumn<bool>(
                name: "IsFullDay",
                table: "Reservations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ThemeColor",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
