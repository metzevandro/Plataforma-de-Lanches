using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plataforma_de_Lanches.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LancheId",
                table: "Lanches",
                newName: "Id");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao) " +
                "VALUES('Normal','Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(Nome,Descricao) " +
                "VALUES('Natural','Lanche feito com ingredientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lanches",
                newName: "LancheId");

            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
