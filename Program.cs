using ApiNet8.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ApiNet8.Services;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AutoMapper;
using ApiNet8.Utils.Mappers;
using ApiNet8.Models;
using sib_api_v3_sdk.Client;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configura Serilog para logging en un archivo
Log.Logger = new LoggerConfiguration()
    .WriteTo.File("Logs/app-.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();

// Usar Serilog como el logger de la aplicación
builder.Host.UseSerilog();

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("flowCraft"));
});

// Configurar envío de mail
Configuration.Default.ApiKey.Add("api-key", builder.Configuration["BrevoApi:ApiKey"]);

// Obtener la secret key de jwt desde la configuración
var secretKey = builder.Configuration["ApiSettings:secretToken"];

// Agregar servicios e interfaces
builder.Services.AddTransient<IConfiguracionServices, ConfiguracionServices>();
builder.Services.AddTransient<IUsuarioEstadoServices, UsuarioEstadoServices>();
builder.Services.AddTransient<IEquipoEstadoService, EquipoEstadoService>();
builder.Services.AddTransient<IEventoEstadoService, EventoEstadoService>();
builder.Services.AddTransient<IUsuarioServices, UsuarioServices>();
builder.Services.AddTransient<IInstalacionServices, InstalacionServices>();
builder.Services.AddTransient<IInstalacionEstadoServices, InstalacionEstadoServices>();
builder.Services.AddTransient<INoticiasServices, NoticiasServices>();
builder.Services.AddTransient<IDisciplinasYLeccionesServices, DisciplinasYLeccionesServices>();
builder.Services.AddTransient<ILeccionEstadoServices, LeccionEstadoServices>();
builder.Services.AddTransient<ITorneoEstadoServices, TorneoEstadoServices>();
builder.Services.AddTransient<IBackupServices, BackupServices>();
builder.Services.AddTransient<ITipoEventoServices, TipoEventoServices>();
builder.Services.AddTransient<ITipoAccionPartidoServices, TipoAccionPartidoServices>();
builder.Services.AddTransient<IRefreshTokenService, RefreshTokenService>();
builder.Services.AddTransient<ICategoriaServices, CategoriaServices>();
builder.Services.AddTransient<ILeccionesServices, LeccionesServices>();
builder.Services.AddTransient<IEventoServices, EventoServices>();
builder.Services.AddTransient<IReservasServices, ReservasServices>();
builder.Services.AddTransient<IEquipoServices, EquipoServices>();
builder.Services.AddTransient<IPartidoServices, PartidoServices>();
builder.Services.AddTransient<IReporteServices, ReporteServices>();
builder.Services.AddTransient<ITorneoServices, TorneoServices>();
builder.Services.AddTransient<ValidateJwtAndRefreshFilter>();

// Cargar configuración de SMTP desde el archivo de configuración
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("BrevoApi"));
builder.Services.AddTransient<IEmailService, EmailService>();

// Agregar soporte de sesión
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.HttpOnly = true; // Asegurar que las cookies solo se accedan vía backend
    options.Cookie.SameSite = SameSiteMode.None; // Permitir compartir cookies entre dominios
    options.Cookie.SecurePolicy = CookieSecurePolicy.Always; // Asegurar el uso de HTTPS
});

builder.Services.AddHttpContextAccessor();

// Agregar JWT para autenticación
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey)),
            ValidateIssuer = false,
            ValidateAudience = false,
            ClockSkew = TimeSpan.Zero
        };
    });

// Agregar AutoMapper
builder.Services.AddAutoMapper(typeof(APIMappers));

builder.Services.AddControllers();

// Configurar Swagger para la documentación de API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Soporte para CORS
builder.Services.AddCors(p => p.AddPolicy("PoliticaCors", build =>
{
    build.WithOrigins("http://localhost:3001", "http://192.168.1.20:3000")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()
        .WithExposedHeaders("JWT");
}));

var app = builder.Build();

// Configurar el pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Soporte para CORS
app.UseCors("PoliticaCors");

app.UseSession();

// Agregar middleware para manejar excepciones no controladas
app.Use(async (context, next) =>
{
    try
    {
        await next.Invoke();
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Ocurrió una excepción no controlada.");
        throw; // Re-lanzar la excepción para que sea manejada por el sistema
    }
});

app.UseAuthorization();

app.MapControllers();

app.Run();
