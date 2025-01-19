using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "Duracao", "AnoLancamento" }, new object[] { "Oceano", 270, 1989 });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "Duracao", "AnoLancamento" }, new object[] { "Flor de Lis", 240, 1976 });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "Duracao", "AnoLancamento" }, new object[] { "Samurai", 300, 1982 });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "Duracao", "AnoLancamento" }, new object[] { "Se", 210, 1992 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas");
        }
    }
}
