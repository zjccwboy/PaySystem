﻿using System;

namespace PayEntities
{
    public class Tcustomer : BaseEntity
    {
        public long FaccountId { get; set; }
        public int FjobNumber { get; set; }
        public string FfullName { get; set; }
        public string FfirstLoginIp { get; set; }
        public string FlastLoginIp { get; set; }
        public DateTime FfirstLoginTime { get; set; }
        public DateTime FlastLoginTime { get; set; }
    }
}