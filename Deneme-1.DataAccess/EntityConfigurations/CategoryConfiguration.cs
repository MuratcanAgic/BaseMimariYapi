using Deneme_1.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Deneme_1.DataAccess.EntityConfigurations
{
  public class CategoryConfiguration : IEntityTypeConfiguration<Category>
  {
    public void Configure(EntityTypeBuilder<Category> builder)
    {
      builder.HasKey(x => x.Id);

      builder.Property(x => x.Name).IsRequired();

      builder.HasData(
      new Category { Id = 1, Name = "Çikolata" },
      new Category { Id = 2, Name = "Bisküvi" }
    );

    }
  }
}
