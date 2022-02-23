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
    public class AdvancedSearchController : Controller
    {
        private ItlizeJooleDBEntities1 db = new ItlizeJooleDBEntities1();
        // GET: AdvancedSearch
        public ActionResult NavBarSearch(string catNames, string searchString)
        {
            var SubCat = db.tblSubCategories.Include(c => c.tblCategory);
            
            SubCat = from m in db.tblSubCategories
                           select m;
                            
            if(!String.IsNullOrEmpty(searchString))
            {
                SubCat = SubCat.Where(s => s.SubCatName.Contains(searchString));
            }

            var CatLst = new List<String>();

            var CatQry = from d in db.tblCategories
                         select d.CategoryName;
            CatLst.AddRange(CatQry);
            ViewBag.catNames = new SelectList(CatLst);

            if (!String.IsNullOrEmpty(catNames))
            {
                SubCat = SubCat.Where(x => x.tblCategory.CategoryName == catNames);
            }

            return View(SubCat);
        }
        public ActionResult AdvanceSearch()
        {
            return View();
        }
    }
}