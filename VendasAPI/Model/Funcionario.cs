namespace VendasAPI.Model
{
    public class Funcionario : Usuario
    {
        public bool PodeEditarProdutos { get; set; }
        public bool PodeEditarCupons { get; set; }
        public bool PodeEditarFormasEntrega { get; set; }
        public bool PodeEditarFormasPagamento { get; set; }
        public bool PodeAtualizarCadastroCliente { get; set; }
        public bool PodeEditarFuncionarios { get; set; }
    }
}
