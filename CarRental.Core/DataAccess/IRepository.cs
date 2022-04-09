using CarRental.Core.Entities;
using System;
using System.Linq.Expressions;

namespace CarRental.Core.DataAccess
{
    public interface IRepository<T, TKey>
        where T : class, IEntity<TKey>, new()
        where TKey : struct
    {
        public ICollection<T> GetMany(Expression<Func<T, bool>> expression);

        public T Get(Expression<Func<T, bool>> expression);

        public void Delete(TKey key);

        public void Add(T entity);

        public void Update(T entity);
    }
}