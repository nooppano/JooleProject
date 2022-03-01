using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class SubcatLogic
    {
        SubcatDAL dal = new SubcatDAL();
        public List<tblSubCategory> SubcatList()
        {
            var ListSubcat = dal.GetSubcatList();
            return ListSubcat;
        }
    }
}
