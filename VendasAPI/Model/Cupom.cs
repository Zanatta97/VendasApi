namespace VendasAPI.Model
{
    public class Cupom
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public char Tipo { get; set; }
        public decimal Valor { get; set; }
    }
}
