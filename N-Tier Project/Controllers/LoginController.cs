using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using N_Tier_Project.Models;
using System.Drawing.Text;

namespace N_Tier_Project.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signManager;

        public LoginController(SignInManager<AppUser> signManager)
        {
            _signManager = signManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel uslm)
        {
            if(ModelState.IsValid)
            {
                var result = await _signManager.PasswordSignInAsync(uslm.UserName, uslm.Password, false, true);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index","Category");
                }

                else
                {
                    ModelState.AddModelError("", "Xəta ! Yalnış istifadəçi adı vəya şifrə");
                }
            }
            return View();
        }
    }
}
