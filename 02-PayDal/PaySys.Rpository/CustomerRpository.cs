using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;
using System.Linq;
using System.Threading.Tasks;

namespace PaySys.Rpository
{
    public class CustomerRpository : BaseRpository<Tcustomer>
    {
        public CustomerRpository(PayContext dbContext) : base(dbContext) { }

        public Task<int> GetMaxJobNumber()
        {
            return this.DbContext.Tcustomer.Select(a => a.FjobNumber).ToAsyncEnumerable().Max();
        }
    }
}
