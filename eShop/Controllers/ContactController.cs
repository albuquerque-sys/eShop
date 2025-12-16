using Microsoft.AspNetCore.Mvc;

namespace eShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
