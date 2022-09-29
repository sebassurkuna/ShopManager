using Microsoft.EntityFrameworkCore;
using ShopManager.Entity.Modelo;

namespace ShopManager.Repository.Configuraciones.Persistencias
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EProductoModel> PRODUCTOS { get; set; }
        public DbSet<EUsuarioModel> USUARIOS { get; set; }
        public DbSet<EOrdenProductoModel> ORDEN_PRODUCTOS { get; set; }
        public DbSet<EPedidoModel> PEDIDOS { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("SHOP_MANAGER");
            }
        }
    }
}
