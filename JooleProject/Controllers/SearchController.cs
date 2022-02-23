using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JooleProject.Models;

namespace JooleProject.Controllers
{
    public class SearchController : Controller
    {

        private ItlizeJooleDBEntities1 db = new ItlizeJooleDBEntities1();


        public ActionResult Search(string searchstr)
        {
            return View();
        }

        // GET: Search
        [HttpGet]
        public ActionResult Index(String CatIDSearch, String SearchSubcat)
        {
            ViewBag.catselect = new SelectList(db.tblCategories, "CatID", "CategoryName");
            ViewBag.CatIDSearch = CatIDSearch;
            ViewBag.SearchSubcat = SearchSubcat;

            /*var products = from p in db.tblProducts
                           select p;*/

            /*var test = from s in db.tblProducts join sa in db.tblSubCategories on s.SubCatID equals sa.SubCatID where sa.SubCatName==(SearchSubcat) select s;*/

            var viewmodelResult = from p in db.tblProducts
                                  join k in db.tblSubCategories on p.SubCatID equals k.SubCatID
                                  select new SearchResultViewModel { product = p, subCategory = k };

            if (!String.IsNullOrEmpty(CatIDSearch)/* && !String.IsNullOrEmpty(SearchSubcat)*/)
            {

                viewmodelResult = viewmodelResult.Where(p => p.product.CatID.ToString().Contains(CatIDSearch));
            }

            return View(viewmodelResult.ToList());
        }

        // GET: Search/Details/5 
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCategory tblCategory = db.tblCategories.Find(id);
            if (tblCategory == null)
            {
                return HttpNotFound();
            }
            return View(tblCategory);
        }

        // GET: Search/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Search/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CatID,CategoryName")] tblCategory tblCategory)
        {
            if (ModelState.IsValid)
            {
                db.tblCategories.Add(tblCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblCategory);
        }

        // GET: Search/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCategory tblCategory = db.tblCategories.Find(id);
            if (tblCategory == null)
            {
                return HttpNotFound();
            }
            return View(tblCategory);
        }

        // POST: Search/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CatID,CategoryName")] tblCategory tblCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblCategory);
        }

        // GET: Search/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblCategory tblCategory = db.tblCategories.Find(id);
            if (tblCategory == null)
            {
                return HttpNotFound();
            }
            return View(tblCategory);
        }

        // POST: Search/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblCategory tblCategory = db.tblCategories.Find(id);
            db.tblCategories.Remove(tblCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
