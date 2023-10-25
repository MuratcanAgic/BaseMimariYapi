using AutoMapper;
using Deneme_1.Business.Abstract;
using Deneme_1.Business.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Deneme_1.Web.Controllers
{
  public class ProductController : Controller
  {
    IProductService _productService;
    IMapper _mappper;
    public ProductController(IProductService productService, IMapper mappper)
    {
      _productService = productService;
      _mappper = mappper;
    }

    public IActionResult Index()
    {
      var list = _productService.GetAll();
      //var listData = list.Data;
      try
      {
        var listDto = _mappper.Map<List<ProductViewDto>>(list.Data);
        return View(listDto);

      }
      catch (Exception e)
      {
        return View("Error");
        throw;
      }
    }
  }
}
