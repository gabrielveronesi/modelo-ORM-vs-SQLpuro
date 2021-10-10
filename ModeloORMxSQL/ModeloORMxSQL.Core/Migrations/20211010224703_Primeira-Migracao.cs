using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloORMxSQL.Core.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Gabriel Veronesi" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Vitor Hugo" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Mariana Camargo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
