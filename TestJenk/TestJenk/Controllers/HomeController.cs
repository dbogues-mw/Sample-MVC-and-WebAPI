using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLIbrary;

namespace TestJenk.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {

            TestLibrary tl = new TestLibrary();
            tl.TestLibraryMethod();

            return View();
        }
	}
}