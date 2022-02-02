using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MumsWhoCode.Services.Api.Migrations
{
    public partial class updateParticipant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "mobile",
                table: "Participants",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Participants",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimeZone",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "TimeZone",
                table: "Participants");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                table: "Participants",
                newName: "mobile");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Participants",
                newName: "email");
        }
    }
}
