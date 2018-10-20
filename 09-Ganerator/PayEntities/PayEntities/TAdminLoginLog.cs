using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TAdminLoginLog
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string LoginIp { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
