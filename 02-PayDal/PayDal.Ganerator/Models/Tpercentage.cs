﻿using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class Tpercentage
    {
        public long FaccountId { get; set; }
        public decimal Fpercentage { get; set; }
        public int FchannelType { get; set; }
        public DateTime? FcreateTime { get; set; }
        public long? FcreateBy { get; set; }
        public DateTime? FupdateTime { get; set; }
        public long? FupdateBy { get; set; }
    }
}