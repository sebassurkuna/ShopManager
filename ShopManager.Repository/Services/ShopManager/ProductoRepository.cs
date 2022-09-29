using Microsoft.EntityFrameworkCore;
using ShopManager.Domain.Interfaces;
using ShopManager.Entity.DTOs;
using ShopManager.Entity.Modelo;
using ShopManager.Repository.Configuraciones.Persistencias;

namespace ShopManager.Repository.Services.ShopManager
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ShopDbContext context;

        public ProductoRepository(ShopDbContext _context)
        {
            context = _context;
        }
    
        public async Task<EProductosDto> AddProducto(EProductosDto producto)
        {
            var addProducto = new EProductoModel() { 
                ID=producto.Id,
                NAME=producto.Nombre,
                DESCRIPTION=producto.Descripcion,
                PRICE=producto.Precio,
                CREATION_DATE=producto.FechaCreacion
            };
            await context.PRODUCTOS.AddAsync(addProducto);
            await context.SaveChangesAsync();
            return producto;
        }

        public async Task<bool> DeleteProducto(string id)
        {
            var deletePorduct = await context.PRODUCTOS.FindAsync(id);
            if (deletePorduct == null)
            {
                throw new Exception();
            }

            context.PRODUCTOS.Remove(deletePorduct);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<EProductosDto> GetProductoById(string id)
        {
            var foundProduct = await context.PRODUCTOS.FindAsync(id);
            if (foundProduct == null)
            {
                throw new Exception();
            }

            return new EProductosDto()
            {
                Id = foundProduct.ID,
                Nombre = foundProduct.NAME,
                Descripcion = foundProduct.DESCRIPTION,
                Precio = foundProduct.PRICE,
                FechaCreacion = foundProduct.CREATION_DATE
            };
        }

        public async Task<List<EProductosDto>> GetProductos()
        {
            return await context.PRODUCTOS.Select(e => new EProductosDto()
            {
                Id=e.ID,
                Nombre=e.NAME,
                Descripcion=e.DESCRIPTION,
                Precio=e.PRICE,
                FechaCreacion=e.CREATION_DATE
            }).ToListAsync();
        }

        public async Task<EProductosDto> UpdateProducto(EProductosDto producto)
        {
            var updateProduct = await context.PRODUCTOS.FindAsync(producto.Id);
            if (updateProduct == null)
            {
                throw new Exception();
            }

            updateProduct.ID = producto.Id;
            updateProduct.NAME = producto.Nombre;
            updateProduct.DESCRIPTION = producto.Descripcion;
            updateProduct.PRICE = producto.Precio;
            updateProduct.CREATION_DATE = producto.FechaCreacion;

            context.Entry(updateProduct).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return producto;
        }
    }
}
