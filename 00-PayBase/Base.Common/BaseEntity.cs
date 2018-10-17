using System;
using System.Collections.Generic;
using System.Text;

namespace PayEntities
{
    public abstract class BaseEntity
    {
        public int? FcreateBy { get; set; }
        public DateTime? FcreateTime { get; set; }
        public int? FupdateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
    }
}
