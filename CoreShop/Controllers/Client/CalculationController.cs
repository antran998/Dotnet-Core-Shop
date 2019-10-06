using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreShop.Controllers
{
    public class CalculationController : Controller
    {
        [Route("Cart")]
        public IActionResult Cart()
        {
            return View("Views/Client/Calculation/Cart.cshtml");
        }

        [Route("Checkout")]
        public IActionResult Checkout()
        {
            return View("Views/Client/Calculation/Checkout.cshtml");
        }
    }
}