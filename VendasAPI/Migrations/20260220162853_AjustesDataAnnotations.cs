using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VendasAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjustesDataAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaFormaPagamento_FormasPagamento_FormaPagamentoId",
                table: "VendaFormaPagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaFormaPagamento_Vendas_VendaId",
                table: "VendaFormaPagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Produtos_ProdutoId",
                table: "VendaProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_VendaProduto_Vendas_VendaId",
                table: "VendaProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Cupons_CupomId",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_FormasEntrega_EntregaId",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Usuarios_ClienteId",
                table: "Vendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendas",
                table: "Vendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendaProduto",
                table: "VendaProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendaFormaPagamento",
                table: "VendaFormaPagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormasPagamento",
                table: "FormasPagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FormasEntrega",
                table: "FormasEntrega");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cupons",
                table: "Cupons");

            migrationBuilder.DropColumn(
                name: "ContinuarCompra",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "FinalizarCompra",
                table: "Vendas");

            migrationBuilder.RenameTable(
                name: "Vendas",
                newName: "vendas");

            migrationBuilder.RenameTable(
                name: "VendaProduto",
                newName: "vendaproduto");

            migrationBuilder.RenameTable(
                name: "VendaFormaPagamento",
                newName: "vendaformapagamento");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "produtos");

            migrationBuilder.RenameTable(
                name: "FormasPagamento",
                newName: "formaspagamento");

            migrationBuilder.RenameTable(
                name: "FormasEntrega",
                newName: "formasentrega");

            migrationBuilder.RenameTable(
                name: "Cupons",
                newName: "cupons");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_EntregaId",
                table: "vendas",
                newName: "IX_vendas_EntregaId");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_CupomId",
                table: "vendas",
                newName: "IX_vendas_CupomId");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_ClienteId",
                table: "vendas",
                newName: "IX_vendas_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_VendaProduto_VendaId",
                table: "vendaproduto",
                newName: "IX_vendaproduto_VendaId");

            migrationBuilder.RenameIndex(
                name: "IX_VendaProduto_ProdutoId",
                table: "vendaproduto",
                newName: "IX_vendaproduto_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_VendaFormaPagamento_VendaId",
                table: "vendaformapagamento",
                newName: "IX_vendaformapagamento_VendaId");

            migrationBuilder.RenameIndex(
                name: "IX_VendaFormaPagamento_FormaPagamentoId",
                table: "vendaformapagamento",
                newName: "IX_vendaformapagamento_FormaPagamentoId");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTroco",
                table: "vendas",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalVenda",
                table: "vendas",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorEntrega",
                table: "vendas",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDesconto",
                table: "vendas",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalItens",
                table: "vendas",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SaldoRestante",
                table: "vendas",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantidade",
                table: "vendaproduto",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoUnitario",
                table: "vendaproduto",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPago",
                table: "vendaformapagamento",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "usuarios",
                type: "char(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Senha",
                keyValue: null,
                column: "Senha",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "usuarios",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "SaldoAdiantamento",
                table: "usuarios",
                type: "decimal(12,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "NomeUsuario",
                keyValue: null,
                column: "NomeUsuario",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NomeUsuario",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "usuarios",
                keyColumn: "Nome",
                keyValue: null,
                column: "Nome",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "InscricaoEstadual",
                table: "usuarios",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoCivil",
                table: "usuarios",
                type: "char(1)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "usuarios",
                type: "varchar(14)",
                maxLength: 14,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "usuarios",
                type: "varchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "usuarios",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPromocao",
                table: "produtos",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "produtos",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "produtos",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "produtos",
                keyColumn: "Nome",
                keyValue: null,
                column: "Nome",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "produtos",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Estoque",
                table: "produtos",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "formaspagamento",
                keyColumn: "Descricao",
                keyValue: null,
                column: "Descricao",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "formaspagamento",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "AceitaTroco",
                table: "formaspagamento",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorMinimoDesconto",
                table: "formasentrega",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "formasentrega",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "formasentrega",
                keyColumn: "Descricao",
                keyValue: null,
                column: "Descricao",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "formasentrega",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "cupons",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "cupons",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(1)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "cupons",
                keyColumn: "Nome",
                keyValue: null,
                column: "Nome",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "cupons",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vendas",
                table: "vendas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vendaproduto",
                table: "vendaproduto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vendaformapagamento",
                table: "vendaformapagamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_produtos",
                table: "produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_formaspagamento",
                table: "formaspagamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_formasentrega",
                table: "formasentrega",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cupons",
                table: "cupons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendaformapagamento_formaspagamento_FormaPagamentoId",
                table: "vendaformapagamento",
                column: "FormaPagamentoId",
                principalTable: "formaspagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendaformapagamento_vendas_VendaId",
                table: "vendaformapagamento",
                column: "VendaId",
                principalTable: "vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendaproduto_produtos_ProdutoId",
                table: "vendaproduto",
                column: "ProdutoId",
                principalTable: "produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendaproduto_vendas_VendaId",
                table: "vendaproduto",
                column: "VendaId",
                principalTable: "vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_vendas_cupons_CupomId",
                table: "vendas",
                column: "CupomId",
                principalTable: "cupons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendas_formasentrega_EntregaId",
                table: "vendas",
                column: "EntregaId",
                principalTable: "formasentrega",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_vendas_usuarios_ClienteId",
                table: "vendas",
                column: "ClienteId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vendaformapagamento_formaspagamento_FormaPagamentoId",
                table: "vendaformapagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_vendaformapagamento_vendas_VendaId",
                table: "vendaformapagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_vendaproduto_produtos_ProdutoId",
                table: "vendaproduto");

            migrationBuilder.DropForeignKey(
                name: "FK_vendaproduto_vendas_VendaId",
                table: "vendaproduto");

            migrationBuilder.DropForeignKey(
                name: "FK_vendas_cupons_CupomId",
                table: "vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_vendas_formasentrega_EntregaId",
                table: "vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_vendas_usuarios_ClienteId",
                table: "vendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vendas",
                table: "vendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vendaproduto",
                table: "vendaproduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vendaformapagamento",
                table: "vendaformapagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_produtos",
                table: "produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_formaspagamento",
                table: "formaspagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_formasentrega",
                table: "formasentrega");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cupons",
                table: "cupons");

            migrationBuilder.RenameTable(
                name: "vendas",
                newName: "Vendas");

            migrationBuilder.RenameTable(
                name: "vendaproduto",
                newName: "VendaProduto");

            migrationBuilder.RenameTable(
                name: "vendaformapagamento",
                newName: "VendaFormaPagamento");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "produtos",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "formaspagamento",
                newName: "FormasPagamento");

            migrationBuilder.RenameTable(
                name: "formasentrega",
                newName: "FormasEntrega");

            migrationBuilder.RenameTable(
                name: "cupons",
                newName: "Cupons");

            migrationBuilder.RenameIndex(
                name: "IX_vendas_EntregaId",
                table: "Vendas",
                newName: "IX_Vendas_EntregaId");

            migrationBuilder.RenameIndex(
                name: "IX_vendas_CupomId",
                table: "Vendas",
                newName: "IX_Vendas_CupomId");

            migrationBuilder.RenameIndex(
                name: "IX_vendas_ClienteId",
                table: "Vendas",
                newName: "IX_Vendas_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_vendaproduto_VendaId",
                table: "VendaProduto",
                newName: "IX_VendaProduto_VendaId");

            migrationBuilder.RenameIndex(
                name: "IX_vendaproduto_ProdutoId",
                table: "VendaProduto",
                newName: "IX_VendaProduto_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_vendaformapagamento_VendaId",
                table: "VendaFormaPagamento",
                newName: "IX_VendaFormaPagamento_VendaId");

            migrationBuilder.RenameIndex(
                name: "IX_vendaformapagamento_FormaPagamentoId",
                table: "VendaFormaPagamento",
                newName: "IX_VendaFormaPagamento_FormaPagamentoId");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTroco",
                table: "Vendas",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorTotalVenda",
                table: "Vendas",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorEntrega",
                table: "Vendas",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDesconto",
                table: "Vendas",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalItens",
                table: "Vendas",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SaldoRestante",
                table: "Vendas",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AddColumn<bool>(
                name: "ContinuarCompra",
                table: "Vendas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FinalizarCompra",
                table: "Vendas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantidade",
                table: "VendaProduto",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoUnitario",
                table: "VendaProduto",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPago",
                table: "VendaFormaPagamento",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "SaldoAdiantamento",
                table: "Usuarios",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RazaoSocial",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "NomeUsuario",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "InscricaoEstadual",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "EstadoCivil",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cnpj",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(14)",
                oldMaxLength: 14,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldMaxLength: 11,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Bairro",
                table: "Usuarios",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPromocao",
                table: "Produtos",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Produtos",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Produtos",
                type: "varchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Estoque",
                table: "Produtos",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FormasPagamento",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<bool>(
                name: "AceitaTroco",
                table: "FormasPagamento",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorMinimoDesconto",
                table: "FormasEntrega",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "FormasEntrega",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "FormasEntrega",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Cupons",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Cupons",
                type: "varchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Cupons",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendas",
                table: "Vendas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendaProduto",
                table: "VendaProduto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendaFormaPagamento",
                table: "VendaFormaPagamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormasPagamento",
                table: "FormasPagamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormasEntrega",
                table: "FormasEntrega",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cupons",
                table: "Cupons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaFormaPagamento_FormasPagamento_FormaPagamentoId",
                table: "VendaFormaPagamento",
                column: "FormaPagamentoId",
                principalTable: "FormasPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaFormaPagamento_Vendas_VendaId",
                table: "VendaFormaPagamento",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Produtos_ProdutoId",
                table: "VendaProduto",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProduto_Vendas_VendaId",
                table: "VendaProduto",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Cupons_CupomId",
                table: "Vendas",
                column: "CupomId",
                principalTable: "Cupons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_FormasEntrega_EntregaId",
                table: "Vendas",
                column: "EntregaId",
                principalTable: "FormasEntrega",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Usuarios_ClienteId",
                table: "Vendas",
                column: "ClienteId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
