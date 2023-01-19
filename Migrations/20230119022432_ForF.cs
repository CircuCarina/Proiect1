using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect1.Migrations
{
    public partial class ForF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "For",
                table: "ToyT");

            migrationBuilder.AddColumn<int>(
                name: "ForID",
                table: "ToyT",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForF",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    For = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForF", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToyT_ForID",
                table: "ToyT",
                column: "ForID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToyT_ForF_ForID",
                table: "ToyT",
                column: "ForID",
                principalTable: "ForF",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToyT_ForF_ForID",
                table: "ToyT");

            migrationBuilder.DropTable(
                name: "ForF");

            migrationBuilder.DropIndex(
                name: "IX_ToyT_ForID",
                table: "ToyT");

            migrationBuilder.DropColumn(
                name: "ForID",
                table: "ToyT");

            migrationBuilder.AddColumn<string>(
                name: "For",
                table: "ToyT",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
