using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
