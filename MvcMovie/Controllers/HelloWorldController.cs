using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloworldController : Controller
    {
        public string Index()
        {
            return "this is my default action";
        }
        public string Welcome()
        {
            return "This is the welcome action metod";
        }
    }
}