namespace VendasAPI.Model
{
    public class PessoaJuridica : Cliente
    {
        public string? Cnpj { get; set; }
        public string? InscricaoEstadual { get; set; }
        public string? RazaoSocial { get; set; }
    }
}
