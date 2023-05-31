using BookShop.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.Title)
                   .HasMaxLength(50)
                   .IsUnicode(true);

            builder.Property(b => b.Description)
                   .HasMaxLength(1000)
                   .IsUnicode(true);

            builder.HasData(new Book()
            {
                BookId = 1,
                Title = "Book 1",
                Description = "Description 1",
                ReleaseDate = new DateTime(2022, 1, 1),
                Copies = 10,
                Price = 29.99,
                EditionType = EditionTypes.Normal,
                AgeRestriction = AgeRestrictions.Adult,
                AuthorId = 1
            }, new Book()
            {
                BookId = 2,
                Title = "Book 2",
                Description = "Description 2",
                ReleaseDate = new DateTime(2023, 2, 15),
                Copies = 5,
                Price = 19.99,
                EditionType = EditionTypes.Promo,
                AgeRestriction = AgeRestrictions.Teen,
                AuthorId = 2
            }, new Book()
            {
                BookId = 3,
                Title = "Book 3",
                Description = "Description 3",
                ReleaseDate = new DateTime(2021, 10, 5),
                Copies = 8,
                Price = 24.99,
                EditionType = EditionTypes.Gold,
                AgeRestriction = AgeRestrictions.Minor,
                AuthorId = 3
            });
        }
    }
}
