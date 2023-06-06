using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(HotelSystemContext context) : base(context)
        { }

        public override async Task<int> CreateAsync(Payment payment)
        {
            await _entity.AddAsync(payment);

            return payment.PaymentId;
        }
    }
}
