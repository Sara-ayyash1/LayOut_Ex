using Microsoft.AspNetCore.Mvc;

namespace Quiz.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
