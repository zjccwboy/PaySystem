using System;
using System.Collections.Generic;

namespace PayDal.Ganerator.Models
{
    public partial class TNotifyTicket
    {
        public long Id { get; set; }
        public long ForderNum { get; set; }
        public int Fstate { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}
