using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TPercentage
    {
        public long AccountId { get; set; }
        public decimal Percentage { get; set; }
        public int ChannelType { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
