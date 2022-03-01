using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAL
    {
        ItlizeJooleDBEntities db = new ItlizeJooleDBEntities();
        public List<tblUser> GetUserList()
        {
            var users = db.tblUsers.ToList();
            return users; 
        }

        public IQueryable<tblUser> GetIQUsers()
        {
            var users = db.tblUsers;
            return users;
        }
    }
}
