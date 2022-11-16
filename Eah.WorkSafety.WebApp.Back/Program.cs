using AutoMapper;
using Eah.WorkSafety.WebApp.Back.Core.Application.Interfaces;
using Eah.WorkSafety.WebApp.Back.Core.Application.Mappings;
using Eah.WorkSafety.WebApp.Back.Infrastructure.Tools;
using Eah.WorkSafety.WebApp.Back.Persistance.Context;
using Eah.WorkSafety.WebApp.Back.Persistance.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<WorkSafetyDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Local"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfiles(new List<Profile>()
    {
        new MissionProfile(),
        new AccidentProfile(),
        new ChronicDiseaseProfile(),
        new ContingencyPlanProfile(),
        new EmployeeProfile(),
        new InconsistencyProfile(),
        new MissionProfile(),
        new NearMissProfile(),
        new OccupationDiseaseProfile(),
        new RiskAssesmentProfile()
    });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidAudience = JwtTokenSettings.Audience,
        ValidIssuer = JwtTokenSettings.Issuer,
        ClockSkew = TimeSpan.Zero,
        ValidateLifetime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenSettings.Key)),
        ValidateIssuerSigningKey = true
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("GlobalCors");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
