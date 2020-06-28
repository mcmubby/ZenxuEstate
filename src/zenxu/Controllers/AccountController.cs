using Microsoft.AspNetCore.Mvc;

namespace zenxu.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult register()
        {
            return View();
        }
    }
}