

namespace PostgresDb.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaActual { get; set; }
    }
}