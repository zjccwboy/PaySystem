using Base.Rpository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Base.PayBll
{
    public abstract class BasePayBll : IPayBll
    {
        public PayContext DbContext => RpositoryFactory.DbContext;

        public bool SaveChanges()
        {
            return this.DbContext.SaveChanges() > 0;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await this.DbContext.SaveChangesAsync() > 0;
        }
    }
}
