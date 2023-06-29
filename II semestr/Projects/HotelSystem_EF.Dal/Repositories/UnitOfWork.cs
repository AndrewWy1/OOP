using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HotelSystemContext _context;

        public IAmenityRepository Amenity { get; private set; }
        public IUserRepository User { get; private set; }

        public IBookingRepository Booking { get; private set; }

        public IBookingServiceRepository BookingService { get; private set; }

        public IPaymentRepository Payment { get; private set; }

        public IReviewRepository Review { get; private set; }

        public IRoomRepository Room { get; private set; }

        public IRoomAmenityRepository RoomAmenity { get; private set; }

        public IServiceRepository Service { get; private set; }

        public UnitOfWork(HotelSystemContext context)
        {
            _context = context;

            Amenity = new AmenityRepository(_context);
            User = new UserRepository(_context);
            Booking = new BookingRepository(_context);
            BookingService = new BookingServiceRepository(_context);
            Payment = new PaymentRepository(_context);
            Review = new ReviewRepository(_context);
            Room = new RoomRepository(_context);
            RoomAmenity = new RoomAmenityRepository(_context);
            Service = new ServiceRepository(_context);
        }
    }
}