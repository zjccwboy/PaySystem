using System;
using System.Collections.Generic;

namespace PayDal.Ganerator.Models
{
    public partial class TChannelGroup
    {
        public long Id { get; set; }
        public string FgroupName { get; set; }
        public long FgroupType { get; set; }
        public string Fchannels { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
