using System;
using System.Collections.Generic;

namespace PayDal.Ganerator.Models
{
    public partial class TAdmin
    {
        public long FaccountId { get; set; }
        public int FjobNumber { get; set; }
        public string FfirstLoginIp { get; set; }
        public string FlastLoginIp { get; set; }
        public DateTime FfirstLoginTime { get; set; }
        public DateTime FlastLoginTime { get; set; }
        public DateTime FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
