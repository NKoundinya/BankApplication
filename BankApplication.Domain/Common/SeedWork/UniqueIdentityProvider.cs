using RT.Comb;
using System;

namespace BankApplication.Domain.Common.SeedWork
{
    public class UniqueIdentityProvider
    {
        private static UtcNoRepeatTimestampProvider _noDupeProvider;
        private readonly ICombProvider _sqlNoRepeatCombs;
        public UniqueIdentityProvider()
        {
            _noDupeProvider = new UtcNoRepeatTimestampProvider();
            _sqlNoRepeatCombs = new SqlCombProvider(new SqlDateTimeStrategy(), customTimestampProvider: _noDupeProvider.GetTimestamp);

        }
        public Guid GenerateID(Guid id)
        {
            return _sqlNoRepeatCombs.Create(id);
        }

        public Guid GenerateID()
        {
            return _sqlNoRepeatCombs.Create(Guid.NewGuid());
        }
    }
}
