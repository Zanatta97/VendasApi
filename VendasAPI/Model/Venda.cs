using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace VendasAPI.Model
{
    [Table("vendas")]
    public class Venda
    {
        public int Id { get; private set; }

        // Relacionamento com Cliente
        public int ClienteId { get; set; }
        [JsonIgnore]
        public Cliente? Cliente { get; set; }

        //Relacionamento N pra N com Produto e FormaPagamento
        public ICollection<VendaProduto>? ProdutosCompra { get; set; }
        public ICollection<VendaFormaPagamento>? FormasPagamentoSelecionadas { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal TotalItens { get; set; }

        // Relacionamento com FormaEntrega
        public int? EntregaId { get; set; }
        [JsonIgnore]
        public FormaEntrega? Entrega { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorEntrega { get; set; }

        // Relacionamento com Cupom
        public int? CupomId { get; set; }
        [JsonIgnore]
        public Cupom? CupomUtilizado { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorDesconto { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal SaldoRestante { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorTroco { get; set; }

        [Required]
        public int PontosFidelidadeCompra { get; set; }

        [NotMapped]
        public bool ContinuarCompra { get; set; }

        [NotMapped]
        public bool FinalizarCompra { get; set; }


        public int NroNotaFiscal { get; set; }

        [Required]
        public bool VendaFinalizada { get; set; }

        [Required]
        public DateTime DataHoraVenda { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorTotalVenda { get; set; }

        public Venda()
        {
                ProdutosCompra = new List<VendaProduto>();
                FormasPagamentoSelecionadas = new List<VendaFormaPagamento>();
        }
    }
}
