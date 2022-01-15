using GenericRepositoryExampla.Entities.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Api.TokenModels
{
    public class TokenHandler
    {
        public IConfiguration Configuration { get; set; }
        public TokenHandler(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        //Token üretecek method

        public Token CreateAccessToken(User user)
        {
            Token token = new Token();
            SymmetricSecurityKey securtyKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:Securitykey"]));
            SigningCredentials signingCredentials = new SigningCredentials(securtyKey, SecurityAlgorithms.HmacSha256);//şifreli kimlik oluşturuluyor

            token.Expration = DateTime.Now.AddMinutes(5); //Token süresine 5dk ekler

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                issuer: Configuration["Token:Issuer"],
                audience:Configuration["Token:Audience"],
                expires:token.Expration,
                notBefore: DateTime.Now, //Token üretildikten sonra süre ne zaman devreye girsin
                signingCredentials:signingCredentials
                );
            //yeni bir acces token üretir
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            token.AccessToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);

            token.RefreshToken = CreateRefreshToken();
            return token;
        }


        public string CreateRefreshToken()
        {
            byte[] tokenArray = new byte[32];
            using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
            {
                randomNumberGenerator.GetBytes(tokenArray);
                return Convert.ToBase64String(tokenArray);
            }
        }
    }
}
