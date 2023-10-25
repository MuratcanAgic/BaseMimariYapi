using Deneme_1.Core.Helper.Response;

namespace Deneme_1.Core.Helper.Business
{
  public class BusinessRules<T> where T : class
  {
    public static BaseResponse<T> Run(params BaseResponse<T>[] logics)
    {
      foreach (var logic in logics)
      {
        if (!logic.Success)
        {
          return logic;
        }
      }

      return null;
    }
  }
}
