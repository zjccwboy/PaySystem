using System;
using System.Collections.Generic;

namespace PayDal.Ganerator.Models
{
    public partial class TRefundOrder
    {
        public long FoderNum { get; set; }
        public string FmorderNum { get; set; }
        public int Fmid { get; set; }
        public decimal Famount { get; set; }
        public int FrefundType { get; set; }
        public decimal FrefundCharge { get; set; }
        public decimal FrefundAmount { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
