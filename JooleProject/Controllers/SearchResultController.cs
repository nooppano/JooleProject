using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;

namespace JooleProject.Controllers
{
    public class SearchResultController : Controller
    {
        
        // GET: SearchResult
        public ActionResult SearchResult(String CatIDSearch, String SearchSubcat)
        {
            CategoryLogic cat = new CategoryLogic();
            var IQCat = cat.GetIQ();

            ViewBag.catselect = new SelectList(IQCat, "CatID", "CategoryName");
            ViewBag.CatIDSearch = CatIDSearch;
            ViewBag.SearchSubcat = SearchSubcat;

            /*var products = from p in db.tblProducts
                           select p;*/

            /*var test = from s in db.tblProducts join sa in db.tblSubCategories on s.SubCatID equals sa.SubCatID where sa.SubCatName==(SearchSubcat) select s;*/

            /*var viewmodelResult = from p in db.tblProducts
                                  join k in db.tblSubCategories on p.SubCatID equals k.SubCatID
                                  select new SearchResultViewModel { product = p, subCategory = k };*/

            PandTViewModel pant = new PandTViewModel();
            var panty = pant.PandTList();

            
            if (!String.IsNullOrEmpty(CatIDSearch) && !String.IsNullOrEmpty(SearchSubcat))
            {

                panty = panty.Where(p => p.Product.CatID.ToString().Contains(CatIDSearch.ToString()) && p.subcat.SubCatName.ToLower().Contains(SearchSubcat.ToLower()));
            }
            else if (!String.IsNullOrEmpty(CatIDSearch))
            {
                panty = panty.Where(p => p.Product.CatID.ToString().Contains(CatIDSearch.ToString()));
            }
            else if (!String.IsNullOrEmpty(SearchSubcat))
            {
                panty = panty.Where(p => p.subcat.SubCatName.ToLower().Contains(SearchSubcat.ToLower()));
            }

            return View(panty.ToList());
            
            /* scl = new SubcatLogic();
            var subcatlist = scl.SubcatList();

            return View(subcatlist);*/

        }
    }
}