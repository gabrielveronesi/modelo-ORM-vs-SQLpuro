using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloORMxSQL.Core.Migrations
{
    public partial class ArrumandoCargaInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
