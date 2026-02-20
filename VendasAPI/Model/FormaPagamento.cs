namespace VendasAPI.Model
{
    public class FormaPagamento
    {
        public int Id { get; private set; }
        public string? Descricao { get; set; }
        public bool AceitaTroco { get; set; }
    }
}
