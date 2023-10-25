using Deneme_1.Business.Abstract;
using Deneme_1.Core.Helper.Response;
using Deneme_1.Entities.Entities;
using FluentValidation.Results;
using System.Linq.Expressions;

namespace Deneme_1.Business.Concrete
{
  public class CategoryManager : ICategoryServices
  {
    public BaseResponse<Category> Add(Category entity)
    {
      throw new NotImplementedException();
    }

    public BaseResponse<Category> Delete(Category entity)
    {
      throw new NotImplementedException();
    }

    public BaseResponse<Category> Get(Expression<Func<Category, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public BaseResponse<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null)
    {
      throw new NotImplementedException();
    }

    public BaseResponse<Category> Update(Category entity)
    {
      throw new NotImplementedException();
    }

    public ValidationResult Validate(Category entity)
    {
      throw new NotImplementedException();
    }
  }
}
