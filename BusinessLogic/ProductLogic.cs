using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogic
{
    public class ProductLogic
    {
        ProductDAL dal = new ProductDAL();
        public List<tblProduct> ProductList()
        {
            var ListProducts = dal.GetTblProductsList(); 
            return ListProducts; 
        }
    }
}
