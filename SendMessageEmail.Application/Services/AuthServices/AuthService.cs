using Microsoft.Extensions.Configuration;
using SendMessageEmail.Domain.Entities.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SendMessageEmail.Application.Services.AuthServices
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GenerateToken(User user)
        {
            if (user == null)
            {
                return "Use will be Null";
            }
            else if (user.Id == Guid.NewGuid())
            {
                return "User not found";
            }

            if (UserExit(user))
            {
                
                var service = _configuration.GetSection("JWT"); //Appsettingisdan qiymatni ovolishni 1-usuli
                var sekretKey = service["Secret"];

                var key = _configuration["JWT : Secret"]; // 2-usul
            }
            else
            {
                return "User unAuthorithe";
            }

            throw new NotImplementedException();
        }

        private bool UserExit(User user)
        {
            var login = "Admin";
            var password = "12345";
            if (user.Login == login && user.Password == password)
            {
                return true;
            }
            return false;
        }
    }
}
