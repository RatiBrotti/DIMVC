using DIMVC.DbAccess;
using DIMVC.DbClasses;
using DIMVC.Models;
using DIMVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DIMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnactivatedAccount _unactivated;
        private readonly IProduct _product;
        public HomeController(IProduct product, IUnactivatedAccount unactivated)
        {
            _product = product;
            _unactivated = unactivated;
        }

        public IActionResult Index()
        {

            var p = _product.GetAll();
            var li = _unactivated.GetAll();
            return View(p);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}