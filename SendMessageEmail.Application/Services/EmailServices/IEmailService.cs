using SendEmailMessage.Domin.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailMessage.Application.Services.EmailService
{
    public interface IEmailService
    {
        public Task SendEmailAsync(EmailModel model);
    }
}
