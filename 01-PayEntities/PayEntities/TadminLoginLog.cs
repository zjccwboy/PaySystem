
using Base.Common.Attritubes;

namespace PayEntities
{
    public class TadminLoginLog : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public string FloginIp { get; set; }
    }
}
