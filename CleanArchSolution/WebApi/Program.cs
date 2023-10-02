using Application;
using Core;
using Infrastructure;
using WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();
builder.Services.AddScoped<ISortService, SortService>();
builder.Services.AddScoped<IEmailService, EmailService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwaggerLayout();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
