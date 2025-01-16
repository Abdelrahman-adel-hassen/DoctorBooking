using AppointmentBooking.API;
using AppointmentBooking.API.Controllers;
using DoctorAppointmentManagement.Shell.Controllers;
using DoctorAppointmentManagement.Shell;
using DoctorAvailability.API;
using DoctorAvailability.API.Controllers;
using Notification.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



builder.Services.AddControllers().AddApplicationPart(typeof(DoctorController).Assembly);
builder.Services.AddControllers().AddApplicationPart(typeof(PatientController).Assembly);
builder.Services.AddControllers().AddApplicationPart(typeof(AppointmentController).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddNotificationsModule();
builder.Services.AddAppointmentBookingModule(builder.Configuration);
builder.Services.AddDoctorAvailabilityModule(builder.Configuration);
builder.Services.AddAppointmentBookingManagementModule(builder.Configuration);


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
