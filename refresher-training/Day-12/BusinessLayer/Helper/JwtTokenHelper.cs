using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using ModelLayer.Entities;

namespace BusinessLayer.Helper
{
    public class JwtTokenHelper
    {
        private readonly string _secretKey;

        // secret key comes from appsettings
        public JwtTokenHelper(string secretKey)
        {
            _secretKey = secretKey;
        }

        public string GenerateToken(User user)
        {
            // claims store basic user info inside token
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}