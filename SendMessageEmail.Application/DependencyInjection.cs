using Microsoft.Extensions.DependencyInjection;
using SendEmailMessage.Application.Services.EmailService;
using SendMessageEmail.Application.Services.AuthServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendEmailMessage.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}
