
using Base.Common.Attritubes;
using Base.Common.Enums;

namespace PayEntities
{
    public class TAccount : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string Fname { get; set; }
        public string Fpassword { get; set; }
        public string Femai { get; set; }
        public AccountType Ftype { get; set; }
        public int FsecretProblem { get; set; }
        public int FsecretAnswer { get; set; }
    }
}
