using Microsoft.AspNetCore.Mvc;

namespace AssignmentProject.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
