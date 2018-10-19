
using Base.Common.Attritubes;

namespace PayEntities
{
    public class TadminOperationLog : BaseEntity
    {
        [Key]
        public long FaccountId { get; set; }
        public int FlogType { get; set; }
        public string FlogContent { get; set; }
    }
}
