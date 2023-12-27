using Microsoft.AspNetCore.Mvc;

namespace enterprise_expenses.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
