using AutoMapper;
using HotelSystem_EF.Bll.DTO.Payment;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public PaymentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<PaymentDTO>> GetAllAsync()
        {
            var result = await _uow.Payment.GetAllAsync();
            return _mapper.Map<IEnumerable<Payment>, IEnumerable<PaymentDTO>>(result);
        }


        public async Task<PaymentDTO> GetByIdAsync(int Id)
        {
            var result = await _uow.Payment.GetByIdAsync(Id);

            return _mapper.Map<PaymentDTO>(result);
        }

        public async Task<PaymentDTO> CreateAsync(PostPaymentDTO paymentDTO)
        {
            var result = await _uow.Payment.CreateAsync(_mapper.Map<Payment>(paymentDTO));

            return _mapper.Map<PaymentDTO>(result);
        }

        public async Task<PaymentDTO> UpdateAsync(PaymentDTO paymentDTO)
        {
            var result = await _uow.Payment.UpdateAsync(_mapper.Map<Payment>(paymentDTO));

            return _mapper.Map<PaymentDTO>(result);
        }

        public async Task<PaymentDTO> DeleteAsync(int Id)
        {
            var result = await _uow.Payment.DeleteAsync(Id);

            return _mapper.Map<PaymentDTO>(result);
        }
    }
}
