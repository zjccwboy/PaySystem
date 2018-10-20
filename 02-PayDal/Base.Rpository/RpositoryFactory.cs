using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Concurrent;

namespace Base.Rpository
{
    public static class RpositoryFactory
    {
        public static PayContext DbContext { get; set; }
        private static ConcurrentDictionary<Type, IRpository> Rpositorys { get; } = new ConcurrentDictionary<Type, IRpository>();
        static RpositoryFactory()
        {
            DbContext = new PayContext(new DbContextOptions<PayContext>());
        }

        public static TRpository Create<TRpository>() where TRpository : class,IRpository
        {
            var type = typeof(TRpository);
            if(!Rpositorys.TryGetValue(type, out IRpository rpository))
            {
                rpository = (IRpository)Activator.CreateInstance(type, DbContext);
                Rpositorys.AddOrUpdate(type, rpository,(k, v) => rpository);
            }
            return (TRpository)rpository;
        }
    }
}
