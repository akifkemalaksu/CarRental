using CarRental.Core.Entities;
using System;

namespace CarRental.Entities.Concrete
{
    public class Car : IEntity<int>
    {
        public int Id { get; set; }
        public DateTime? EditDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}