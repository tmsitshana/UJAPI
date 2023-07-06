using Microsoft.AspNetCore.Mvc;

namespace MVCWebAppTestAPI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
