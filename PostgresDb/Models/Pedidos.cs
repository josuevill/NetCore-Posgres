namespace PostgresDb.Models
{
    public class Pedidos : BaseEntity
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; } = "";
        public int NumPedido { get; set; }
        public string PedidoFavorito { get; set; } = "";
        public virtual Clientes? Clientes { get; set; }
        public virtual Envios? Envios { get; set; }
    }
}