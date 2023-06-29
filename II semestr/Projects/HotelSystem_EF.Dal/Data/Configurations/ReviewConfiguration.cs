using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Comment)
            .HasMaxLength(250);


            builder.HasData(
            new Review
            {
                Id = 1,
                Rating = 4.5,
                Comment = "Great experience!",
                ReviewDate = DateTime.Now,
                UserId = 1
            },
            new Review
            {
                Id = 2,
                Rating = 3.8,
                Comment = "Average service",
                ReviewDate = DateTime.Now,
                UserId = 2
            },
            new Review
            {
                Id = 3,
                Rating = 5.0,
                Comment = "Highly recommended!",
                ReviewDate = DateTime.Now,
                UserId = 3
            },
            new Review
            {
                Id = 4,
                Rating = 2.5,
                Comment = "Disappointing stay",
                ReviewDate = DateTime.Now,
                UserId = 4
            }
        );
        }
    }
}
