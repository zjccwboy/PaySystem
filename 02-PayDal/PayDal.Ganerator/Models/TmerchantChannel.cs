using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TmerchantChannel
    {
        public long FaccountId { get; set; }
        public int Fmid { get; set; }
        public string Fchannels { get; set; }
        public string FchannelGroups { get; set; }
        public DateTime? FcreateTime { get; set; }
        public int? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public int? FupdateBy { get; set; }
    }
}
