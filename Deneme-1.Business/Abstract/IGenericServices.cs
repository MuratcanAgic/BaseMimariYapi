using Deneme_1.Core.Helper.Response;
using FluentValidation.Results;
using System.Linq.Expressions;

namespace Deneme_1.Business.Abstract
{
  public interface IGenericServices<T> where T : class
  {
    BaseResponse<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
    BaseResponse<T> Get(Expression<Func<T, bool>> filter);
    BaseResponse<T> Add(T entity);
    BaseResponse<T> Update(T entity);
    BaseResponse<T> Delete(T entity);
    ValidationResult Validate(T entity);
  }
}
