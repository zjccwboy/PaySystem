
namespace PayEntities
{
    public class Taccount : BaseEntity
    {
        public long Id { get; set; }
        public string Fname { get; set; }
        public string Fpassword { get; set; }
        public string Femai { get; set; }
        public int Ftype { get; set; }
        public int FsecretProblem { get; set; }
        public int FsecretAnswer { get; set; }
    }
}
