using CarRental.Core.DataAccess;
using CarRental.Entities.Concrete;
using System;

namespace CarRental.DataAccess.Interfaces
{
    public interface ICarRepository : IRepository<Car, int>
    {
    }
}