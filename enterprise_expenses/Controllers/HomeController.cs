using enterprise_expenses.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace enterprise_expenses.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void LogInformation()
        {
            _logger.LogInformation("This is a dummy log information method.");
        }

        public void LogWarning()
        {
            _logger.LogWarning("This is a dummy log warning method.");
        }

        public void LogError()
        {
            _logger.LogError("This is a dummy log error method.");
        }

        public void LogCritical()
        {
            _logger.LogCritical("This is a dummy log critical method.");
        }

        public void LogTrace()
        {
            _logger.LogTrace("This is a dummy log trace method.");
        }

        public void LogDebug()
        {
            _logger.LogDebug("This is a dummy log debug method.");
        }
    }
}
