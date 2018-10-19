using Base.Rpository;
using PayEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySys.Rpository
{
    public class AdminRpository : BaseRpository<TAdmin>
    {
        public AdminRpository(PayContext dbContext) : base(dbContext) { }

        public Task<bool> ExistedAsync(long accountId)
        {
            return this.DbContext.TAdmin.Where(a => a.FaccountId == accountId).ToAsyncEnumerable().Any();
        }

        public Task<int> GetMaxJobNumber()
        {
            return this.DbContext.TAdmin.Select(a => a.FjobNumber).ToAsyncEnumerable().Max();
        }

    }
}
