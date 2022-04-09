using CarRental.Core.DataAccess;
using CarRental.Entities.Concrete;

namespace CarRental.DataAccess.Interfaces
{
    public interface IPaymentRepository : IRepository<Payment, int>
    {
    }
}