using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasAPI.Model
{
    public class PessoaFisica : Cliente
    {

        [StringLength(11)]
        public string? CPF { get; set; }
        public DateTime? DataNascimento { get; set; }

        [Column(TypeName = "char(1)")]
        public string? Sexo { get; set; }

        [Column(TypeName = "char(1)")]
        public string? EstadoCivil { get; set; }
    }
}
