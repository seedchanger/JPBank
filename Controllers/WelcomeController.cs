using Microsoft.AspNetCore.Mvc;

namespace JPBank.Controllers
{
    public class WelcomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }
    }
}
