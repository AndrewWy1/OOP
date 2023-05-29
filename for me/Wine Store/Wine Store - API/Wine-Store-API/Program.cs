using System.Data;
using System.Reflection;

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization;
using Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddSwaggerGen(s =>
{
    s.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Swagger",
        Description = "Swagger Description"
    });
});

builder.Services.AddScoped<SqlConnection>(s => new SqlConnection(builder.Configuration.GetConnectionString("SqlConnection")));
builder.Services.AddScoped<IDbTransaction>(s =>
{
    SqlConnection connection = s.GetRequiredService<SqlConnection>();
    connection.Open();
    return connection.BeginTransaction();
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IBottles, BottlesRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();

    app.UseSwaggerUI(s =>
    {
        s.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger API Version");
        s.RoutePrefix = string.Empty;
    });
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
