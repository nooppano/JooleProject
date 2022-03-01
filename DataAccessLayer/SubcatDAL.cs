using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SubcatDAL
    {
        ItlizeJooleDBEntities db = new ItlizeJooleDBEntities();
        public List<tblSubCategory> GetSubcatList()
        {
            var subcat = db.tblSubCategories.ToList();
            return subcat;
        }
    }
}
