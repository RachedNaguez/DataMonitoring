using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using DataMonitoring.Contants;

namespace DataMonitoring.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Permissions.Dashboard.View)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
