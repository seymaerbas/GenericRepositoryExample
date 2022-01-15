
using GenericRepositoryExampla.Api.TokenModels;
using GenericRepositoryExampla.Entities.Model;
using GenericRepositoryExample.DataAccsess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepositoryExampla.Api.Helpers
{
    public class GenericHelperMethods
    {
      public GenericHelperMethods()
        {

        }
        public async Task<Token> CreateRefreshToken(User user, GenericDbContext _context, IConfiguration _configuration)
        {
            //user için token üretiliyor
            TokenHandler tokenHandler = new TokenHandler(_configuration);
            Token token = tokenHandler.CreateAccessToken(user);
            //refresh token kullanıcı tablosuna işleniyor.
            user.RefreshToken = token.RefreshToken;
            user.RefreshTokenEndDate = token.Expration.AddMinutes(5);
            await _context.SaveChangesAsync();
            return token;
        }
    }
}
