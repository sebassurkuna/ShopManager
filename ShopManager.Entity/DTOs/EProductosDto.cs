namespace ShopManager.Entity.DTOs
{
    public class EProductosDto
    {
        public string Id { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; } = decimal.Zero;
        public string FechaCreacion { get; set; } = string.Empty;
    }
}
