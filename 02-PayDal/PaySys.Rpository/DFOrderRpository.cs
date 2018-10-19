using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class DFOrderRpository : BaseRpository<TDfOrder>
    {
        public DFOrderRpository(PayContext dbContext) : base(dbContext) { }
    }
}
