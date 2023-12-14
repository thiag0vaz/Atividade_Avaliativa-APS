using Microsoft.EntityFrameworkCore;
namespace Francisco_Thiago.Models
{
 public class MyDbContext : DbContext
    {
 public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
 public DbSet<Cliente> Clientes {get; set;}
 public DbSet<Vendedor> Vendedors {get; set;}
 public DbSet<Item> Items {get; set;}
 public DbSet<Marca> Marcas {get; set;}
 public DbSet<Produto> Produtos {get; set;}
 public DbSet<Pagamento> Pagamentos {get; set;}
 public DbSet<Transportadora> Transportadoras {get; set;}
 public DbSet<TipoDePagamento> TipoDePagamentos {get; set;}
 public DbSet<PagamentoComCheque> PagamentoComCheques {get; set;}
 public DbSet<PagamentoComCartao> PagamentoComCartaos {get; set;}
 public DbSet<NotaDeVenda> NotaDeVendas {get; set;}

    }
}
