namespace HotelSystem_EF.Dal.Repositories.IRepositories
{
     public interface IUnitOfWork
     {
        IAmenityRepository Amenity { get; }
        IBookingRepository Booking { get; }
        IBookingServiceRepository BookingService { get; }
        IPaymentRepository Payment { get; }
        IReviewRepository Review { get; }
        IRoomRepository Room { get; }
        IRoomAmenityRepository RoomAmenity { get; }
        IServiceRepository Service { get; }
        IUserRepository User { get; }

        Task SaveChangesAsync();
     }
}
