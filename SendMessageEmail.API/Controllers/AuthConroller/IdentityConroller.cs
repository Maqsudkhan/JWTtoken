using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendMessageEmail.Application.Services.AuthServices;
using SendMessageEmail.Domain.Entities.Models.AuthModels;

namespace SendMessageEmail.API.Controllers.AuthConroller
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityConroller : ControllerBase
    {
        private readonly IAuthService _authService;

        public IdentityConroller(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var result = _authService.GenerateToken(user);
            return Ok(result);
        }

    }
}
