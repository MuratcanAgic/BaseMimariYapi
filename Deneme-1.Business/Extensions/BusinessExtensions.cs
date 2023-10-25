using Deneme_1.Business.Abstract;
using Deneme_1.Business.Concrete;
using Deneme_1.Business.Mapper.ProductProfile;
using Deneme_1.Business.ValidationRules;
using Deneme_1.Entities.Entities;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Deneme_1.Business.Extensions
{
  public static class BusinessExtensions
  {
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
      var assembly = Assembly.GetExecutingAssembly();
      //service -> manager
      services.AddScoped<IProductService, ProductManager>();
      services.AddScoped<ICategoryServices, CategoryManager>();
      //validator
      services.AddScoped<IValidator<Product>, ProductValidator>();
      services.AddAutoMapper(typeof(ProductProfile));

      return services;
    }
  }
}
