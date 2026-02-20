using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasAPI.Model
{
    [Table("formasentrega")]
    public class FormaEntrega
    {
        public int Id { get; private set; }
        
        [Required]
        [StringLength(100)]
        public string? Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Valor { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorMinimoDesconto { get; set; }
    }
}
