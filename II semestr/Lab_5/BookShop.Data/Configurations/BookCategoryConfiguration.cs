using BookShop.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data.Configurations
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasKey(bc => new {bc.CategoryId, bc.BookId});
            builder.HasOne(bc => bc.Book)
                   .WithMany(b => b.BookCategories)
                   .HasForeignKey(bc => bc.BookId);

            builder.HasOne(bc => bc.Category)
                   .WithMany(b => b.BookCategories)
                   .HasForeignKey(bc => bc.CategoryId);

            builder.HasData(new BookCategory()
            {
                BookId = 1,
                CategoryId = 1,
            }, new BookCategory()
            {
                BookId = 2,
                CategoryId = 2,
            }, new BookCategory()
            {
                BookId = 3,
                CategoryId = 3,
            });
        }
    }
}
