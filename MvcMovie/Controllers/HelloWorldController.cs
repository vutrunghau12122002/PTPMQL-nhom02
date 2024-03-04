using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers;

    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult Index ()
        {
            return View();
        }
       [HttpPost]
        public IActionResult Index (Person ps)
        {
            string strResult = "Xin chao"+ ps.PersonId + ps.Fullname ;
            ViewBag.info = strResult ;
            return View();
        }
    }
