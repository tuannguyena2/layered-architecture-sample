using System;
using System.Linq;
using System.Linq.Expressions;

namespace DataLayer.Abstractions
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        T Get(Expression<Func<T, bool>> where);
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> where);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void MarkDelete(T entity);
    }
}
