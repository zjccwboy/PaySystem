
namespace PayEntities
{
    public partial class TAdminLoginLog : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public string FloginIp { get; set; }
    }
}
