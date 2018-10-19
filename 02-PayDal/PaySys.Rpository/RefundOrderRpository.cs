using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class RefundOrderRpository : BaseRpository<TRefundOrder>
    {
        public RefundOrderRpository(PayContext dbContext) : base(dbContext) { }
    }
}
