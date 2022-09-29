using Microsoft.EntityFrameworkCore;
using ShopManager.Entity.DTOs;
using ShopManager.Entity.Modelo;
using ShopManager.Repository.Configuraciones.Persistencias;
using ShopManager.Repository.Services.ShopManager;

namespace ShopManager.Test.Repository.Services
{
    public class ProductoRepositoryTest
    {
        private ProductoRepository _productRepository;
        private ShopDbContext _dbContext;
        private DbContextOptions _options;
        private EProductoModel _modelTest;

        [OneTimeSetUp]
        public async Task SetUp()
        {
            _options = new DbContextOptionsBuilder<ShopDbContext>().UseInMemoryDatabase("SHOP_MANAGER").Options;
            _dbContext = new ShopDbContext(_options);
            _productRepository = new ProductoRepository(_dbContext);

            _modelTest = new EProductoModel()
            {
                ID = "0",
                NAME = "Setup",
                DESCRIPTION = "SetUp",
                PRICE = 0,
                CREATION_DATE = DateTime.Now.ToString()
            };

            _dbContext.PRODUCTOS.Add(_modelTest);
            await _dbContext.SaveChangesAsync();
        }

        [Test]
        public void A_Obtener_ListaPorductos_ReturnOk()
        {
            //Arrange

            //Act
            var respuesta = _productRepository.GetProductos().Result;
            //Assert
            Assert.IsTrue(respuesta.Count > 0);
        }

        [Test]
        public void B_Obtener_ProductoById_ReturnOk()
        {
            //Arrange
            string id = "0";
            //Act
            var respuesta = _productRepository.GetProductoById(id).Result;
            //Assert
            Assert.IsTrue(respuesta.Id == id);
        }

        [Test]
        public void C_Agregar_Producto_ReturnOk()
        {
            //Arrange
            var producto = new EProductosDto()
            {
                Id = "1",
                Nombre = "Prueba",
                Descripcion = "Prueba",
                Precio = 10,
                FechaCreacion = DateTime.Now.ToString()
            };
            //Act
            var respuesta = _productRepository.AddProducto(producto).Result;
            //Assert
            Assert.IsTrue(producto.Id == respuesta.Id);
        }

        [Test]
        public void D_Actualizar_Producto_ReturnOk()
        {
            SetUp();
            //Arrange
            var producto = new EProductosDto()
            {
                Id = "0",
                Nombre = "Setup",
                Descripcion = "SetUp",
                Precio = 0,
                FechaCreacion = DateTime.Now.ToString()
            };
            //Act
            var respuesta = _productRepository.UpdateProducto(producto).Result;
            //Assert
            Assert.IsTrue(producto.Id == respuesta.Id);
        }

        [Test]
        public void E_Eliminar_ProductoById_ReturnOk()
        {
            //Arrange
            string id = "0";
            //Act
            var respuesta = _productRepository.DeleteProducto(id);
            //Assert
            Assert.IsTrue(respuesta.Result);
        }
    }
}
