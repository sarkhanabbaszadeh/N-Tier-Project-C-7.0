using Microsoft.AspNetCore.Mvc;

namespace N_Tier_Project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
