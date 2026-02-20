namespace VendasAPI.Model
{
    public class PessoaFisica : Cliente
    {
        public string? CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Sexo { get; set; }
        public string? EstadoCivil { get; set; }
    }
}
