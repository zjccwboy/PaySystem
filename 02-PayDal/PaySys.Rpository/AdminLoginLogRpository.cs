using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class AdminLoginLogRpository : BaseRpository<TAdminLoginLog>
    {
        public AdminLoginLogRpository(PayContext dbContext) : base(dbContext) { }
    }
}
