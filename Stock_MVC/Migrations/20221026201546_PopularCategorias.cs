using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_MVC.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Departamentos(DepartamentoNome, Descricao) " +
                "VALUES('Computadores', 'Aqui você encontra computadores')");

            migrationBuilder.Sql("INSERT INTO Departamentos(DepartamentoNome, Descricao) " +
                "VALUES('Smartphones', 'Aqui você encontra smartphones')");

            migrationBuilder.Sql("INSERT INTO Departamentos(DepartamentoNome, Descricao) " +
                "VALUES('Eletrodomesticos', 'Aqui você encontra eletrodomesticos')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Departamentos");
        }
    }
}
