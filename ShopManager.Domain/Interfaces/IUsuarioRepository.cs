using ShopManager.Entity.DTOs;

namespace ShopManager.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        List<EUsuariosDto> GetProductos();
        EUsuariosDto GetProductoById(string id);
        EUsuariosDto AddProducto(EUsuariosDto usuaio);
        EUsuariosDto UpdateProducto(EUsuariosDto usuario);
        bool DeleteProducto(string id);

    }
}
