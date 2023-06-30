using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Online_Musical_Equipment_Shop_DAL.Context;
using Online_Musical_Equipment_Shop_DAL.Patterns.Interfaces;
using Online_Musical_Equipment_Shop_DAL.Patterns;
using Online_Musical_Equipment_Shop_BLL.Services.Interfaces;
using Online_Musical_Equipment_Shop_BLL.Services;
using System.Reflection;

namespace Online_Musical_Equipment_Shop_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            builder.Services.AddControllers();
            
            builder.Services.AddEndpointsApiExplorer();

          /*  builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Musical API",
                    Description = "An ASP.NET Core Web API for managing Musical items",
                });

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });*/

            builder.Services.AddDbContext<MusicalEquipmentShopContext>(configurations =>
            {
                configurations.UseSqlServer(builder.Configuration.GetConnectionString("MusicalConnection"),
                    options => options.MigrationsAssembly("OnlineMusicalEquipmentShopControllers"));
            });

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddScoped<IInstrumentsService, InstrumentsService>();

            var app = builder.Build();
/*
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

                    options.RoutePrefix = "swagger";
                });
            }*/

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}