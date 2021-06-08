using HRIS.InventoryManager.Constants;
using HRIS.InventoryManager.DTOs.Authentication;
using HRIS.InventoryManager.DTOs.Base;
using HRIS.InventoryManager.Extensions;
using HRIS.InventoryManager.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HRIS.InventoryManager.Pages.Auth
{
    [ValidateAntiForgeryToken]
    public class LoginModel : PageModel
    {
        private readonly IHttpClientService _httpClientService;

        public LoginModel(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        [BindProperty]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [BindProperty]
        public bool RememberMe { get; set; }
        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostAsync()
        {
            var loginRequest = new LoginRequestDTO { email = this.Email, password = this.Password };

            var response = await _httpClientService.PostAsync<LoginRequestDTO, BaseDTO<LoginResponse>>($"{ApplicationContants.BaseUrl}{ApplicationContants.Authenticate}", loginRequest);

            if (!response.succeeded)
            {
                ModelState.AddModelError("", "Invalid login attempt");
                return Page();
            }
            //var claims = new List<Claim>();

            //claims.Add(new Claim(ClaimTypes.Name, response.data.userName));
            //var claimIdenties = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            //var claimPrincipal = new ClaimsPrincipal(claimIdenties);
            //var authenticationManager = Request.HttpContext;

            //// Sign In.  
            //await authenticationManager.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, new AuthenticationProperties() { });

            HttpContext.Session.SetComplexData("loggedInUserDetails", response.data);
            //return new RedirectToPageResult("/Portal/Login");
            return RedirectToPage("/Dashboard");
        }
    }
}
