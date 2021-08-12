using DataLayer.Infrastructures;
using DomainLayer;
using DomainLayer.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DataLayer.Repositories
{
    abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private SADPContext _dbContext;
        private readonly DbSet<T> _dbSet;

        protected IDbFactory DbFactory { get; private set; }

        protected SADPContext DbContext { get { return _dbContext ??= DbFactory.Get(); } }

        protected BaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            _dbSet = DbContext.Set<T>();
        }

        public T GetById(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null && !entity.IsDeleted)
            {
                return entity;
            }

            return null;
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(x => x.IsDeleted == false).Where(where).FirstOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.Where(x => x.IsDeleted == false);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(x => x.IsDeleted == false).Where(where);
        }

        public void Add(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            entity.LastModifiedDate = DateTime.Now;
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void MarkDelete(T entity)
        {
            entity.IsDeleted = true;
            entity.LastModifiedDate = DateTime.Now;
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
