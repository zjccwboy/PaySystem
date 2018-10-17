using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TdfsuccessOrder
    {
        public long FoderNum { get; set; }
        public string FmorderNum { get; set; }
        public int Fmid { get; set; }
        public bool Fstate { get; set; }
        public string FfromIp { get; set; }
        public int FchannelType { get; set; }
        public string FchannelCode { get; set; }
        public decimal Famount { get; set; }
        public int FnotifyState { get; set; }
        public string FnotifyUrl { get; set; }
        public string FalipayId { get; set; }
        public decimal Fpercentage { get; set; }
        public DateTime? FfrozenTime { get; set; }
        public int FfrozenState { get; set; }
        public int FrefundState { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
