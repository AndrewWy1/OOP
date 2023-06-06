using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public HotelSystemContext context { get; set; }
        public IAmenityRepository Amenity { get; }
        public IBookingRepository Booking { get; }
        public IBookingServiceRepository BookingService { get; }
        public IPaymentRepository Payment { get; }
        public IReviewRepository Review { get; }
        public IRoomRepository Room { get; }
        public IRoomAmenityRepository RoomAmenity { get; }
        public IServiceRepository Service { get; }
        public IUserRepository User { get; }


        public UnitOfWork(
            HotelSystemContext context,
            IAmenityRepository amenity,
            IBookingRepository booking,
            IBookingServiceRepository bookingService,
            IPaymentRepository payment,
            IReviewRepository review,
            IRoomRepository room,
            IRoomAmenityRepository roomAmenity,
            IServiceRepository service,
            IUserRepository user)
        {
            this.context = context;
            Amenity = amenity;
            Booking = booking;
            BookingService = bookingService;
            Payment = payment;
            Review = review;
            Room = room;
            RoomAmenity = roomAmenity;
            Service = service;
            User = user;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
