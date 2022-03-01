using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class CategoryLogic
    {
        CategoryDAL dal = new CategoryDAL();
        public List<tblCategory> CategoryList()
        {
            var ListCategory = dal.GetCategoriesList();
            return ListCategory;
        }
        public IQueryable<tblCategory> GetIQ()
        {
            var IQCat = dal.GetIQ();
            return IQCat;
        }
    }
}
