﻿

namespace PayEntities
{
    public class TdffailureOrder : BaseEntity
    {
        public long ForderNum { get; set; }
        public string FmorderNum { get; set; }
        public int Fmid { get; set; }
        public string FfromIp { get; set; }
        public int FchannelType { get; set; }
        public string FchannelCode { get; set; }
        public decimal Famount { get; set; }
    }
}