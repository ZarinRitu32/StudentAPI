using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
