using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PHCApplication.Migrations
{
    public partial class drgt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Doctor");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctor",
                newName: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoctorId",
                table: "Doctor",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Doctor",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Doctor",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
