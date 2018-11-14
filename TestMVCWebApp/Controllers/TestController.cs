using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class TestController : Controller
    {
        // 
        // GET: /Test/

        public IActionResult Index()
        {
            return View();
            //return View();
        }

        // 
        // GET: /Test/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["numTimes"] = numTimes;


            return View();
        }
        // GET: /Test/ TestNote
        public string TestNote()
        {
            return "This is my test Note...";
        }
    }
}