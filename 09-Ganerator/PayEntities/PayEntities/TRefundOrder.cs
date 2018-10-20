using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TRefundOrder
    {
        public long OderNum { get; set; }
        public string Mnum { get; set; }
        public int Mid { get; set; }
        public decimal Amount { get; set; }
        public int RefundType { get; set; }
        public decimal RefundCharge { get; set; }
        public decimal RefundAmount { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
