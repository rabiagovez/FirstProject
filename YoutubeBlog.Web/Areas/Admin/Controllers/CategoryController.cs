using Microsoft.AspNetCore.Mvc;

namespace YoutubeBlog.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
