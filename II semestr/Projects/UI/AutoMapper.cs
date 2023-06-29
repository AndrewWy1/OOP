using AutoMapper;
using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.DTO.Booking;
using HotelSystem_EF.Bll.DTO.BookingService;
using HotelSystem_EF.Bll.DTO.Payment;
using HotelSystem_EF.Bll.DTO.Review;
using HotelSystem_EF.Bll.DTO.Room;
using HotelSystem_EF.Bll.DTO.RoomAmenity;
using HotelSystem_EF.Bll.DTO.Service;
using HotelSystem_EF.Bll.DTO.User;
using HotelSystem_EF.Dal.Models;

namespace UI.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            AmenityMapperConfigurations();
            BookingMapperConfigurations();
            BookingServiceMapperConfigurations();
            PaymentMapperConfigurations();
            ReviewMapperConfigurations();
            RoomMapperConfigurations();
            RoomAmenityMapperConfigurations();
            ServiceMapperConfigurations();
            UserMapperConfigurations();
        }

        private void AmenityMapperConfigurations()
        {
            CreateMap<Amenity, AmenityDTO>();

            CreateMap<AmenityDTO, Amenity>();
            CreateMap<PostAmenityDTO, Amenity>();
        }

        private void BookingMapperConfigurations()
        {
            CreateMap<Booking, BookingDTO>();

            CreateMap<BookingDTO, Booking>();
            CreateMap<PostBookingDTO, Booking>();
        }

        private void BookingServiceMapperConfigurations()
        {
            CreateMap<BookingService, BookingServiceDTO>()
                .ForMember(dest => dest.ServiseName, opt => opt.MapFrom(src => src.Service.ServiceName));

            CreateMap<BookingServiceDTO, BookingService>()
                .ForPath(dest => dest.Service.ServiceName, opts => opts.MapFrom(src => src.ServiseName));
        }

        private void PaymentMapperConfigurations()
        {
            CreateMap<Payment, PaymentDTO>();

            CreateMap<PaymentDTO, Payment>();
            CreateMap<PostPaymentDTO, Payment>();
        }

        private void ReviewMapperConfigurations()
        {
            CreateMap<Payment, PaymentDTO>();

            CreateMap<ReviewDTO, Review>();
            CreateMap <PostReviewDTO, Review>();
        }

        private void RoomMapperConfigurations()
        {
            CreateMap<Room, RoomDTO>();

            CreateMap<RoomDTO, Room>();
            CreateMap<PostRoomDTO, Room>();
        }

        private void RoomAmenityMapperConfigurations()
        {
            CreateMap<RoomAmenity, RoomAmenityDTO>();

            CreateMap<RoomAmenityDTO, RoomAmenity>();
            CreateMap<PostRoomAmenityDTO, RoomAmenity>();
        }

        private void ServiceMapperConfigurations()
        {
            CreateMap<Service, ServiceDTO>();

            CreateMap<ServiceDTO, Service>();
            CreateMap<PostServiceDTO, Service>();
        }

        private void UserMapperConfigurations()
        {
            CreateMap<User, UserDTO>();

            CreateMap<UserDTO, User>();
            CreateMap<PostUserDTO, User>();
        }
    }
}
