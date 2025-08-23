using Microsoft.EntityFrameworkCore;
using web_APIS.Contex;


var builder = WebApplication.CreateBuilder(args);


var ConnectionString = builder.Configuration.GetConnectionString("Connections");
builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer(ConnectionString));

builder.Services.AddAutoMapper(typeof(Program));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
