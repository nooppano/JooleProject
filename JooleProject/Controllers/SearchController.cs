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
    public class SearchController : Controller
    {

        public ActionResult Search(String CatIDSearch, String SearchSubcat)
        {


            /*SearchResultDAL srd = new SearchResultDAL();

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
            }*/
            return View();
        }

        // GET: Search
        [HttpGet]
        public ActionResult Index(String CatIDSearch, String SearchSubcat)
        {
            CategoryLogic cat = new CategoryLogic();
            var IQCat = cat.GetIQ();

            ViewBag.catselect = new SelectList(IQCat, "CatID", "CategoryName");
            ViewBag.CatIDSearch = CatIDSearch;
            ViewBag.SearchSubcat = SearchSubcat;

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
        }

    }
}
