using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TypeDAL
    {
        ItlizeJooleDBEntities db = new ItlizeJooleDBEntities();

        public List<tblType> GetTypeList()
        {
            var type = db.tblTypes.ToList();
            return type;
        }
    }
}
