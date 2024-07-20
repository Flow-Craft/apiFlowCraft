using ApiNet8.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ValidateJwtAndRefreshFilter : IAsyncActionFilter
{
    private readonly IRefreshTokenService _refreshTokenService;
    private readonly string _secretToken;

    public ValidateJwtAndRefreshFilter(IRefreshTokenService refreshTokenService,IConfiguration configuration)
    {
        _refreshTokenService = refreshTokenService;
        this._secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_secretToken);

        if (context.HttpContext.Request.Headers.TryGetValue("Authorization", out var tokenHeaderValues))
        {
            var token = tokenHeaderValues.FirstOrDefault()?.Split(" ").Last();

            // se guarda jwt recibido
            context.HttpContext.Items["JWT"] = token;

            if (string.IsNullOrEmpty(token))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                await next();
            }
            catch (SecurityTokenExpiredException)
            {
                // Token expirado, verificar si está dentro de la ventana de validación
                if (ShouldRefreshToken(token))
                {
                    var newToken = await _refreshTokenService.RefreshTokenAsync(token);
                    context.HttpContext.Items["JWT"] = newToken;
                    //context.HttpContext.Response.Headers.Add("X-Refreshed-Token", newToken);// el jwt se guarda en el contexto, deberiamos guardarlo en una cookie
                    await next();
                }
                else
                {
                    context.Result = new UnauthorizedResult();
                }
            }
            catch (Exception)
            {
                context.Result = new UnauthorizedResult();
            }
        }
        else
        {
            context.Result = new UnauthorizedResult();
        }
    }

    private bool ShouldRefreshToken(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_secretToken);

        try
        {
            var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero,
                ValidateLifetime = false // No validar la expiración aquí
            }, out SecurityToken validatedToken);

            var validationExpiryClaim = principal.Claims.FirstOrDefault(c => c.Type == "validation_expiry")?.Value;

            if (validationExpiryClaim == null)
            {
                return false;
            }

            //var validationExpiry = DateTime.Parse(validationExpiryClaim);
            // Parsear la fecha en formato UTC
            var validationExpiry = DateTime.Parse(validationExpiryClaim, null, System.Globalization.DateTimeStyles.RoundtripKind).ToUniversalTime();

            //// Restar 3 horas a validationExpiry
            //var adjustedValidationExpiry = validationExpiry.AddHours(3);

            return DateTime.UtcNow <= validationExpiry;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
