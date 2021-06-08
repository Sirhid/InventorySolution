using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRIS.InventoryManager.Pages
{
    public class DashboardModel : PageModel
    {
        public void OnGet()
        {
            ViewData["PageName"] = "Dashboard";
        }
    }
}
