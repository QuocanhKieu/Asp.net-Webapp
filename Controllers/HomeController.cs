using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine("Index action method called.");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        public IActionResult Contact()
        {
            Console.WriteLine("Contact action method called.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        public IActionResult Error()
        {
            var htmlContent = @"
                <!DOCTYPE html>
                <html>
                <head><title>Error</title></head>
                <body>
                    <h1>Something went wrong!</h1>
                    <p>We are sorry for the inconvenience. Please try again later.</p>
                </body>
                </html>";

            return Content(htmlContent, "text/html");
        }
    }
}
