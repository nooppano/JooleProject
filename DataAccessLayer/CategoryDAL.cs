﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAL
    {
        ItlizeJooleDBEntities db = new ItlizeJooleDBEntities();
        public List<tblCategory> GetCategoriesList()
        {
            var categories = db.tblCategories.ToList();
            return categories; 
        }
        public IQueryable<tblCategory> GetIQ()
        {
            var IQCat = db.tblCategories;
            return IQCat;
        }
    }
}
