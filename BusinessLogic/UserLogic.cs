﻿using System;
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
    }
}