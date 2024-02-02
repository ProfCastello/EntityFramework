using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;

namespace EntityFramework.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }

        public DbSet<Models.Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Cliente>().ToTable("Cliente");
        }
        public DbSet<EntityFramework.Models.Produto> Produto { get; set; } = default!;
    }
}
