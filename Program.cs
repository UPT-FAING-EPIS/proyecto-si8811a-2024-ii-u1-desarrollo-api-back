using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Models;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Services;
using proyecto_si8811a_2024_ii_u1_desarrollo_api_back.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Configuración de MongoDBSettings desde appsettings.json o variables de entorno
builder.Services.Configure<MongoDBSettings>(
    builder.Configuration.GetSection("MongoDB"));

// Registrar MConnection como singleton para gestionar la conexión a MongoDB
builder.Services.AddSingleton<MConnection>();

// Configurar CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Registrar los servicios que dependen de MConnection
builder.Services.AddSingleton<EquipoService>();
builder.Services.AddSingleton<ParticipanteService>();

// Agregar servicios al contenedor.
builder.Services.AddControllers();

// Configurar Swagger para la documentación de la API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline HTTP.
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

// Habilitar CORS para todas las solicitudes
app.UseCors("AllowAllOrigins");

// Establecer el puerto en el que se ejecutará la aplicación
app.Urls.Add("http://0.0.0.0:8080");

app.Run();