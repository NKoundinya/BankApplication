using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using BankApplication.Domain.Aggregates.BankAccountAggregate.Contracts;
using BankApplication.Domain.Aggregates.BankAccountAggregate;

namespace BankApplication.Infrastructure.Common.Repository.Commands
{
    public class BankAccountRepository : BaseRepository<BankAccount>, IBankAccountRepository
    {
        public BankAccountRepository(BankContext context) : base(context) { }
        public async Task<List<BankAccount>> FindAllDetailsAsync()
        {
            return await _context.BankAccounts
                                    .OrderBy(b => b.AccountId)
                                    .Include(b => b.Address)
                                    .Include(b => b.Proofs)
                                    .Include(b => b.Contact)
                                    .Include(b => b.Bank)
                                    .ToListAsync();
        }
    }
}