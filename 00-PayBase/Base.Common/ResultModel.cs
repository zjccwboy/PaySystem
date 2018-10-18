using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Common
{
    public abstract class ResultModel
    {
        public int ResultCode { get; set; }
        public string Message { get; set; }
        public object DeveloperMessage { get; set; }
    }
}
