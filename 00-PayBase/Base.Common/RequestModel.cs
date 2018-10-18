using System;
using System.Collections.Generic;
using System.Text;

public class RequestModel<TModel> : RequestMode where TModel : BaseModel
{
    public TModel Body { get; set; }
}

public class RequestMode
{
    public string Version { get; set; } = "1.0";
    public long? UserId { get; set; }
}