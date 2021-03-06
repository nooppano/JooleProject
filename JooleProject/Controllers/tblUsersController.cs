using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using JooleProject.Models;
using BusinessLogic;
using DataAccessLayer;

namespace JooleProject.Controllers
{
    public class tblUsersController : Controller
    {
        UserLogic Ulogic = new UserLogic();
       

        // GET: tblUsers
        public ActionResult Index()
        {
            var myUser = Ulogic.GetIQUsers();
            return View(myUser);
        }

        //// GET: tblUsers/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    tblUser tblUser = db.tblUsers.Find(id);

        //    if (tblUser == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tblUser);
        //}

        // GET: tblUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int UserID, String Username, String Password, String Email, String Photo)
        {
            if (ModelState.IsValid)
            {

                Ulogic.Add(UserID, Username, Password, Email, Photo);
                return RedirectToAction("Index","Home");
            }

            return View();
        }

        //// GET: tblUsers/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    tblUser tblUser = db.tblUsers.Find(id);
        //    if (tblUser == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tblUser);
        //}

        //// POST: tblUsers/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "UserID,Username,Password,Email,Photo")] tblUser tblUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(tblUser).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(tblUser);
        //}

        //// GET: tblUsers/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    tblUser tblUser = db.tblUsers.Find(id);
        //    if (tblUser == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tblUser);
        //}

        //// POST: tblUsers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    tblUser tblUser = db.tblUsers.Find(id);
        //    db.tblUsers.Remove(tblUser);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //    protected override void Dispose(bool disposing)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        base.Dispose(disposing);
        //    }
    }
}
