namespace ECommerce.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }

    }
}
