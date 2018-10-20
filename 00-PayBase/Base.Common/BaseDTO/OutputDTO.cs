
public abstract class OutputDTO<TModel> : IDTO where TModel : IResponseModel
{
    public TModel Result { get; set; }
}
