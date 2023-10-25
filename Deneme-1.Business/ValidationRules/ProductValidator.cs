using Deneme_1.Business.Constant;
using Deneme_1.Entities.Entities;
using FluentValidation;

namespace Deneme_1.Business.ValidationRules
{
  public class ProductValidator : AbstractValidator<Product>
  {
    public ProductValidator()
    {
      RuleFor(a => a.Price).NotEmpty().GreaterThanOrEqualTo(0).WithName("Fiyat").WithMessage("{PropertyName}" + Message.GreaterThanZero);
      RuleFor(a => a.Name).NotEmpty().OverridePropertyName("İsim");
    }
  }
}
