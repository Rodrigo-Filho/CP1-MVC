using Microsoft.AspNetCore.Mvc;

namespace CP1_MVC.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult First()
        {
            return View();
        }
    }
}
