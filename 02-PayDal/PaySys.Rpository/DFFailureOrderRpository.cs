using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class DFFailureOrderRpository : BaseRpository<TDfFailureOrder>
    {
        public DFFailureOrderRpository(PayContext dbContext) : base(dbContext) { }
    }
}
