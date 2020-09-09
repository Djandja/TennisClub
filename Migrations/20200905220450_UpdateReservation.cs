using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisClub.Migrations
{
    public partial class UpdateReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Reservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateReservation",
                table: "Reservations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDateReservation",
                table: "Reservations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDateReservation",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "StartDateReservation",
                table: "Reservations");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
