namespace PostgresDb.Models
{
    public class Envios : BaseEntity
    {
        public int EnvioId { get; set; }
        public string FechaPedido { get; set; } = "";

        public virtual Pedidos? Pedidos { get; set; }
    }
}