using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VendasAPI.Model
{
    [Table("vendaproduto")]
    public class VendaProduto
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        [JsonIgnore] //Ignora o campo ao seralizar o JSON
        public Venda? Venda { get; set; }
        public int ProdutoId { get; set; }
        [JsonIgnore]
        public Produto? Produto { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Quantidade { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal PrecoUnitario { get; set; }
    }
}
