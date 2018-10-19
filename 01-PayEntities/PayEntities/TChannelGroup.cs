

namespace PayEntities
{
    public partial class TChannelGroup : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string FgroupName { get; set; }
        public long FgroupType { get; set; }
        public string Fchannels { get; set; }
    }
}
