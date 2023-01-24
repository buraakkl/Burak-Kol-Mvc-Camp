using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager mb = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = mb.GetBlogListWithCategory();
            return View(values);
        }
    }
}
