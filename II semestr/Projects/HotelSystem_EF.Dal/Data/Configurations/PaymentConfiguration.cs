using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);


           builder.HasData(
           new Payment
           {
               Id = 1,
               Amount = 100.0,
               PaymentDate = DateTime.Now,
               BookingId = 1
           },
           new Payment
           {
               Id = 2,
               Amount = 150.0,
               PaymentDate = DateTime.Now,
               BookingId = 2
           },
           new Payment
           {
               Id = 3,
               Amount = 200.0,
               PaymentDate = DateTime.Now,
               BookingId = 3
           },
           new Payment
           {
               Id = 4,
               Amount = 120.0,
               PaymentDate = DateTime.Now,
               BookingId = 4
           }
       );
        }
    }

}
