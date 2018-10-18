using System;
using System.Collections.Generic;
using System.Text;

namespace PayEntities
{
    public abstract class BaseEntity
    {
        public long? FcreateBy { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FupdateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
    }

    public static class EntityExtensions
    {
        public static void SetCreator<TEntity>(this TEntity entity, long creatorId) where TEntity : BaseEntity
        {
            entity.FcreateBy = creatorId;
            entity.FcreateTime = DateTime.UtcNow;
        }

        public static void SetUpdater<TEntity>(this TEntity entity, long creatorId) where TEntity : BaseEntity
        {
            entity.FupdateBy = creatorId;
            entity.FupdateTime = DateTime.UtcNow;
        }
    }

}
