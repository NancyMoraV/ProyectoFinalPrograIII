namespace ECommerce.Models
{
    public class Producto
    {
        public Producto()
        {
            Pedidos = new HashSet<Pedido>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public double Precio { get; set; }
        public string ImgUrl { get; set; }  

        public virtual ICollection<Pedido> Pedidos { get; set; }

    }
}
