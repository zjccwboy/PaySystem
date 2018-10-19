using System;
using System.Collections.Generic;
using System.Text;
using Base.Rpository;
using PayEntities;


namespace PaySys.Rpository
{
    public class CustomerLoginLogRpository : BaseRpository<TcustomerLoginLog>
    {
        public CustomerLoginLogRpository(PayContext dbContext) : base(dbContext) { }
    }
}
