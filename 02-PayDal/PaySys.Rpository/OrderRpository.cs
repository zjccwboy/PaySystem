﻿using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class OrderRpository : BaseRpository<Torder>
    {
        public OrderRpository(PayContext dbContext) : base(dbContext) { }
    }
}
