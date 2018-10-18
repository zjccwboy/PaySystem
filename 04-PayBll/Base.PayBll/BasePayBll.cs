using Base.Rpository;
using Microsoft.EntityFrameworkCore;

namespace Base.PayBll
{
    public abstract class BasePayBll : IPayBll
    {
        public DbContext DbContext => RpositoryFactory.DbContext;
    }
}
