using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TCustomer
    {
        public long AccountId { get; set; }
        public int JobNumber { get; set; }
        public string FullName { get; set; }
        public string FirstLoginIp { get; set; }
        public string LastLoginIp { get; set; }
        public DateTime FirstLoginTime { get; set; }
        public DateTime LastLoginTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
