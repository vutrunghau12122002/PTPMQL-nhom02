using Microsoft.AspNetCore.Mvc;
namespace MvcMovie.Controllers;

    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        } 
       
    }
