using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SeedAPI.ViewModels;

namespace SeedAPI.Web.API.Api
{
    [Route("api/token")]
    public class TokenController : Controller
    {
        private IConfiguration config;

        public TokenController(IConfiguration config)
        {
            this.config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public dynamic Post([FromBody] LoginViewModel login)
        {
            IActionResult response = Unauthorized();
            var user = Authenticate(login);
            if (user != null)
            {
                var tokenString = BuildToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        private string BuildToken(UserViewModel user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(config["Jwt:Issuer"],
                config["Jwt:Issuer"],
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserViewModel Authenticate(LoginViewModel login)
        {
            UserViewModel user = null;
            if (login.UserName == "pablo" && login.Password == "secret")
            {
                user = new UserViewModel { UserName = "Pablo" };
            }

            return user;
        }
    }
}