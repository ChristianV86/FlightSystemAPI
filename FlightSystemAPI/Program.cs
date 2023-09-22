using FlightSystem.BLL;
using FlightSystem.DAL.Data;
using FlightSystem.WebAPI.Controllers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Database Access Service
builder.Services.AddDbContext<ApplicationDbContext>(Option =>
{
    Option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// External API Access Service
builder.Services.AddHttpClient<FlightController>();

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
