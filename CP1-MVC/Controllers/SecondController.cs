using Microsoft.AspNetCore.Mvc;

namespace CP1_MVC.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Second()
        {
            return View();
        }
    }
}
