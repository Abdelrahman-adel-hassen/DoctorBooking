using AppointmentBooking.API.Controllers;
using AppointmentBooking.Application.Services;
using AppointmentBooking.Domain.IRepositories;
using AppointmentBooking.Infrastructure.Repositories;
using DoctorAvailability.API.Controllers;
using DoctorAvailability.BLL.Services;
using DoctorAvailability.DAL.Repositories;
using DoctorBooking.Shared;
using Microsoft.EntityFrameworkCore;
using Notification.API;
using Notification.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
throw new InvalidOperationException("Connection String 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));


builder.Services.AddControllers().AddApplicationPart(typeof(DoctorController).Assembly);
builder.Services.AddControllers().AddApplicationPart(typeof(PatientController).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DoctorService>();
builder.Services.AddScoped<SlotViewService>();
builder.Services.AddScoped<AppointmentBookService>();
builder.Services.AddScoped<IDoctorRepo,DoctorRepo>();
builder.Services.AddScoped<IPatientRepo, PatientRepo>();
builder.Services.AddScoped<INotificationsModuleApi, NotificationsModuleApi>();

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
