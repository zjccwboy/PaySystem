using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TAdminOperationLog
    {
        public long Id { get; set; }
        public long? AccountId { get; set; }
        public int LogType { get; set; }
        public string LogContent { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
