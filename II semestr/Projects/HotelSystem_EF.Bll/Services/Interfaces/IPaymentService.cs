using HotelSystem_EF.Bll.DTO.Payment;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentDTO>> GetAllAsync();

        Task<PaymentDTO> GetByIdAsync(int Id);

        Task<PaymentDTO> CreateAsync(PostPaymentDTO paymentDTO);

        Task<PaymentDTO> UpdateAsync(PaymentDTO paymentDTO);

        Task<PaymentDTO> DeleteAsync(int Id);
    }
}

