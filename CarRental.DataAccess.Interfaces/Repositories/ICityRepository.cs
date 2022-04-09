using CarRental.Core.DataAccess;
using CarRental.Entities.Concrete;

namespace CarRental.DataAccess.Interfaces
{
    public interface ICityRepository : IRepository<City, short>
    {
    }
}