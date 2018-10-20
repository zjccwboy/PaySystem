using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PaySys.Rpository
{
    public class CustomerRpository : BaseRpository<TCustomer>
    {
        public CustomerRpository(PayContext dbContext) : base(dbContext) { }

        public async Task<int> GetMaxJobNumber()
        {
            var q = this.DbContext.TAdmin.Where(a => a != null).Select(a => a.JobNumber);
            var list = await q.ToListAsync();
            if (list.Any())
                return list.Max();

            return 0;
        }
    }
}
