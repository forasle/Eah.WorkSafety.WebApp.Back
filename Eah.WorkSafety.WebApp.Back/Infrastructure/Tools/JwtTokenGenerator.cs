using Eah.WorkSafety.WebApp.Back.Core.Application.Dto;
using Eah.WorkSafety.WebApp.Back.Core.Domain;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Eah.WorkSafety.WebApp.Back.Infrastructure.Tools
{
    public class JwtTokenGenerator
    {
        public static JwtTokenResponse GenerateToken(CheckUserResponseDto dto)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Role, dto.UserRole));
            claims.Add(new Claim(ClaimTypes.Name, dto.Username));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));
            JwtSecurityToken token = new JwtSecurityToken(issuer: JwtTokenSettings.Issuer,audience: JwtTokenSettings.Audience, claims: null, notBefore: DateTime.Now, expires:DateTime.Now.AddDays(JwtTokenSettings.Expire));
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return new JwtTokenResponse(handler.WriteToken(token));
        }
    }
}
