using System.ComponentModel.DataAnnotations;

namespace ShopManager.Entity.Modelo
{
    public class EUsuarioModel
    {
        [Key]
        public string ID { get; set; } = string.Empty;
        public string USER_NAME { get; set; } = string.Empty;
        public string CREATION_DATE { get; set; } = string.Empty;
    }
}
