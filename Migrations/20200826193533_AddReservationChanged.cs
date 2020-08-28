using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisClub.Migrations
{
    public partial class AddReservationChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsFullDay",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "IsFullDay",
                table: "Reservations",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
