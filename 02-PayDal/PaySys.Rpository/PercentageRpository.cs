﻿using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class PercentageRpository : BaseRpository<TPercentage>
    {
        public PercentageRpository(PayContext dbContext) : base(dbContext) { }
    }
}
