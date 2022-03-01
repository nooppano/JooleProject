using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;

namespace JooleProject.Controllers
{
    public class SearchController : Controller
    {

        public ActionResult Search(String CatIDSearch, String SearchSubcat)
        {


            SearchResultDAL srd = new SearchResultDAL();

            var viewmodelResult = from p in srd.product
                                  join k in srd.subCategory on p.SubCatID equals k.SubCatID
                                  select new SearchResultViewModel { product = p, subCategory = k };

            if (!String.IsNullOrEmpty(CatIDSearch) && !String.IsNullOrEmpty(SearchSubcat))
            {

                viewmodelResult = viewmodelResult.Where(p => p.product.CatID.ToString().Contains(CatIDSearch.ToString()) && p.subCategory.SubCatName.ToLower().Contains(SearchSubcat.ToLower()));
            }
            else if (!String.IsNullOrEmpty(CatIDSearch))
            {
                viewmodelResult = viewmodelResult.Where(p => p.product.CatID.ToString().Contains(CatIDSearch.ToString()));
            }
            else if (!String.IsNullOrEmpty(SearchSubcat))
            {
                viewmodelResult = viewmodelResult.Where(p => p.subCategory.SubCatName.ToLower().Contains(SearchSubcat.ToLower()));
            }
            return View(viewmodelResult.ToList());
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

            return View();
        }

    }
}
