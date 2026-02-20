using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasAPI.Model
{
    [Table("cupons")]
    public class Cupom
    {
        //[Key] - Como usei a nomenclatura padrão, não é necessário
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Required]
        [Column(TypeName = "char(1)")]
        public char Tipo { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Valor { get; set; }
    }
}
