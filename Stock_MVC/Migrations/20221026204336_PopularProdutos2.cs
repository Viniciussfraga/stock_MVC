using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_MVC.Migrations
{
    public partial class PopularProdutos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,ImagemThumbnailUrl,IsProdutoPreferido,EmEstoque, DepartamentoId) " +
                "VALUES('Smartphone Samsung', 'Smartphone Samsung 128GB 12RAM', 5800.00, '/images/celularCarousel.jpg','/images/celularCarousel.jpg', 0, 1, 2)");

            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,ImagemThumbnailUrl,IsProdutoPreferido,EmEstoque, DepartamentoId) " +
                "VALUES('Geladeira', 'Geladeira com água na dispensa', 3475.87,'https://a-static.mlcdn.com.br/800x560/refrigerador-electrolux-cycle-defrost-240-litros-branco-re31-127-volts/friopecas/120910/3383dd7efea15e1b0900fc2ebcc1521d.jpeg','https://a-static.mlcdn.com.br/800x560/refrigerador-electrolux-cycle-defrost-240-litros-branco-re31-127-volts/friopecas/120910/3383dd7efea15e1b0900fc2ebcc1521d.jpeg',0,0,3)");

            migrationBuilder.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,ImagemThumbnailUrl,IsProdutoPreferido,EmEstoque, DepartamentoId) " +
               "VALUES('Fogão ', 'Fogão Cooktop 4 bocas Chamalux', 329.00, 'https://m.media-amazon.com/images/I/71YrGa5fIDL._AC_SL1500_.jpg', 'https://m.media-amazon.com/images/I/71YrGa5fIDL._AC_SL1500_.jpg', 1,1,3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
