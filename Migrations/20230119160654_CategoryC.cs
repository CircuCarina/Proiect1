using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect1.Migrations
{
    public partial class CategoryC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryC",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryC", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ToyCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToyID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToyCategory");

            migrationBuilder.DropTable(
                name: "CategoryC");
        }
    }
}
