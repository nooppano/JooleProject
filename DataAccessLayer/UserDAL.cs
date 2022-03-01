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

        public void Add(int UserID,String Username, String Password, String Email, String Photo)
        {
            tblUser user = new tblUser();
            user.UserID = UserID;
            user.Username = Username;
            user.Password = Password;   
            user.Email = Email;
            user.Photo = Photo;
 
            db.tblUsers.Add(user);
            db.SaveChanges();
        }
    }
}
