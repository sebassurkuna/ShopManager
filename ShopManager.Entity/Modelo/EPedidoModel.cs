using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopManager.Entity.Modelo
{
    public class EPedidoModel
    {
        [Key]
        public string ID { get; set; } = string.Empty;
        [ForeignKey("USUARIO")]
        public string CLIENTE_ID { get; set; } = string.Empty;
        virtual public EUsuarioModel? USUARIO { get; set; }
    }
}
