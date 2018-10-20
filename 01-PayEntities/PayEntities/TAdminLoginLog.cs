using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TAdminLoginLog : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string LoginIp { get; set; }
    }
}
