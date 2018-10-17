using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TmerchantExtend
    {
        public long FaccountId { get; set; }
        public int Fmid { get; set; }
        public string Fmname { get; set; }
        public string Faddress { get; set; }
        public string FidCard { get; set; }
        public string FfullName { get; set; }
        public string Fphone { get; set; }
        public string Fmobile { get; set; }
        public string Fpostcode { get; set; }
        public string FstieUrl { get; set; }
        public string Fqq { get; set; }
        public string Fmsn { get; set; }
        public string FlastLoginIp { get; set; }
        public DateTime? FlastLoginTime { get; set; }
        public string FwithdrawPwd { get; set; }
        public string Fremark { get; set; }
        public string FgoogleSecretKey { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
