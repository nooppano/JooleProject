using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogic
{
    public class PandTViewModel
    {
        public IQueryable<ProductandTypeViewModel> PandTList()
        {
            AdvancedSearchView pandt = new AdvancedSearchView();
            var pant = pandt.GetPandTVMList();
            return pant;
        }
    }
}
