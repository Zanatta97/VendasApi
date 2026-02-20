using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendasAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaDadosIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder builder)
        {
            builder.Sql("insert into cupons (Nome, Tipo, Valor) values ('PERCENT05', 'P', 5)");
            builder.Sql("insert into cupons (Nome, Tipo, Valor) values ('PERCENT10', 'P', 10)");
            builder.Sql("insert into cupons (Nome, Tipo, Valor) values ('PERCENT20', 'P', 20)");
            builder.Sql("insert into cupons (Nome, Tipo, Valor) values ('PERCENT20', 'P', 30)");
            builder.Sql("insert into cupons (Nome, Tipo, Valor) values ('VALOR05', 'V', 5)");
            builder.Sql("insert into cupons (Nome, Tipo, Valor) values ('VALOR10', 'V', 10)");
            builder.Sql("insert into cupons (Nome, Tipo, Valor) values ('VALOR20', 'V', 20)");
            builder.Sql("insert into cupons (Nome, Tipo, Valor) values ('VALOR30', 'V', 30)");

            builder.Sql("insert into formasentrega (Descricao, Valor, ValorMinimoDesconto) values ('Retirar na Loja', 0, 0)");
            builder.Sql("insert into formasentrega (Descricao, Valor, ValorMinimoDesconto) values ('Entrega Padrão', 20, 200)");
            builder.Sql("insert into formasentrega (Descricao, Valor, ValorMinimoDesconto) values ('Entrega Expressa', 40, 300)");

            builder.Sql("insert into formaspagamento (Descricao, AceitaTroco) values ('Dinheiro', true)");
            builder.Sql("insert into formaspagamento (Descricao, AceitaTroco) values ('Cartão de Débito', false)");
            builder.Sql("insert into formaspagamento (Descricao, AceitaTroco) values ('Cartão de Crédito', false)");
            builder.Sql("insert into formaspagamento (Descricao, AceitaTroco) values ('Pix', false)");
            builder.Sql("insert into formaspagamento (Descricao, AceitaTroco) values ('Cheque', false)");
            builder.Sql("insert into formaspagamento (Descricao, AceitaTroco) values ('Adiantamento', true)");

            builder.Sql("insert into produtos (Nome, Valor, Tipo, Estoque, ValorPromocao)" +
                "values ('Monster de Manga', 8, 'U', 20, 0)");
            builder.Sql("insert into produtos (Nome, Valor, Tipo, Estoque, ValorPromocao)" +
                "values ('Café', 35, 'U', 55, 0)");
            builder.Sql("insert into produtos (Nome, Valor, Tipo, Estoque, ValorPromocao)" +
                "values ('Monster Normal', 8, 'U', 0, 0)");
            builder.Sql("insert into produtos (Nome, Valor, Tipo, Estoque, ValorPromocao)" +
                "values ('Trident', 3, 'U', 500, 1.99)");
            builder.Sql("insert into produtos (Nome, Valor, Tipo, Estoque, ValorPromocao)" +
                "values ('Coca 600ml', 4.5, 'U', 50, 0)");
            builder.Sql("insert into produtos (Nome, Valor, Tipo, Estoque, ValorPromocao)" +
                "values ('Picanha Kg', 49.9, 'K', 40, 39.9)");
            builder.Sql("insert into produtos (Nome, Valor, Tipo, Estoque, ValorPromocao)" +
                "values ('Cerveja Polar Latão', 4.5, 'U', 0, 0)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder builder)
        {
            builder.Sql("delete from cupons");
            builder.Sql("delete from formasentrega");
            builder.Sql("delete from formaspagamento");
            builder.Sql("delete from produtos");
        }
    }
}
