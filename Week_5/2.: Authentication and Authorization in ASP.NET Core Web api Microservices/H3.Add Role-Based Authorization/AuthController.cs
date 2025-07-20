using JWT_Application.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_Application.Controllers
{
  
    

[ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (IsValidUser(model))
            {
                var token = GenerateJwtToken(model.Username);
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }

        private bool IsValidUser(LoginModel model)
        {
            // For demo purposes; replace with DB validation
            return model.Username == "Mohamed gows" && model.Password == "Gows123";
        }

        private string GenerateJwtToken(string username)
        {
            var claims = new[]
            {
               new Claim(ClaimTypes.Name, username),
        new Claim(ClaimTypes.Role, "Admin")

        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
    new ConfigurationBuilder().AddJsonFile("appsettings.json").Build()["Jwt:Key"]
));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "MyAuthServer",
                audience: "MyApiUsers",
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        
    }
}
v
