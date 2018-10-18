using Base.Common.Attritubes;
using System;

namespace PayEntities
{
    public class TmerchantExtend : BaseEntity
    {
        [Key]
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
    }
}
