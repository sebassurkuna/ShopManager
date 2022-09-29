using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Entity.Modelo
{
    public class EOrdenProductoModel
    {
        [Key]
        public string ID { get; set; } = string.Empty;
        [ForeignKey("PEDIDO")]
        public string ID_PEDIDO { get; set; } = string.Empty;
        public  EPedidoModel? PEDIDO { get; set; }
        [ForeignKey("PRODUCTO")]
        public string ID_PRODUCTO { get; set; } = string.Empty;
        public  EProductoModel? PRODUCTO { get; set; }
        public string CREATION_DATE { get; set; } = string.Empty;

    }
}
