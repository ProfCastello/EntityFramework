using Microsoft.EntityFrameworkCore;

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
    }
}
