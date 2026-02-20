namespace VendasAPI.Model
{
    public class Cliente : Usuario
    {
        public decimal SaldoAdiantamento { get; set; }
        public int PontosFidelidade { get; set; }
        public List<Venda> Compras { get; set; } = new List<Venda>();
        //Criado para exemplificar Abstração e Polimorfismo
        public string? Endereco { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
    }
}
