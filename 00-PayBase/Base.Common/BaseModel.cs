using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Common
{
    public abstract class BaseModel
    {
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
    }
}
