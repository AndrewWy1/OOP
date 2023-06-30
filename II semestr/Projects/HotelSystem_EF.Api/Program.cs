using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using HotelSystem_EF.Dal.Repositories;
using Microsoft.EntityFrameworkCore;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Bll.Services;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Reflection;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAutoMapper(typeof(Program).Assembly);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSwaggerGen();


        builder.Services.AddDbContext<HotelSystemContext>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"),
            options => options.MigrationsAssembly("HotelSystem_EF.Api")));

        builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        builder.Services.AddScoped(typeof(IGenericTransitiveReposetory<>), typeof(GenericTransitiveRepository<>));
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IAmenityService, AmenityService>();
        builder.Services.AddScoped<IBookingServices, BookingServices>();
        builder.Services.AddScoped<IBookingServiceService, BookingServiceService>();
        builder.Services.AddScoped<IPaymentService, PaymentService>();
        builder.Services.AddScoped<IReviewService, ReviewService>();
        builder.Services.AddScoped<IRoomService, RoomService>();
        builder.Services.AddScoped<IRoomAmenityService, RoomAmenityService>();
        builder.Services.AddScoped<IServiceService, ServiceService>();
        builder.Services.AddScoped<IUserService, UserService>();


        var app = builder.Build();

        //if (app.Environment.IsDevelopment())
        //{
        //    app.UseSwagger();
        //    app.UseSwaggerUI();
        //}

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
