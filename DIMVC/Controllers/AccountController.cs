using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DIMVC.Models;
using DIMVC.Context;
using DIMVC.Repository;
using DIMVC.DbClasses;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using DIMVC.Tools;
using System.Net.Mail;

namespace DIMVC.Controllers
{
    public class AccountController : Controller
    {
        ShContext db= new ShContext();
        private readonly IMapper _mapper;
        private readonly IGenericRepository<UnactivatedAccount> _unactivatedAccountRepository;
        private readonly IGenericRepository<ActivatedAccount> _activatedAccountRepository;

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
            string token = Guid.NewGuid().ToString("N");
            var unactivatedAccount = _mapper.Map<UnactivatedAccount>(registrationForm);
            unactivatedAccount.ActivationToken = "asd";
            Mail.SendMail(registrationForm.EmailAddress, "DIMVC", "https://localhost:7211/Account/UserActivation" + "?ActivationToken=" + token);
            _unactivatedAccountRepository.Add(u);
            _unactivatedAccountRepository.SaveChanges();
            
            return View();
        }
        public IActionResult SendToActivated(string activationToken)
        {
            var l = db.UnactivatedAccounts.FirstOrDefault(x => x.ActivationToken.Contains(activationToken));
            if (l != null)
            {
                var activatedAccount =_mapper.Map<ActivatedAccount>(l);
                activatedAccount.UserLevel = 1;
                activatedAccount.DeactivationComment = null;
                activatedAccount.AcaountStatus = true;
                _activatedAccountRepository.Add(activatedAccount);
                _activatedAccountRepository.SaveChanges();
            }
            return RedirectToAction("Login");
        }
    }
}
