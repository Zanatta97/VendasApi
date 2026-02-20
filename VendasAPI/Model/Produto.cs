namespace VendasAPI.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public char Tipo { get; set; }
        public decimal Estoque { get; set; }
        public decimal ValorPromocao { get; set; }
    }
}
