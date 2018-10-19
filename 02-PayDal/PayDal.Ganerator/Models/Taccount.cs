using System;
using System.Collections.Generic;

namespace PayDal.Ganerator.Models
{
    public partial class TAccount
    {
        public long Id { get; set; }
        public string Fname { get; set; }
        public string Fpassword { get; set; }
        public string Femai { get; set; }
        public int Ftype { get; set; }
        public int FsecretProblem { get; set; }
        public int FsecretAnswer { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
