using System;
using System.Collections.Generic;

namespace PayDal.Ganerator.Models
{
    public partial class TAdminOperationLog
    {
        public long FaccountId { get; set; }
        public int FlogType { get; set; }
        public string FlogContent { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
