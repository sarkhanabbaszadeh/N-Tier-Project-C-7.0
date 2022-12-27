using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using N_Tier_Project.Models;

namespace N_Tier_Project.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.SurName = values.Surname;
            userEditViewModel.Gender = values.Gender;
            userEditViewModel.Email = values.Email;

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel usm)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = usm.Name;
            user.Surname = usm.SurName;
            user.Gender= usm.Gender;
            user.Email = usm.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, usm.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Product");
            }
            else
            {
               // return View(result);
            }

            return View();
        }
    }
}
