using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TPaySetting : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string Sid { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public int PayType { get; set; }
        public string Email { get; set; }
        public string RedirectUrl { get; set; }
        public string Extened { get; set; }
        public string LastInfo { get; set; }
    }
}
