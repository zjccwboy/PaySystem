﻿using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;


namespace PaySys.Rpository
{
    public class CustomerLoginLogRpository : BaseRpository<TCustomerLoginLog>
    {
        public CustomerLoginLogRpository(PayContext dbContext) : base(dbContext) { }
    }
}
