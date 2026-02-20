using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasAPI.Model
{
    [Table("produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Valor { get; set; }
        
        [Required]
        [Column(TypeName = "char(1)")]
        public char Tipo { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Estoque { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorPromocao { get; set; }
    }
}
