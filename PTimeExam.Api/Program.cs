using AutoMapper;
using FinalExam.Dal;
using FinalExam.Dal.Interfaces;
using FinalExam.Dal.Repository;
using FinalExam.Service.Automapper;
using FinalExam.Service.Interfaces;
using FinalExam.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionstring = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer(connectionstring); });

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new CompanyMappingProfile());
    mc.AddProfile(new MoviesMappingProfile());
});

IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddScoped<IClientsRepository, ClientsRepository>();
builder.Services.AddScoped<ICompanyService, ClientsService>();



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
