using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DIMVC.Models;

namespace DIMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _Conriguration;
        public AccountController(IConfiguration configuration)
        {
            _Conriguration= configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginForm login)
        {
            return Content(login.Id + " " + login.UserName);
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(RegistrationForm RegistrationForm)
        {

            return View();
        }
    }
}
