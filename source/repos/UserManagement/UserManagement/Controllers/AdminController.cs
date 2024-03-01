using Microsoft.AspNetCore.Mvc;

namespace UserManagement.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
