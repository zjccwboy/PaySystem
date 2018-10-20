using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TDfOrder
    {
        public long OrderNum { get; set; }
        public string Mnum { get; set; }
        public int Mid { get; set; }
        public string FromIp { get; set; }
        public int ChannelType { get; set; }
        public string ChannelCode { get; set; }
        public decimal Amount { get; set; }
        public int State { get; set; }
        public string NotifyUrl { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
