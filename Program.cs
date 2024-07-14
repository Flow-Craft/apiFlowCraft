using ApiNet8.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ApiNet8.Services;
using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("flowCraft"));
});

// Obtener la secret key desde la configuración
var secretKey = builder.Configuration["ApiSettings:secretToken"];

// agregar servicio e interfaz
builder.Services.AddTransient<IConfiguracionServices, ConfiguracionServices>();
builder.Services.AddTransient<IUsuarioEstadoServices, UsuarioEstadoServices>();
builder.Services.AddTransient<IUsuarioServices, UsuarioServices>();
builder.Services.AddTransient<IRefreshTokenService, RefreshTokenService>();
builder.Services.AddTransient<ValidateJwtAndRefreshFilter>();


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
