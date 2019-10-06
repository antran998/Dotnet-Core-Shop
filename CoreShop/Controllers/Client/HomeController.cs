using Microsoft.AspNetCore.Mvc;

namespace CoreShop.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            return View("Views/Client/Home/Index.cshtml");
        }       
        
    }
}
