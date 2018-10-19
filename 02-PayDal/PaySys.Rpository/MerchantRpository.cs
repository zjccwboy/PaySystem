using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class MerchantRpository : BaseRpository<TMerchant>
    {
        public MerchantRpository(PayContext dbContext) : base(dbContext) { }
    }
}
