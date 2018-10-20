using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TChannelGroup : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string GroupName { get; set; }
        public long GroupType { get; set; }
        public string Channels { get; set; }
    }
}
