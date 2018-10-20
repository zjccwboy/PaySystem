using Base.Rpository;
using PayEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PaySys.Rpository
{
    public class AccountRpository : BaseRpository<TAccount>
    {
        public AccountRpository(PayContext dbContext) : base(dbContext) { }

        public async Task<bool> ExistedAsync(string name)
        {
            var q = this.DbContext.TAccount.Where(a=>a.Name == name);
            var t = await q.ToListAsync();
            return t.Any();
        }

    }
}
