using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasAPI.Model
{
    [Table("formaspagamento")]
    public class FormaPagamento
    {
        public int Id { get; private set; }
        [Required]
        [StringLength(100)]
        public string? Descricao { get; set; }

        [Required]
        [Column(TypeName = "char(1)")]
        public bool AceitaTroco { get; set; }
    }
}
