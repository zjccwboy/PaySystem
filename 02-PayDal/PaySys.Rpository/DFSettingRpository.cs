﻿using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class DFSettingRpository : BaseRpository<TDFSetting>
    {
        public DFSettingRpository(PayContext dbContext) : base(dbContext) { }

    }
}
