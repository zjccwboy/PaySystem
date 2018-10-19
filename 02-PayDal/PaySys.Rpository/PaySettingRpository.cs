using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class PaySettingRpository : BaseRpository<TpaySetting>
    {
        public PaySettingRpository(PayContext dbContext) : base(dbContext) { }
    }
}
