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

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("flowCraft"));
});

// configurar envio de mail
Configuration.Default.ApiKey.Add("api-key", builder.Configuration["BrevoApi:ApiKey"]);

// Obtener la secret key de jwt desde la configuraci�n
var secretKey = builder.Configuration["ApiSettings:secretToken"];

// agregar servicio e interfaz
builder.Services.AddTransient<IConfiguracionServices, ConfiguracionServices>();
builder.Services.AddTransient<IUsuarioEstadoServices, UsuarioEstadoServices>();
builder.Services.AddTransient<IEquipoEstadoService, EquipoEstadoService>();
builder.Services.AddTransient<IEventoEstadoService, EventoEstadoService>();
builder.Services.AddTransient<IUsuarioServices, UsuarioServices>();
builder.Services.AddTransient<IInstalacionServices, InstalacionServices>();
builder.Services.AddTransient<IInstalacionEstadoServices, InstalacionEstadoServices>();
builder.Services.AddTransient<INoticiasServices, NoticiasServices>();
builder.Services.AddTransient<IDisciplinasYLeccionesServices, DisciplinasYLeccionesServices>();
builder.Services.AddTransient<ILeccionEstadoServices, DisciplinasYLeccionesServices>();
builder.Services.AddTransient<ITorneoEstadoServices, TorneoEstadoServices>();
builder.Services.AddTransient<IBackupServices, BackupServices>();

builder.Services.AddTransient<IRefreshTokenService, RefreshTokenService>();
builder.Services.AddTransient<ValidateJwtAndRefreshFilter>();

// Load SMTP settings from configuration
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("BrevoApi"));
builder.Services.AddTransient<IEmailService, EmailService>();

// se agrega session
builder.Services.AddDistributedMemoryCache();

//builder.Services.AddSession(options =>
//{
//    options.IdleTimeout = TimeSpan.FromMinutes(10);
//});

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
    options.Cookie.HttpOnly = true; // Esto asegura que las cookies solo se puedan acceder a través del backend
    options.Cookie.SameSite = SameSiteMode.None; // Esto permite compartir las cookies entre dominios    
    options.Cookie.SecurePolicy = CookieSecurePolicy.None; // Asegúrate de usar HTTPS
});


builder.Services.AddHttpContextAccessor();

// agregamos jwt
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

//Agregamos el AutoMapper
builder.Services.AddAutoMapper(typeof(APIMappers));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Soporte para CORS
//Se pueden habilitar: 1-Un dominio, 2-multiples dominios,
//3-cualquier dominio (Tener en cuenta seguridad)
//Usamos de ejemplo el dominio: http://localhost:3223, se debe cambiar por el correcto
//Se usa (*) para todos los dominios
builder.Services.AddCors(p => p.AddPolicy("PoliticaCors", build =>
{
    build.WithOrigins("http://localhost:3001", "http://192.168.1.20:3000").AllowAnyMethod().AllowAnyHeader().AllowCredentials().WithExposedHeaders("JWT");
}));

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Soporte para CORS
app.UseCors("PoliticaCors");

app.UseSession();

app.UseAuthorization();

app.MapControllers();

app.Run();
