using Microsoft.AspNetCore.Mvc;

namespace TechShop.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
