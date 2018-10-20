
public class RequestModel<TModel> : RequestModel
{
    public TModel Body { get; set; }
}

public class RequestModel : IRequestModel
{
    public string Version { get; set; } = "1.0";
    public long? UserId { get; set; }
}