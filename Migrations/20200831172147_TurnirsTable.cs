using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisClub.Migrations
{
    public partial class TurnirsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "Turnirs",
                columns: table => new
                {
                    TurnirID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurnirsTitle = table.Column<string>(maxLength: 50, nullable: false),
                    Progress = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    NumberOfParticipants = table.Column<int>(nullable: false),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnirs", x => x.TurnirID);
                    table.ForeignKey(
                        name: "FK_Turnirs_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Turnirs_UserID",
                table: "Turnirs",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Turnirs");

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationID", "Description", "End", "IsFullDay", "Start", "Subject", "ThemeColor", "UserID" },
                values: new object[] { 4, "kakkaka", new DateTime(2020, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2020, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "lalal", "blue", null });
        }
    }
}
