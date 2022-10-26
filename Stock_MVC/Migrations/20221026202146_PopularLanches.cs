using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_MVC.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,ImagemThumbnailUrl,IsProdutoPreferido,EmEstoque, DepartamentoId) " +
                "VALUES('Notebook', 'Notebook i3 1º geração', 1557.90, '/images/notebookCarousel.jpg', '/images/notebookCarousel.jpg', 1, 1, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
