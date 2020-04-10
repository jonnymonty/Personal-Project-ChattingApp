using System;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace Fasetto.Word.Web.Server
{
    /// <summary>
    /// Extension methods for working with Jwt Bearer tokens
    /// </summary>
    public static class JwtTokenExtensionMethods
    {
        /// <summary>
        /// Generates a Jwt Bearer Token containing the users username
        /// </summary>
        /// <param name="user">The users details</param>
        /// <returns></returns>
        public static string GenerateJwtToken(this ApplicationUser user)
        {
            // Set our tokens claims
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                //new Claim(JwtRegisteredClaimNames.NameId, "unknownuser"),
                //new Claim(JwtRegisteredClaimNames.Email, email),
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName),

                new Claim("my key", "my value"),
            };

            // Create the credentials used to generate the token
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(IocContainer.Configuration["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Generate the Jwt Token
            var token = new JwtSecurityToken(
                issuer: IocContainer.Configuration["Jwt:Issuer"],
                audience: IocContainer.Configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMonths(3),
                signingCredentials: credentials
                );

            // return the generated token
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
