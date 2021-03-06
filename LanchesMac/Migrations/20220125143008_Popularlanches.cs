using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class Popularlanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(1,'Pão, Hambúger, Ovo, Presunto, Queijo, Batata Palha com Alface e Cebolas.','Delicioso pão de hambúrger com ovo frito, presunto e queijo de primeira qualidade, alface, rodelas de cebolas frescas, acompanhado com batata palha.'," +
                "1,'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0 ,'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(1,'Pão, Presunto, Mussarela e Tomate.','Delicioso pão francês quentinho na chapa com presunto e mussarela, bem servidos com tomate preparado com carinho.'," +
                "1,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 0 ,'Misto Quente',8.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(1,'Pão, Hambúger, Presunto, Mussarela e Batata Palha.','Pão de hambúrger especial com hambúrger de nossa preparação, presunto e mussarela, acompanha batata palha.'," +
                "1,'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg', 0 ,'Cheese Burger', 11.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,IsLanchePreferido,Nome,Preco) " +
                "VALUES(2,'Pão, Integral, Queijo Branco, Peito de Peru, Cenoura, Alface, Iogurte.','Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgute natural.'," +
                "1,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 1 ,'Lanche Natural Peito Peru', 15.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
