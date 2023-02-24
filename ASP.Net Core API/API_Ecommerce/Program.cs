using ECommerceDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add Connection String with Depndancy Injection (Singleton)
builder.Services.AddDbContext<ECommerce_DbContext>(options => 
                 options.UseSqlServer(builder.Configuration.GetConnectionString("APIConnectionString")));

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.


app.Run();

