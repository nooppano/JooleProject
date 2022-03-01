using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AdvancedSearchView
    {
        ItlizeJooleDBEntities db = new ItlizeJooleDBEntities();
        public IQueryable<ProductandTypeViewModel> GetPandTVMList()
        {
            var PandT = from p in db.tblProducts
                        join k in db.tblTypes on p.TypeID equals k.TypeID
                        select new ProductandTypeViewModel { Product = p, type = k };
            return PandT;
            
        }
    }
}
