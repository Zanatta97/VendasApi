using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VendasAPI.Model
{
    [Table("vendaformapagamento")]
    public class VendaFormaPagamento
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        [JsonIgnore]
        public Venda? Venda { get; set; }
        public int FormaPagamentoId { get; set; }
        [JsonIgnore]
        public FormaPagamento? FormaPagamento { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorPago { get; set; }
    }
}
