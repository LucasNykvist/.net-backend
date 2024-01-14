using Microsoft.EntityFrameworkCore;
using Repositories;

var builder = WebApplication.CreateBuilder(args);

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyContext>(options => options.UseNpgsql("host=localhost; port=5432; dbname=postgres; user=postgres; password=MonaLisa200sx! sslmode=prefer; connect_timeout=10"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.Run();

