using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TMerchantChannel
    {
        public long AccountId { get; set; }
        public int Mid { get; set; }
        public string Channels { get; set; }
        public string ChannelGroups { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateBy { get; set; }
    }
}
