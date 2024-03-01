using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendEmailMessage.Application.Services.EmailService;
using SendEmailMessage.Domin.Entites.Models;

namespace SendEmailMessage.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
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


        [HttpGet]
        public async Task<IActionResult> GetEmail()
        {
            return Ok("Muvaffaqiyatli yuborildi✅");
        }
    }
}
