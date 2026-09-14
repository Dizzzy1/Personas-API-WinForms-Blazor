using Microsoft.Data.SqlClient;
using Personas.Api.Services;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar Controllers
builder.Services.AddControllers();
builder.Services.AddScoped<McdService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Usar Controllers
app.MapControllers();

app.Run();