namespace Deneme_1.Core.Helper.Response
{
  public class BaseResponse<T> where T : class
  {
    public T Data { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }

    public BaseResponse(string errorMessage)
    {
      this.Success = false;
      this.Message = errorMessage;
    }
    public BaseResponse(string successMessage, T Data)
    {
      this.Success = true;
      this.Message = successMessage;
      this.Data = Data;
    }
    public BaseResponse(T Data)
    {
      this.Success = true;
      this.Data = Data;
    }
  }
}
