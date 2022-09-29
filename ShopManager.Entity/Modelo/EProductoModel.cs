using System.ComponentModel.DataAnnotations;

namespace ShopManager.Entity.Modelo
{
    public class EProductoModel
    {
        [Key]
        public string ID { get; set; } = string.Empty;
        public string NAME { get; set; } = string.Empty;
        public string DESCRIPTION { get; set; } = string.Empty;
        public decimal PRICE { get; set; } = decimal.Zero;
        public string CREATION_DATE { get; set; } = string.Empty;

    }
}
