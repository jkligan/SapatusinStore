using Microsoft.EntityFrameworkCore;
using SapatusinStore.Core.DTOs;
using SapatusinStore.Core.Services;
using SapatusinStore.Infrastructure;
using SapatusinStore.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<CustomerServices, CustomerServices>();
builder.Services.AddScoped<InventoryServices, InventoryServices>();
builder.Services.AddScoped<OrderDetailsServices, OrderDetailsServices>();
builder.Services.AddScoped<OrderServices, OrderServices>();
builder.Services.AddScoped<ProductServices, ProductServices>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

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
