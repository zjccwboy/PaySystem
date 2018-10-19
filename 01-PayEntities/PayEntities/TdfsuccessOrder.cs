using Base.Common.Attritubes;
using System;

namespace PayEntities
{
    public class TdfsuccessOrder : BaseEntity
    {
        [Key]
        public long FoderNum { get; set; }
        public string FmorderNum { get; set; }
        public int Fmid { get; set; }
        public bool Fstate { get; set; }
        public string FfromIp { get; set; }
        public int FchannelType { get; set; }
        public string FchannelCode { get; set; }
        public decimal Famount { get; set; }
        public int FnotifyState { get; set; }
        public string FnotifyUrl { get; set; }
        public string FalipayId { get; set; }
        public decimal Fpercentage { get; set; }
        public DateTime? FfrozenTime { get; set; }
        public int FfrozenState { get; set; }
        public int FrefundState { get; set; }
    }
}
