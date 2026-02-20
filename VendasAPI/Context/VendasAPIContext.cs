using Microsoft.EntityFrameworkCore;
using VendasAPI.Model;

namespace VendasAPI.Context
{
    public class VendasAPIContext : DbContext
    {
        public VendasAPIContext(DbContextOptions<VendasAPIContext> options) : base(options)
        {
                
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cupom> Cupons { get; set; }
        public DbSet<FormaEntrega> FormasEntrega { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
