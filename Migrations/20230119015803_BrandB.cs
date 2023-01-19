using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect1.Migrations
{
    public partial class BrandB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ToyT",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "BrandID",
                table: "ToyT",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BrandB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandB", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToyT_BrandID",
                table: "ToyT",
                column: "BrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToyT_BrandB_BrandID",
                table: "ToyT",
                column: "BrandID",
                principalTable: "BrandB",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToyT_BrandB_BrandID",
                table: "ToyT");

            migrationBuilder.DropTable(
                name: "BrandB");

            migrationBuilder.DropIndex(
                name: "IX_ToyT_BrandID",
                table: "ToyT");

            migrationBuilder.DropColumn(
                name: "BrandID",
                table: "ToyT");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "ToyT",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}
