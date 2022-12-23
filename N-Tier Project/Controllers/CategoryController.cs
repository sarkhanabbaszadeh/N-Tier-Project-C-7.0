using Microsoft.AspNetCore.Mvc;

namespace N_Tier_Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
