
namespace PayEntities
{
    public class TadminOperationLog : BaseEntity
    {
        public long FaccountId { get; set; }
        public int FlogType { get; set; }
        public string FlogContent { get; set; }
    }
}
