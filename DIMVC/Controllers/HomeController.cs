using DIMVC.DbAccess;
using DIMVC.DbClasses;
using DIMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DIMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUnactivatedAccount _unactivated;
        private readonly IProduct _product;
        public HomeController(IProduct product, IUnactivatedAccount unactivated, IConfiguration configuration)
        {
            _product = product;
            _unactivated = unactivated;
            _configuration = configuration;
        }

        public IActionResult Index()
        {

            var p = _product.GetAll();
            return View(p);

        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}