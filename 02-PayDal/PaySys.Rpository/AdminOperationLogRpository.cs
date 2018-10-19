using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;

namespace PaySys.Rpository
{
    public class AdminOperationLogRpository : BaseRpository<TAdminOperationLog>
    {
        public AdminOperationLogRpository(PayContext dbContext) : base(dbContext) { }
    }
}
