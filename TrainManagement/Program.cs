using BusinessLayer;
using BusinessLayer.BaseBL;
using BusinessLayer.Passenger_DetailBL;
using BusinessLayer.Schedule_DetailBL;
using BusinessLayer.SeatBL;
using BusinessLayer.State_ManagementBL;
using BusinessLayer.StationBL;
using BusinessLayer.TicketBL;
using BusinessLayer.TrainBL;
using BusinessLayer.TrainCarBL;
using BusinessLayer.TrainTripBL;
using BusinessLayer.TypeManagementBL;
using DataAccessLayer;
using DataAccessLayer.BaseDL;
using DataAccessLayer.Passenger_DetailDL;
using DataAccessLayer.Schedule_DetailDL;
using DataAccessLayer.ScheduleDL;
using DataAccessLayer.SeatDL;
using DataAccessLayer.State_ManagementDL;
using DataAccessLayer.StationDL;
using DataAccessLayer.TicketDL;
using DataAccessLayer.TrainCarDL;
using DataAccessLayer.TrainDL;
using DataAccessLayer.TrainTripDL;
using DataAccessLayer.TypeManagementDL;

var builder = WebApplication.CreateBuilder(args);
string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddScoped(typeof(IBaseDL<>), typeof(BaseDL<>));
builder.Services.AddScoped(typeof(IBaseBL<>), typeof(BaseBL<>));

builder.Services.AddScoped<IPassenger_DetailBL, Passenger_DetailBL>();
builder.Services.AddScoped<IPassenger_DetailDL, Passenger_DetailDL>();

builder.Services.AddScoped<ISchedule_DetailBL, Schedule_DetailBL>();
builder.Services.AddScoped<ISchedule_DetailDL, Schedule_DetailDL>();

builder.Services.AddScoped<IScheduleBL, ScheduleBL>();
builder.Services.AddScoped<IScheduleDL, ScheduleDL>();

builder.Services.AddScoped<ISeatBL, SeatBL>();
builder.Services.AddScoped<ISeatDL, SeatDL>();

builder.Services.AddScoped<IState_ManagementBL, State_ManagementBL>();
builder.Services.AddScoped<IState_ManagementDL, State_ManagementDL>();

builder.Services.AddScoped<IStationBL, StationBL>();
builder.Services.AddScoped<IStationDL, StationDL>();

builder.Services.AddScoped<ITicketBL, TicketBL>();
builder.Services.AddScoped<ITicketDL, TicketDL>();

builder.Services.AddScoped<ITrainBL, TrainBL>();
builder.Services.AddScoped<ITrainDL, TrainDL>();

builder.Services.AddScoped<ITrainCarBL, TrainCarBL>();
builder.Services.AddScoped<ITrainCarDL, TrainCarDL>();

builder.Services.AddScoped<ITrainTripBL, TrainTripBL>();
builder.Services.AddScoped<ITrainTripDL, TrainTripDL>();

builder.Services.AddScoped<ITypeManagementBL, TypeManagementBL>();
builder.Services.AddScoped<ITypeManagementDL, TypeManagementDL>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

DatabaseContext.ConnectionString = builder.Configuration.GetConnectionString("MySqlConnection");

builder.Services.AddCors(option =>
{
    option.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    {
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.Run();
