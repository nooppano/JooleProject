using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class ProductDAL
    {
        ItlizeJooleDBEntities db = new ItlizeJooleDBEntities();
        public List<tblProduct> GetTblProductsList()
        {
            var products = db.tblProducts.ToList();
            return products;
        }
    }
}
