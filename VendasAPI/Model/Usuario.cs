using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasAPI.Model
{
    [Table("usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? NomeUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(30)]
        public string? Senha { get; set; }
    }
}
