using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TadminLoginLog
    {
        public long FaccountId { get; set; }
        public string FloginIp { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
