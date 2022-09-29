using ShopManager.Entity.DTOs;

namespace ShopManager.Domain.Interfaces
{
    public interface IProductoInfraestructure
    {
        List<EProductosDto> GetProductos();
        EProductosDto GetProductoById(string id);
        EProductosDto AddProducto(EProductosDto producto);
        EProductosDto UpdateProducto(EProductosDto producto);
        bool DeleteProducto(string id);

    }
}
