using Microsoft.AspNetCore.Mvc;

namespace AssignmentProject.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
