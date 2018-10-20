using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TMerchant
    {
        public long AccountId { get; set; }
        public int Mid { get; set; }
        public string PayeeName { get; set; }
        public string BankName { get; set; }
        public string BankCard { get; set; }
        public string BankAddress { get; set; }
        public decimal AmountTotal { get; set; }
        public int? State { get; set; }
        public string WithdrawPwd { get; set; }
        public string Rsa2key { get; set; }
        public string RecvNotifyUrl { get; set; }
        public bool SyncJumpUrl { get; set; }
        public int DfuserGroup { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateBy { get; set; }
    }
}
