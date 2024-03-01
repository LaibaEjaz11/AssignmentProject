using Microsoft.AspNetCore.Mvc;

namespace UserManagement.Controllers
{
    public class FrontEndController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
