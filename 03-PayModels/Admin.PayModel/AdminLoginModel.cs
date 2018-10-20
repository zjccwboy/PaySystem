using Base.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Admin.PayModel
{
    public class AdminLoginModel : IRequestModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string VerifyCode { get; set; }
    }
}
