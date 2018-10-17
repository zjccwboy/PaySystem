using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class Torder
    {
        public long ForderNum { get; set; }
        public string FmorderNum { get; set; }
        public int Fmid { get; set; }
        public string FfromIp { get; set; }
        public int FchannelType { get; set; }
        public string FchannelCode { get; set; }
        public decimal Famount { get; set; }
        public int Fstate { get; set; }
        public string FnotifyUrl { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public int? FupdateBy { get; set; }
    }
}
