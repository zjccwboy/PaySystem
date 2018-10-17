using Base.Rpository;
using PayEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaySys.Rpository
{
    public class AdminRpository : BaseRpository<Tadmin>
    {
        public AdminRpository(PayContext dbContext) : base(dbContext) { }


    }
}
