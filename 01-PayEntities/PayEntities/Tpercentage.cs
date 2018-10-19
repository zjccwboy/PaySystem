

using Base.Common.Attritubes;

namespace PayEntities
{
    public class TPercentage : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public decimal Fpercentage { get; set; }
        public int FchannelType { get; set; }
    }
}
