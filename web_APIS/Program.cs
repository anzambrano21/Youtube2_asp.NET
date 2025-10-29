using Microsoft.EntityFrameworkCore;
using web_APIS.Contex;

var builder = WebApplication.CreateBuilder(args);

// 📦 Conexión a la base de datos
var ConnectionString = builder.Configuration.GetConnectionString("Connections");
builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer(ConnectionString));

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddHttpClient();

// ✅ Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMVC", policy =>
    {
        policy
            .WithOrigins("http://localhost:5234") // Tu proyecto MVC
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials(); // 👉 si en algún momento usas cookies o autenticación
    });
});

// ✅ Configuración de controladores y JSON
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.DefaultIgnoreCondition =
            System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault;
    });

builder.Services.AddOpenApi();

var app = builder.Build();

// ✅ Middleware
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// ⚠️ IMPORTANTE: UseCors debe ir ANTES de UseAuthorization
app.UseCors("AllowMVC");

app.UseAuthorization();

app.MapControllers();

app.Run();
