using ShopManager.Entity.DTOs;

namespace ShopManager.Domain.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<EProductosDto>> GetProductos();
        Task<EProductosDto> GetProductoById(string id);
        Task<EProductosDto> AddProducto(EProductosDto producto);
        Task<EProductosDto> UpdateProducto(EProductosDto producto);
        Task<bool> DeleteProducto(string id);

    }
}
