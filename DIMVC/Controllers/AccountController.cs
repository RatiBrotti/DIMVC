using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DIMVC.Models;
using DIMVC.Context;
using DIMVC.Repository;
using DIMVC.DbClasses;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace DIMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<UnactivatedAccount> _unactivatedAccountRepository;

        public AccountController(IMapper mapper, IGenericRepository<UnactivatedAccount> unactivatedAccountRepository)
        {
            _mapper = mapper;
            _unactivatedAccountRepository = unactivatedAccountRepository;
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
        public IActionResult Registration(RegistrationForm registrationForm)
        {
            var u = _mapper.Map<UnactivatedAccount>(registrationForm);
            u.ActivationToken = "asd";
            _unactivatedAccountRepository.Add(u);
            _unactivatedAccountRepository.SaveChanges();
            
            return View();
        }
    }
}
