using System;
using System.Collections.Generic;
using System.Text;

public class ResponseModel<TModel> : ResponseModel where TModel : BaseModel
{
    public TModel Body { get; set; }
}

public class ResponseModel
{
    public int ResultCode { get; set; }
    public string Message { get; set; }
    public object DeveloperMessage { get; set; }
}