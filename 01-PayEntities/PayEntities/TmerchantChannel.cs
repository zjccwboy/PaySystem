

using Base.Common.Attritubes;

namespace PayEntities
{
    public class TmerchantChannel : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public int Fmid { get; set; }
        public string Fchannels { get; set; }
        public string FchannelGroups { get; set; }
    }
}
