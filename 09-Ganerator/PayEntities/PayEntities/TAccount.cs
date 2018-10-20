using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TAccount
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Emai { get; set; }
        public int Type { get; set; }
        public int SecretProblem { get; set; }
        public int SecretAnswer { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
