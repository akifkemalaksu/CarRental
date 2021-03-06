using CarRental.Core.Entities;

namespace CarRental.Entities.Concrete
{
    public class City : IEntity<short>
    {
        public short Id { get; set; }
        public DateTime? EditDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}