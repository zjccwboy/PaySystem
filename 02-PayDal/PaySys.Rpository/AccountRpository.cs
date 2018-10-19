﻿using Base.Rpository;
using PayEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PaySys.Rpository
{
    public class AccountRpository : BaseRpository<Taccount>
    {
        public AccountRpository(PayContext dbContext) : base(dbContext) { }

        public Task<bool> ExistedAsync(string name)
        {
            return this.DbContext.Taccount.Where(a => a.Fname == name).ToAsyncEnumerable().Any();
        }

    }
}
