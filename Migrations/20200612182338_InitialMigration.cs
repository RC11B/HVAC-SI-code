using Microsoft.EntityFrameworkCore.Migrations;

namespace Pro11WA.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Furnaces",
                columns: table => new
                {
                    furnaceid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brand = table.Column<string>(nullable: true),
                    companyid = table.Column<string>(nullable: false),
                    modelnumber = table.Column<string>(nullable: false),
                    serialnumber = table.Column<string>(nullable: true),
                    tonnage = table.Column<double>(nullable: false),
                    size = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnaces", x => x.furnaceid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Furnaces");
        }
    }
}
