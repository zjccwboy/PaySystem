﻿using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class MerchantExtendRpository : BaseRpository<TMerchantExtend>
    {
        public MerchantExtendRpository(PayContext dbContext) : base(dbContext) { }
    }
}
