using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TChannelGroup
    {
        public long Id { get; set; }
        public string GroupName { get; set; }
        public long GroupType { get; set; }
        public string Channels { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
