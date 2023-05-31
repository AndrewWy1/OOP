using BookShop.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name)
                   .HasMaxLength(50)
                   .IsUnicode(true);

            builder.HasData(new Category()
            {
                CategoryId = 1,
                Name = "Category 1"
            }, new Category()
            {
                CategoryId = 2,
                Name = "Category 2"
            }, new Category()
            {
                CategoryId = 3,
                Name = "Category 3"
            });
        }
    }
}
