using ShopManager.Domain.Interfaces;
using ShopManager.Entity.DTOs;

namespace ShopManager.Infraestructure.Services.ShopManager
{
    public class ProductoInfraestructure : IProductoInfraestructure
    {
        private readonly IProductoRepository productoRepository;

        public ProductoInfraestructure(IProductoRepository productoRepository)
        {
            this.productoRepository = productoRepository;
        }

        public EProductosDto AddProducto(EProductosDto producto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProducto(string id)
        {
            throw new NotImplementedException();
        }

        public EProductosDto GetProductoById(string id)
        {
            throw new NotImplementedException();
        }

        public List<EProductosDto> GetProductos()
        {
            throw new NotImplementedException();
        }

        public EProductosDto UpdateProducto(EProductosDto producto)
        {
            throw new NotImplementedException();
        }
    }
}
