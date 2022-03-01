using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{

    public class SearchResultDAL
    {

        public ProductDAL product { get; set; }
        public SubcatDAL subCategory { get; set; }

        public IQueryable test()
        {
            SearchResultDAL srd = new SearchResultDAL();

            var viewmodelResult = from p in srd.product
                                  join k in srd.subCategory on p.SubCatID equals k.SubCatID
                                  select new SearchResultViewModel { product = p, subCategory = k };
        }
    }
}