using HotelSystem_EF.Dal.Data;
using System.Configuration;
using System.Windows;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using HotelSystem_EF.Dal.Repositories;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.Extensions.Configuration;
using System.IO;
using UI.ViewModels;

namespace UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost _appHost;

        public App()
        {
            _appHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {


                    services.AddDbContext<HotelSystemContext>(options =>
                    {
                        var configuration = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .Build();

                        services.AddSingleton<IConfiguration>(configuration);


                        options.UseSqlServer(hostContext.Configuration.GetConnectionString("sqlConnection"),
                            options => options.MigrationsAssembly("UI"));
                    });

                    services.AddScoped<IAmenityRepository, AmenityRepository>();
                    services.AddScoped<IBookingRepository, BookingRepository>();
                    services.AddScoped<IBookingServiceRepository, BookingServiceRepository>();
                    services.AddScoped<IPaymentRepository, PaymentRepository>();
                    services.AddScoped<IReviewRepository, ReviewRepository>();
                    services.AddScoped<IRoomAmenityRepository, RoomAmenityRepository>();
                    services.AddScoped<IRoomRepository, RoomRepository>();
                    services.AddScoped<IServiceRepository, ServiceRepository>();
                    services.AddScoped<IUserRepository, UserRepository>();
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await _appHost.StartAsync();
            using (IServiceScope scope = _appHost.Services.CreateScope())
            {
                // Виконати міграції бази даних
                HotelSystemContext db = scope.ServiceProvider.GetRequiredService<HotelSystemContext>();
                db.Database.Migrate();

                // Ваша логіка ініціалізації та показу головного вікна
                Window mainWindow = new MainWindow();
                mainWindow.DataContext = new ShowUserViewModel();
                mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                mainWindow.Show();
            }
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            try
            {
                if (_appHost != null)
                {
                    await _appHost.StopAsync();
                    _appHost.Dispose();
                }
            }
            finally
            {
                base.OnExit(e);
            }
        }
    }
}
