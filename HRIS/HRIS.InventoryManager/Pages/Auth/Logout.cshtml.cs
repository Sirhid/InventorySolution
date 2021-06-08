using HRIS.InventoryManager.Constants;
using HRIS.InventoryManager.DTOs.Base;
using HRIS.InventoryManager.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace HRIS.InventoryManager.Pages.Auth
{
    public class LogoutModel : PageModel
    {
        private readonly IHttpClientService _httpClientService;

        public LogoutModel(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            var response = await _httpClientService.GetAsync<BaseDTO<string>>($"{ApplicationContants.BaseUrl}{ApplicationContants.LogOut}");

            if (response.succeeded)
            {
                var authenticationManager = Request.HttpContext;
                await authenticationManager.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                foreach (var cookie in Request.Cookies.Keys)
                {
                    Response.Cookies.Delete(cookie);
                }

                return RedirectToPage("/Account/Login");
            }
            return RedirectToPage("/Account/Login");
        }
    }
}
