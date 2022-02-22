using JooleProject.Models;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(tblUser user)
        {
            if (ModelState.IsValid)
            {
                using (ItlizeJooleDBEntities1 db = new ItlizeJooleDBEntities1())
                {
                    var objUser = db.tblUsers.Where(a => a.Username.Equals(user.Username) && a.Password.Equals(user.Password)).FirstOrDefault();
                    if (objUser != null)
                    {
                        Session["UserID"] = objUser.UserID.ToString();
                        Session["Username"] = objUser.Username.ToString();
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return View(user);
        }

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