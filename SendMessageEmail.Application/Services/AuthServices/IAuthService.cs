using SendMessageEmail.Domain.Entities.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessageEmail.Application.Services.AuthServices
{
    public interface IAuthService
    {
        public Task<string> GenerateToken(User user);
    }
}
