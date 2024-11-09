using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiPerson.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// crear variable para la cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("Connection");
// Registrar servicio para la conexión
builder.Services.AddDbContext<AppDbContext>(Options => Options.UseSqlServer(connectionString));


builder.Services.AddControllers();
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
