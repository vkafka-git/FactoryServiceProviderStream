using Stream.Api.Factory;
using Stream.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<StreamFactory>();

builder.Services
  .RegisterScopedService<NetflixStreamService>("Netflix")
  .RegisterScopedService<AmazonStreamService>("Amazon");

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
