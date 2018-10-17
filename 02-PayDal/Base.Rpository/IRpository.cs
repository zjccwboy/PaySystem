using PayEntities;
using System;

namespace Base.Rpository
{
    public interface IRpository<TEntity> : IRpository where TEntity : BaseEntity
    {
    }

    public interface IRpository
    {

    }
}
