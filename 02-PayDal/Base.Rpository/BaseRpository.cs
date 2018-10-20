using PayEntities;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using Base.Common.Utils;

namespace Base.Rpository
{
    public abstract class BaseRpository<TEntity> : IRpository<TEntity> where TEntity : BaseEntity
    {
        public PayContext DbContext { get;}

        public BaseRpository(PayContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public async Task AddAsync(TEntity entity)
        {
            SetKeyValue(typeof(TEntity), entity);
            await this.DbContext.AddAsync(entity);
        }

        private void SetKeyValue(Type type, object entity)
        {
            var propes = type.GetProperties();
            var prope = propes.Where(a => a.GetCustomAttribute(typeof(KeyAttribute)) != null).FirstOrDefault();
            var value = (long)prope.GetValue(entity);
            if(value == 0)
            {
                value = KeyCreator.CreateKey();
                prope.SetValue(entity, value);
            }
        }

    }
}
