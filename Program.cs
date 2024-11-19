using Microsoft.EntityFrameworkCore;
using WebAPI.DAL;
using WebAPI.Domain.Interfaces;
using WebAPI.Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//esta linea se usa para configurar la conexi�n a la BD
builder.Services.AddDbContext<DataBasecontext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//contenedor de dependencias
builder.Services.AddScoped<ICountryService, CountryService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
