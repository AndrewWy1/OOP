using BookShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.Property(a => a.FirstName)
                   .HasMaxLength(50)
                   .IsUnicode(true);

            builder.Property(a => a.LastName)
                   .HasMaxLength(50)
                   .IsUnicode(true);

            builder.HasMany(a => a.Books)
                   .WithOne(b => b.Author)
                   .HasForeignKey(b => b.AuthorId);

            builder.HasData(new Author()
            {
                AuthorId = 1,
                FirstName = "John",
                LastName = "Doe"
            }, new Author()
            {
                AuthorId = 2,
                FirstName = "Jane",
                LastName = "Smith"
            }, new Author()
            {
                AuthorId = 3,
                FirstName = "Michael",
                LastName = "Johnson"
            });
        }
    }
}
