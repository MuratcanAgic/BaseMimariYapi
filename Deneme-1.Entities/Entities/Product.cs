using Deneme_1.Core.Entities.Concrete;

namespace Deneme_1.Entities.Entities
{
  public class Product : EntityBase
  {
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
  }
}
