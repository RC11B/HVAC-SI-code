using Microsoft.EntityFrameworkCore.Migrations;

namespace Pro11WA.Migrations
{
    public partial class AddedManufacturers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "modelnumber",
                table: "Furnaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "companyid",
                table: "Furnaces",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Furnaces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "manufacturersCompanyId",
                table: "Furnaces",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyProducts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.CompanyId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Furnaces_manufacturersCompanyId",
                table: "Furnaces",
                column: "manufacturersCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Furnaces_Manufacturers_manufacturersCompanyId",
                table: "Furnaces",
                column: "manufacturersCompanyId",
                principalTable: "Manufacturers",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Furnaces_Manufacturers_manufacturersCompanyId",
                table: "Furnaces");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropIndex(
                name: "IX_Furnaces_manufacturersCompanyId",
                table: "Furnaces");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Furnaces");

            migrationBuilder.DropColumn(
                name: "manufacturersCompanyId",
                table: "Furnaces");

            migrationBuilder.AlterColumn<string>(
                name: "modelnumber",
                table: "Furnaces",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "companyid",
                table: "Furnaces",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
