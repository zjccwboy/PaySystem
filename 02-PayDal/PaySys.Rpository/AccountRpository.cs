using Base.Rpository;
using PayEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaySys.Rpository
{
    public class AccountRpository : BaseRpository<Taccount>
    {
        public AccountRpository(PayContext dbContext) : base(dbContext) { }
    }
}
