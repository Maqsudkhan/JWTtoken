using Microsoft.Extensions.Configuration;
using SendEmailMessage.Domin.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailMessage.Application.Services.EmailService
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(EmailModel model)
        {
            string path = @"D:\BFN\Htmls\Sender.html";
            using (var stream = new StreamReader(path))
            {
                model.Body = await stream.ReadToEndAsync();
            }
            var emailSettings = _config.GetSection("EmailSettings");
            var mailMessage = new MailMessage
            {
                From = new MailAddress(emailSettings["Sender"], emailSettings["SenderName"]),
                Subject = model.Subject,
                Body = model.Body,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(model.To);

            using var smptClient = new SmtpClient(emailSettings["MailServer"], int.Parse(emailSettings["MailPort"]))
            {
                Port = Convert.ToInt32(emailSettings["MailPort"]),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(emailSettings["Sender"], emailSettings["Password"]),
                EnableSsl = true,
            };

            await smptClient.SendMailAsync(mailMessage);
        }
    }
}



