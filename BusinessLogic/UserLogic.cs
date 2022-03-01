using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogic
{
    public class UserLogic
    {
        UserDAL dal = new UserDAL();
        public List<tblUser> UserList()
        {
            var ListUsers = dal.GetUserList();
            return ListUsers;
        }

        public IQueryable<tblUser> GetIQUsers()
        {
            var users = dal.GetIQUsers();
            return users;
        }

        public void Add(int UserID, String Username, String Password, String Email, String Photo)
        {
            dal.Add(UserID, Username, Password,  Email,  Photo);
        }
    }
}

