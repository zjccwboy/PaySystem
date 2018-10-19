
using Base.Common.Attritubes;

namespace PayEntities
{
    public class TAdminLoginLog : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public string FloginIp { get; set; }
    }
}
