using FootballManagement.WebApi.Repository.Abstracts.IImages;
using FootballManagement.WebApi.Repository.Abstracts;
using FootballManagement.WebApi.Repository.Concretes.Images;
using FootballManagement.WebApi.Repository.Concretes;
using FootballManagement.WebApi.Repository.Contexts;
using FootballManagement.WebApi.Service.Helpers.CloudinaryHelper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Repository Baðýmlýlýklarý
builder.Services.AddScoped<ICoachRepository, CoachRepository>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<IPlayerImageRepository, PlayerImageRepository>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IClubRepository, ClubRepository>();
builder.Services.AddDbContext<BaseDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"));
});
    
    builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));

















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
