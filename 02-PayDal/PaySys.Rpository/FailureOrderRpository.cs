using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;


namespace PaySys.Rpository
{
    public class FailureOrderRpository : BaseRpository<TfailureOrder>
    {
        public FailureOrderRpository(PayContext dbContext) : base(dbContext) { }
    }
}
