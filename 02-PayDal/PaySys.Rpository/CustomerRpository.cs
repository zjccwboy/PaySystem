using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class CustomerRpository : BaseRpository<Tcustomer>
    {
        public CustomerRpository(PayContext dbContext) : base(dbContext) { }
    }
}
