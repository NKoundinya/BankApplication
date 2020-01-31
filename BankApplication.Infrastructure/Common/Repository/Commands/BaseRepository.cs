using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Infrastructure.Common.Repository.Commands
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IAggregateRoot
    {
        protected readonly BankContext _context;
        protected DbSet<T> entities;
        public BaseRepository(BankContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }
        public async Task<T> GetAsync(Guid Id)
        {
            return await entities.FindAsync(Id);
        }
        public T Add(T entity)
        {
            return entities.Add(entity).Entity;
        }
        public async Task<T> AddAsync(T entity)
        {
            await entities.AddAsync(entity);
            return entity;

        }
        public async Task<List<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }
        public async Task<T> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await entities.FirstOrDefaultAsync(predicate);
        }
    }
}