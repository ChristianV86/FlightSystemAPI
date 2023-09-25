using FlightSystem.BLL;
using FlightSystem.BLL.Models;
using FlightSystem.DAL;
using FlightSystem.DAL.Data;
using FlightSystem.DAL.Repository.IRepository;
using FlightSystem.DAL.Repository;
using FlightSystem.WebAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FlightSystem.WebAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();
//builder.Services.AddControllers().AddNewtonsoftJson(options =>
//{
//    // Solution to the problem: Self referencing loop detected
//    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
//});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Database Access Service
builder.Services.AddDbContext<ApplicationDbContext>(Option =>
{
    Option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// External API Access Service
builder.Services.AddHttpClient<ExternalApiService>();
builder.Services.AddScoped<APIResponse>();
// Let's create the service to use the repositories.
builder.Services.AddScoped<IJourneyRepository, JourneyRepository>();
builder.Services.AddScoped<IFlightRepository, FlightRepository>();
// Add automapper service
builder.Services.AddAutoMapper(typeof(MappingConfig));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
