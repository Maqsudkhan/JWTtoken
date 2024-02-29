using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendEmailMessage.Application.Services.EmailService;
using SendEmailMessage.Domin.Entites.Models;

namespace SendEmailMessage.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmailConroller : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailConroller(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] EmailModel model)
        {
            await _emailService.SendEmailAsync(model);
            return Ok("Created successfully ✅");
        }
    }
}
