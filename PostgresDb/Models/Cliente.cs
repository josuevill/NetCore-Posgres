namespace PostgresDb.Models
{
    public class Clientes : BaseEntity
    {
        public Clientes()
        {
            Pedidos = new HashSet<Pedidos>();
        }

        public string Nombre { get; set; } = "";
        public int Anio { get; set; } = 2022;

        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}