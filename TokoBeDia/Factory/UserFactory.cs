using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Factory
{
    public class UserFactory
    {
        public static User CreateUser(int roleid, String name, String email, String password, String gender, String status)
        {
            User newUser = new User()
            {
                RoleId = roleid,
                Name = name,
                Email = email,
                Password = password,
                Gender = gender,
                Status = status,
            };
            return newUser;
        }
    }
}