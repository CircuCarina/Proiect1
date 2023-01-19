using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect1.Migrations
{
    public partial class CategoryCC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToyCategory");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "ToyT",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToyT_CategoryID",
                table: "ToyT",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToyT_CategoryC_CategoryID",
                table: "ToyT",
                column: "CategoryID",
                principalTable: "CategoryC",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToyT_CategoryC_CategoryID",
                table: "ToyT");

            migrationBuilder.DropIndex(
                name: "IX_ToyT_CategoryID",
                table: "ToyT");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "ToyT");

            migrationBuilder.CreateTable(
                name: "ToyCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ToyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToyCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ToyCategory_CategoryC_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CategoryC",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ToyCategory_ToyT_ToyID",
                        column: x => x.ToyID,
                        principalTable: "ToyT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToyCategory_CategoryID",
                table: "ToyCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ToyCategory_ToyID",
                table: "ToyCategory",
                column: "ToyID");
        }
    }
}
