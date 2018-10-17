using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class Tmerchant
    {
        public long FaccountId { get; set; }
        public int FmerchantNumber { get; set; }
        public string FpayeeName { get; set; }
        public string FbankName { get; set; }
        public string FbankCard { get; set; }
        public string FbankAddress { get; set; }
        public decimal FamountTotal { get; set; }
        public int? Fstate { get; set; }
        public string FwithdrawPwd { get; set; }
        public string Frsa2key { get; set; }
        public string FrecvNotifyUrl { get; set; }
        public bool FsyncJumpUrl { get; set; }
        public int FdfuserGroup { get; set; }
        public DateTime? FcreateTime { get; set; }
        public int? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public int? FupdateBy { get; set; }
    }
}
