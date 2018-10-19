using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class DFOrderRpository : BaseRpository<TDFOrder>
    {
        public DFOrderRpository(PayContext dbContext) : base(dbContext) { }
    }
}
