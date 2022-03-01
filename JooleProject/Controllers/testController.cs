using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using DataAccessLayer;
using System.Diagnostics;
namespace JooleProject.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            SubcatLogic scl = new SubcatLogic();
            var sc = scl.SubcatList();
            Debug.WriteLine(sc);
            return View();
        }
    }
}