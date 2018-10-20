﻿using System;
using System.Collections.Generic;

namespace PayEntities
{
    public partial class TMerchantExtend
    {
        public long AccountId { get; set; }
        public int Mid { get; set; }
        public string Mname { get; set; }
        public string Address { get; set; }
        public string IdCard { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Postcode { get; set; }
        public string StieUrl { get; set; }
        public string Qq { get; set; }
        public string Msn { get; set; }
        public string LastLoginIp { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string WithdrawPwd { get; set; }
        public string Remark { get; set; }
        public string GoogleSecretKey { get; set; }
        public DateTime? CreateTime { get; set; }
        public long? CreateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public long? UpdateBy { get; set; }
    }
}
