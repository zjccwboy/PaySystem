using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Common.Attritubes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class KeyAttribute : Attribute
    {
    }
}
