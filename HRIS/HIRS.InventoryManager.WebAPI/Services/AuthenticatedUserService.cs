using HRIS.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace HRIS.InventoryManager.WebAPI.Services
{
    public class AuthenticatedUserService : IAuthenticatedUserService
    {
        public AuthenticatedUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue("uid");
        }

        public string UserId { get; }
    }
}
