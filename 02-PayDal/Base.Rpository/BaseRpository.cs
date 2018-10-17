using PayEntities;

namespace Base.Rpository
{
    public abstract class BaseRpository<TEntity> : IRpository<TEntity> where TEntity : BaseEntity
    {
        public PayContext DbContext { get;}

        public BaseRpository(PayContext dbContext)
        {
            this.DbContext = dbContext;
        }
    }
}
