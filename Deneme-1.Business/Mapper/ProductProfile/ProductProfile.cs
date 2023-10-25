using AutoMapper;
using Deneme_1.Business.Dtos;
using Deneme_1.Entities.Entities;

namespace Deneme_1.Business.Mapper.ProductProfile
{
  public class ProductProfile : Profile
  {
    public ProductProfile()
    {
      CreateMap<Product, ProductViewDto>().ReverseMap();
      //CreateMap<ProductViewDto, Product>();
    }
  }
}
