 /*
 * Author: Luis López
 * Website: https://github.com/luislopez-dev
 * Description: Training Project
 */
 
using API.Data;
using API.Validations;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Adding fluent validations to container

builder.Services.AddControllers();

builder.Services.AddValidatorsFromAssemblyContaining<OrderValidator>();

builder.Services.AddSingleton<FakeDataStore>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    /*
    app.UseSwagger();
    app.UseSwaggerUI();
    */
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();