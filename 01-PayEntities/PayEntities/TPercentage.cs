

namespace PayEntities
{
    public partial class TPercentage : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public decimal Fpercentage { get; set; }
        public int FchannelType { get; set; }
    }
}
