using Microsoft.AspNetCore.Mvc;
using DIMVC.Models;
using System.Security.Cryptography.X509Certificates;
using DIMVC.Repository;
using DIMVC.DbClasses;

namespace DIMVC.Controllers
{
    public class TestController : Controller
    {
        private readonly IUnactivatedAccount _unactivated;
        public TestController(IUnactivatedAccount unactivated)
        {
            _unactivated = unactivated;
        }
        public IActionResult Index()
        {
            UnactivatedAccount u = new UnactivatedAccount();
            u.ActivationToken = "jsdncnjdc";
            u.FirstName = "sd0";
            u.LastName = "asd";
            u.ModifiedDate = DateTime.Now;
            u.Phone = "sdfdf";
            u.EmailAddress = "adfsfdc";
            u.PasswordHash = "safhds";
            _unactivated.Add(u);
            var li = _unactivated.GetAll();

            return View(li);
        }


    }
}
