using Microsoft.EntityFrameworkCore;
using APICarteira.Entities;

namespace APICarteira.Context;

public class APICarteiraContext : DbContext
{
    public APICarteiraContext(DbContextOptions<APICarteiraContext> options) : base(options)
        {
            
        }
    
    public DbSet<Carteira> Carteira { get; set; }
    public DbSet<Transacao> Transacao { get; set; }
    public DbSet<Cartao> Cartao { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transacao>()
            .HasKey(o => o.Id);

            modelBuilder.Entity<Cartao>()
            .HasKey(o => o.Id);

            modelBuilder.Entity<Categoria>()
            .HasKey(o => o.Id);
            
        }
}