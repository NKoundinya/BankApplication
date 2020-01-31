using System;
using System.Threading;
using System.Threading.Tasks;
using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Infrastructure.Common.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BankContext _context;
        public UnitOfWork(BankContext context)
        {
            _context = context;
        }
        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            var isValid = false;
            try
            {
                var result = await _context.SaveChangesAsync(cancellationToken);
                if (result > 0)
                {
                    isValid = true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return isValid;
        }
        public async Task<bool> SaveEntitiesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var isValid = false;
            try
            {
                var result = await _context.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
                if (result > 0)
                {
                    isValid = true;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return isValid;
        }
    }
}