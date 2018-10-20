using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TMerchantChannel : BaseEntity
    {
        [Key]
        public long AccountId { get; set; }
        public int Mid { get; set; }
        public string Channels { get; set; }
        public string ChannelGroups { get; set; }
    }
}
