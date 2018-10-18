using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Base.PayBll
{
    public static class PayBllFactory
    {
        private static ConcurrentDictionary<Type, IPayBll> Blls = new ConcurrentDictionary<Type, IPayBll>();

        public  static TBll Create<TBll>() where TBll : class, IPayBll
        {
            var type = typeof(TBll);
            if (!Blls.TryGetValue(type, out IPayBll rpository))
            {
                rpository = (IPayBll)Activator.CreateInstance(type);
                Blls.AddOrUpdate(type, rpository, (k, v) => rpository);
            }
            return (TBll)rpository;
        }
    }
}
