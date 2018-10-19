

namespace PayEntities
{
    public partial class TCustomerLoginLog : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public string FloginIp { get; set; }
    }
}
