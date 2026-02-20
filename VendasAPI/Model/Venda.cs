namespace VendasAPI.Model
{
    public class Venda
    {
        public int Id { get; private set; }
        public int IdCliente { get; private set; }
        public Dictionary<Produto, decimal> ProdutosCompra { get; private set; }
            = new Dictionary<Produto, decimal>();
        public Dictionary<FormaPagamento, decimal> FormasPagamentoSelecionadas { get; private set; }
            = new Dictionary<FormaPagamento, decimal>();
        public decimal TotalItens { get; set; }
        public FormaEntrega? Entrega { get; set; }
        public decimal ValorEntrega { get; set; }
        public Cupom? CupomUtilizado { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal SaldoRestante { get; set; }
        public decimal ValorTroco { get; set; }
        public int PontosFidelidadeCompra { get; set; }
        public bool ContinuarCompra { get; set; }
        public bool FinalizarCompra { get; set; }
        public int NroNotaFiscal { get; set; }
        public bool VendaFinalizada { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public decimal ValorTotalVenda { get; set; }
    }
}
