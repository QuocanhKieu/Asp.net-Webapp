using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShopDetail()
        {
            return View();
        }

        public IActionResult ShopingCart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
