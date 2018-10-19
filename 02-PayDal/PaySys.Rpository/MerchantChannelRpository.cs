using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class MerchantChannelRpository : BaseRpository<TmerchantChannel>
    {
        public MerchantChannelRpository(PayContext dbContext) : base(dbContext) { }
    }
}
