using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasAPI.Model
{
    public class Cliente : Usuario
    {
        [Column(TypeName = "decimal(12,2)")]
        public decimal SaldoAdiantamento { get; set; }
        
        public int PontosFidelidade { get; set; }
        //Criado para exemplificar Abstração e Polimorfismo

        [StringLength(100)]
        public string? Endereco { get; set; }
        
        public int Numero { get; set; }

        [StringLength(100)]
        public string? Complemento { get; set; }

        [StringLength(100)]
        public string? Bairro { get; set; }

        [StringLength(100)]
        public string? Cidade { get; set; }

        [StringLength(100)]
        public string? Estado { get; set; }

        public ICollection<Venda>? Compras { get; set; }

        public Cliente()
        {
                Compras = new Collection<Venda>();
        }
    }
}
