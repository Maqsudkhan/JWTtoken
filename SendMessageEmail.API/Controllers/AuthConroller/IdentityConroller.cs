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
        private readonly AuthService _authService;

        public IdentityConroller(AuthService authService)
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
