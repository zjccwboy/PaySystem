using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TNotifyTicket
    {
        public long Id { get; set; }
        public long OrderNum { get; set; }
        public int State { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
