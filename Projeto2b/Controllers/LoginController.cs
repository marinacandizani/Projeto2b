using Microsoft.AspNetCore.Mvc;

namespace Projeto2b.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login ()
        {
            return View();
        }
    }
}
