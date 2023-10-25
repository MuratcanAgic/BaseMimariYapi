using Deneme_1.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deneme_1.DataAccess.EntityConfigurations
{
  public class ProductConfiguration : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
      builder.HasKey(x => x.Id);

      builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
      builder.Property(x => x.Price).HasColumnType("decimal(8,3)");
      //builder.Property(x => x.Description).IsRequired();

      builder.HasData(
        new Product { Id = 1, Name = "Ülker çikolatalı gofret", Price = 5m, CategoryId = 1 },
        new Product { Id = 2, Name = "Eti biskrem", Price = 2m, CategoryId = 2 }

      );

    }
  }
}
