using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankApplication.Domain.Common.SeedWork
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        Task<T> GetAsync(Guid Id);
        T Add(T entity);
        Task<T> AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> FindAsync(Expression<Func<T, bool>> predicate);
    }
}