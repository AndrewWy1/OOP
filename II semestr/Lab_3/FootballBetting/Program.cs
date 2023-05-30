using FootballBetting.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FootballBettingContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("FootballBetting")));

var app = builder.Build();

app.Run();
