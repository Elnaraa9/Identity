using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProfiFrontToBack.Helpers;

namespace profi.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = nameof(Role.RoleType.Admin))]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
