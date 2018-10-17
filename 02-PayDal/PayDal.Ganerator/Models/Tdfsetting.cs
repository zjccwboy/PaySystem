using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class Tdfsetting
    {
        public long Id { get; set; }
        public string Fsid { get; set; }
        public string FprivateKey { get; set; }
        public string FpublicKey { get; set; }
        public int FpayType { get; set; }
        public string Femail { get; set; }
        public string FredirectUrl { get; set; }
        public string Fextened { get; set; }
        public string FlastInfo { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
