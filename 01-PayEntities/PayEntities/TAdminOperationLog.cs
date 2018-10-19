

namespace PayEntities
{
    public partial class TAdminOperationLog : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public int FlogType { get; set; }
        public string FlogContent { get; set; }
    }
}
