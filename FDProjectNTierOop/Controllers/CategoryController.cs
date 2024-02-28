using Microsoft.AspNetCore.Mvc;

namespace FDProjectNTierOop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
