//using JooleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JooleProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Login(tblUser user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (ItlizeJooleDBEntities1 db = new ItlizeJooleDBEntities1())
        //        {
        //            var objUser = db.tblUsers.Where(a => a.Username.Equals(user.Username) && a.Password.Equals(user.Password)).FirstOrDefault();
        //            if (objUser != null)
        //            {
        //                Session["UserID"] = objUser.UserID.ToString();
        //                Session["Username"] = objUser.Username.ToString();
        //                return RedirectToAction("Index", "Search");
        //            }
        //            else
        //            {
        //                //If the username and password combination is not present in DB then error message is shown.
        //                ModelState.AddModelError("Failure", "Wrong Username and password combination !");
        //                return RedirectToAction("Index", "Home");
        //            }
        //        }
        //    }
            
        //    return View(user);
        //}

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}