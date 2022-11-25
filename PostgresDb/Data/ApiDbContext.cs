
using Microsoft.EntityFrameworkCore;
using PostgresDb.Models;

namespace PostgresDb.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Envios> Envios { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1 - Muchos
            modelBuilder.Entity<Pedidos>(entity => {
                entity.HasOne(c => c.Clientes)
                    .WithMany(p => p.Pedidos)
                    .HasForeignKey(x => x.ClienteId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Pedido_Cliente");
                
                //Uno - Uno
                entity.HasOne(e => e.Envios)
                    .WithOne(p => p.Pedidos)
                    .HasForeignKey<Envios>(x => x.EnvioId);
            });
        }
    }
}

