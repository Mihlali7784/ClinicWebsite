using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PHCApplication.Migrations
{
    public partial class avail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvailVacc",
                schema: "Identity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailVacc", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailVacc",
                schema: "Identity");
        }
    }
}
