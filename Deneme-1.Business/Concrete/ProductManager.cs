using Deneme_1.Business.Abstract;
using Deneme_1.Core.Helper.Business;
using Deneme_1.Core.Helper.Response;
using Deneme_1.DataAccess.Abstract;
using Deneme_1.Entities.Entities;
using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;

namespace Deneme_1.Business.Concrete
{
  public class ProductManager : IProductService
  {
    private readonly IProductDal _productDal;
    private readonly IValidator<Product> _productValidator;

    public ProductManager(IProductDal productDal, IValidator<Product> productValidator)
    {
      _productDal = productDal;
      _productValidator = productValidator;

    }

    public BaseResponse<Product> Add(Product entity)
    {
      try
      {
        BaseResponse<Product> result = BusinessRules<Product>.Run();

        if (result != null)
        {
          return new BaseResponse<Product>(result.Message);
        }

        _productDal.Add(entity);
        return new BaseResponse<Product>("Ekleme başarılı", entity);
      }
      catch (Exception ex)
      {
        return new BaseResponse<Product>(ex.Message);
      }
    }

    public BaseResponse<Product> Delete(Product entity)
    {
      throw new NotImplementedException();
    }

    public BaseResponse<Product> Get(Expression<Func<Product, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public BaseResponse<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null)
    {
      try
      {
        BaseResponse<Product> result = BusinessRules<Product>.Run();

        if (result != null)
        {
          return new BaseResponse<List<Product>>(result.Message);
        }

        var productList = _productDal.GetAll();
        return new BaseResponse<List<Product>>("List döndürme başarılı", productList);
      }
      catch (Exception ex)
      {
        return new BaseResponse<List<Product>>(ex.Message);
      }
    }

    public BaseResponse<Product> Update(Product entity)
    {
      throw new NotImplementedException();
    }

    public ValidationResult Validate(Product entity)
    {
      return _productValidator.Validate(entity);
    }
  }
}
