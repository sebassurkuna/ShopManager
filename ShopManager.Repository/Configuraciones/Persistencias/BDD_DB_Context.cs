using Microsoft.EntityFrameworkCore;
using ShopManager.Entity.Modelo;

namespace ShopManager.Repository.Configuraciones.Persistencias
{
    public class BDD_DB_Context : DbContext
    {
        public BDD_DB_Context(DbContextOptions options) : base(options)
        {
        }

        DbSet<EProductoModel> PRODUCTOS { get; set; }
        DbSet<EUsuarioModel> USUARIOS { get; set; }
        DbSet<EOrdenProductoModel> ORDEN_PRODUCTOS { get; set; }
        DbSet<EPedidoModel> PEDIDOS { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("SHOP_MANAGER");
            }
        }
    }
}
