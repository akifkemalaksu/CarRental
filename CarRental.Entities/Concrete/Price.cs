using CarRental.Core.Entities;

namespace CarRental.Entities.Concrete
{
    public class Price : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime? EditDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}