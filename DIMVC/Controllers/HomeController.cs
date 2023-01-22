using DIMVC.DbClasses;
using DIMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DIMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {

            _configuration = configuration;
        }

        public IActionResult Index()
        {
            List<Product> p = new List<Product>();
            return View(p);

        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}