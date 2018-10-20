using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TNotifyTicket : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long OrderNum { get; set; }
        public int State { get; set; }
    }
}
