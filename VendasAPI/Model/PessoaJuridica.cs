using System.ComponentModel.DataAnnotations;

namespace VendasAPI.Model
{
    public class PessoaJuridica : Cliente
    {
        [StringLength(14)]
        public string? Cnpj { get; set; }
        
        [StringLength(30)]
        public string? InscricaoEstadual { get; set; }

        [StringLength(100)]
        public string? RazaoSocial { get; set; }
    }
}
