using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PHCApplication.Migrations
{
    public partial class tryrt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Discharge",
                newName: "DischargeId");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Discharge",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Discharge",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Discharge_UserID",
                table: "Discharge",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Discharge_AspNetUsers_UserID",
                table: "Discharge",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discharge_AspNetUsers_UserID",
                table: "Discharge");

            migrationBuilder.DropIndex(
                name: "IX_Discharge_UserID",
                table: "Discharge");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Discharge");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Discharge");

            migrationBuilder.RenameColumn(
                name: "DischargeId",
                table: "Discharge",
                newName: "Id");
        }
    }
}
