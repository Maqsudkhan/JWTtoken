using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SendMessageEmail.Domain.Enum;
using System.Security.Claims;
using System.Text.Json;

namespace SendMessageEmail.API.Attributes
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Class)]
    public class IdentityFilterAttribute : Attribute, IAuthorizationFilter
    {
        private readonly int _permissionId;
        public IdentityFilterAttribute(Permission permission)
        {
            _permissionId = (int)permission;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var identity = context.HttpContext.User.Identity as ClaimsIdentity;
            var permissionIds = identity.FindFirst("Permissions")?.Value;
            var result = JsonSerializer.Deserialize<List<int>>(permissionIds).Any(x => _permissionId == x);

            if (!result)
            {
                context.Result = new ForbidResult();
                return;
            }
        }
    }
}
