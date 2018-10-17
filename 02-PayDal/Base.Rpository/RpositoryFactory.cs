﻿using System;
using System.Collections.Concurrent;

namespace Base.Rpository
{
    public static class RpositoryFactory
    {
        private static PayContext DbContext { get;}
        private static ConcurrentDictionary<Type, IRpository> Rpositorys { get; } = new ConcurrentDictionary<Type, IRpository>();
        static RpositoryFactory()
        {
            DbContext = new PayContext();
        }

        public static TRpository Create<TRpository>() where TRpository : class,IRpository
        {
            var type = typeof(IRpository);
            if(!Rpositorys.TryGetValue(type, out IRpository rpository))
            {
                rpository = (IRpository)Activator.CreateInstance(type, DbContext);
                Rpositorys.AddOrUpdate(type, rpository,(k, v) => rpository);
            }
            return (TRpository)rpository;
        }
    }
}
