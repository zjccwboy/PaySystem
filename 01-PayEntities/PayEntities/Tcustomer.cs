using Base.Common.Attritubes;
using System;

namespace PayEntities
{
    public class TCustomer : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public int FjobNumber { get; set; }
        public string FfullName { get; set; }
        public string FfirstLoginIp { get; set; }
        public string FlastLoginIp { get; set; }
        public DateTime FfirstLoginTime { get; set; }
        public DateTime FlastLoginTime { get; set; }
    }
}