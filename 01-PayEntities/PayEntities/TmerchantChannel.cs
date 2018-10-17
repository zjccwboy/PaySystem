

namespace PayEntities
{
    public class TmerchantChannel : BaseEntity
    {
        public long FaccountId { get; set; }
        public int Fmid { get; set; }
        public string Fchannels { get; set; }
        public string FchannelGroups { get; set; }
    }
}
