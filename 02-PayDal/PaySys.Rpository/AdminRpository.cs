using Base.Rpository;
using Microsoft.EntityFrameworkCore;
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
            return this.DbContext.TAdmin.Where(a => a.AccountId == accountId).ToAsyncEnumerable().Any();
        }

        public async Task<int> GetMaxJobNumber()
        {
            var q = this.DbContext.TAdmin.Where(a=>a != null).Select(a => a.JobNumber);
            var list = await q.ToListAsync();
            if (list.Any())
                return list.Max();

            return 0;
        }

        public async Task<TAdmin> GetAdmin(long accountId)
        {
            return await this.DbContext.TAdmin.FirstAsync(a => a.AccountId == accountId);
        }

        public async Task SetLoginInfo(long updaterId, string ip, TAdmin admin)
        {
            admin.FirstLoginIp = string.IsNullOrEmpty(admin.FirstLoginIp) ? ip : admin.FirstLoginIp;
            admin.FirstLoginTime = admin.FirstLoginTime ?? DateTime.UtcNow;
            admin.LastLoginIp = ip;
            admin.LastLoginTime = DateTime.UtcNow;
            admin.SetUpdater(updaterId);
            this.DbContext.Update(admin);
        }
    }
}
