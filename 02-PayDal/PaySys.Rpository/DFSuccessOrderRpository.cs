﻿using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class DFSuccessOrderRpository : BaseRpository<TDFSuccessOrder>
    {
        public DFSuccessOrderRpository(PayContext dbContext) : base(dbContext) { }

    }
}
