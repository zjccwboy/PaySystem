
public abstract class InputDTO<TInputModel, TOutputModel> : IDTO where TInputModel : IRequestModel where TOutputModel : IResponseModel
{
    public TInputModel Model { get; set; }
    public TOutputModel Result { get; set; }
}
