using Microsoft.EntityFrameworkCore.Migrations;

namespace NTHanh777.Migrations
{
    public partial class Create_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NVN123",
                columns: table => new
                {
                    NVNId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NVNName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NVN123", x => x.NVNId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NVN123");
        }
    }
}
