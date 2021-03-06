using CarRental.Core.Entities;

namespace CarRental.Entities.Concrete
{
    public class Currency : IEntity<byte>
    {
        public byte Id { get; set; }
        public DateTime? EditDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}