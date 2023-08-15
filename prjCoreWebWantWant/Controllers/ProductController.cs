using Microsoft.AspNetCore.Mvc;

namespace prjShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Trash()
        {
            return View();
        }
    }
}
