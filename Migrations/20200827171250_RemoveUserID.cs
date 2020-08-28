using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisClub.Migrations
{
    public partial class RemoveUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserID",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Reservations",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserID",
                table: "Reservations",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserID",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserID",
                table: "Reservations",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
