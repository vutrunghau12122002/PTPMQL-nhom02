using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController: Controller
    {
        public IActionResult Index()
        {
            return ViewBag;
        }
    }
}