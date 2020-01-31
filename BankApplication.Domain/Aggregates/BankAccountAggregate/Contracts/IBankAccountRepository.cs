using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;
using BankApplication.Domain.Common.SeedWork;

namespace BankApplication.Domain.Aggregates.BankAccountAggregate.Contracts
{
    public interface IBankAccountRepository : IRepository<BankAccount>
    {
        Task<List<BankAccount>> FindAllDetailsAsync();
    }
}