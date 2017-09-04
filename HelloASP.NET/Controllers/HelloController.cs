using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloASP.NET.Controllers
{
    public class HelloController : Controller
    { 
        // GET: Hello
        public ActionResult Index()
        {
            //HttpUtility.HtmlEncode("Hello" + name + "Your ID is" + id);
            //ViewBag.Message = "Hello" + name + "Your ID is" + id;
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + id);
            return View();
        }
    }
}