using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoiaShop.ProdutoApi.Migrations
{
     public partial class GerarProdutos : Migration
     { 
        
        protected override void Up(MigrationBuilder modelb)
        {
            modelb.Sql ("Insert into Produtos(Nome, Preço, Decrição, Estoque, ImageUrl, CategiriaId)" +
                    "Values('Gargantilha', 45.00, 'Banhada a Ouro', 10, 'Gargantilha.jpg'.1");

            modelb.Sql("Insert into Produtos(Nome, Preço, Decrição, Estoque, ImageUrl, CategiriaId)" +
                   "Values('Cordão de Ouro', 80.00.00, 'Folheada a Ouro', 5, 'Cordão de Ouro.jpg'.1");

            modelb.Sql("Insert into Produtos(Nome, Preço, Decrição, Estoque, ImageUrl, CategiriaId)" +
                   "Values('Puceira', 40.00, 'Banhada a Ouro', 10, 'Puceira.jpg'.1");

            modelb.Sql("Insert into Produtos(Nome, Preço, Decrição, Estoque, ImageUrl, CategiriaId)" +
                   "Values('Brinco', 30.00, 'Banhada a Ouro', 20, 'Brinco.jpg'.2");

            modelb.Sql("Insert into Produtos(Nome, Preço, Decrição, Estoque, ImageUrl, CategiriaId)" +
                   "Values('Anel', 65.00, 'Banhada a Ouro', 10, 'Anel.jpg'.2");
        }
        
        protected override void Down(MigrationBuilder modelb)
        {
            modelb.Sql("delete from Produtos");

        }
     }
}
