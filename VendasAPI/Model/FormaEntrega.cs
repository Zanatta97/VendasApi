namespace VendasAPI.Model
{
    public class FormaEntrega
    {
        public int Id { get; private set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorMinimoDesconto { get; set; }
    }
}
