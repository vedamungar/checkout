using System;
using System.Collections.Generic;
using System.Text;
using Business.Model;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Linq;
using System.Data;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IO;
namespace Business.Service
{
   public class AuthenticationService
    {
        public AuthModel Authenticate(string quadrigram, string password)
        {
            if (quadrigram.Equals("veda") && password.Equals("Paa"))
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                IConfigurationBuilder builder = new ConfigurationBuilder();
                builder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"));
                var root = builder.Build();
                var secret = root.GetSection("AppSettings").GetSection("Secret").Value;
                var key = Encoding.ASCII.GetBytes(secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, "veda"),
                        new Claim(ClaimTypes.Email, "vedamungar@gmail.com")
                    }),
                    //  Expires = DateTime.UtcNow.AddDays(7),
                    Expires = DateTime.Now.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return new AuthModel()
                {
                    User = new UserModel()
                    {
                        UserId = 1,
                        FirstName = "veda",
                        LastName = "Mungar",

                    },
                    Code = tokenHandler.WriteToken(token),
                    Status = true,
                    WaitingTime = 0

                };
            }
            else
            {
                return new AuthModel()
                {
                    User = new UserModel()
                    {
                        UserId = 0,
                        FirstName = "",
                        LastName = "",

                    },
                    Code = "",
                    Status = false,
                    WaitingTime = 0

                };
            }
        }
        
    }
}
