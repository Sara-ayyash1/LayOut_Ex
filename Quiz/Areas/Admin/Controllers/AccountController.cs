using Microsoft.AspNetCore.Mvc;

namespace Quiz.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Password()
        {
            return View();
        }

        public IActionResult Regester()
        {
            return View();
        }
    }
}
