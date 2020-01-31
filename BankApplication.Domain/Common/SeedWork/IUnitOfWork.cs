using System.Threading;
using System.Threading.Tasks;

namespace BankApplication.Domain.Common.SeedWork
{
    public interface IUnitOfWork
    {
        Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default);
        Task<bool> SaveEntitiesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
    }
}