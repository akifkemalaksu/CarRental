using CarRental.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace CarRental.Core.DataAccess.EntityFramework
{
    public class RepositoryBase<T, TKey> : IRepository<T, TKey>
        where T : class, IEntity<TKey>, new()
        where TKey : struct
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(DbContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            entity.CreateDate = DateTime.Now;
            _dbContext.Add(entity);
        }

        public void Delete(TKey key)
        {
            var entity = GetByKey(key);
            Delete(entity);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Find(expression);
        }

        public ICollection<T> GetMany(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToList();
        }

        public void Update(T entity)
        {
            entity.EditDate = DateTime.Now;
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        private void Delete(T entity) => _dbContext.Entry(entity).State = EntityState.Deleted;

        private T GetByKey(TKey key) => _dbSet.Find(key);
    }
}