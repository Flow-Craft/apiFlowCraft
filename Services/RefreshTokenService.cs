using ApiNet8.Services.IServices;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiNet8.Services
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private readonly string secretToken;

        public RefreshTokenService(IConfiguration configuration)
        {
            this.secretToken = configuration.GetValue<string>("ApiSettings:secretToken") ?? "";
        }

        public async Task<string> RefreshTokenAsync(string expiredToken)
        {
            // Lógica para refrescar el token aquí, similar a tu método RefreshToken
            // Este es solo un ejemplo básico:
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretToken);

            // Validar el token expirado y obtener claims
            var principal = tokenHandler.ValidateToken(expiredToken, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero,
                ValidateLifetime = false // No validar la expiración aquí
            }, out SecurityToken validatedToken);

            // Obtener las fechas de expiración y validación
            var expClaim = principal.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Exp)?.Value;
            var validationExpiryClaim = principal.Claims.FirstOrDefault(c => c.Type == "validation_expiry")?.Value;

            if (expClaim == null || validationExpiryClaim == null)
            {
                throw new SecurityTokenException("Invalid token");
            }

            var tokenExpiry = DateTimeOffset.FromUnixTimeSeconds(long.Parse(expClaim)).UtcDateTime;
           
            var validationExpiry = DateTime.Parse(validationExpiryClaim, null, System.Globalization.DateTimeStyles.RoundtripKind).ToUniversalTime();


            if (DateTime.UtcNow <= validationExpiry)
            {
                // Generar un nuevo token
                var newTokenExpiry = DateTime.UtcNow.AddHours(1);
                var newValidationExpiry = DateTime.UtcNow.AddHours(2);

                var newTokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(principal.Claims),
                    Expires = newTokenExpiry,
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var newJwt = tokenHandler.CreateToken(newTokenDescriptor);
                return tokenHandler.WriteToken(newJwt);
            }

            throw new SecurityTokenException("Validation period expired");
        }
    }
}