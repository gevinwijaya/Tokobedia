using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Repository
{
    public class UserRepository
    {
        private static MyDBEntities2 db = DBSingleton.GetInstance();

        public static void Create(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
        }

        public static User FindUser(String username, String password)
        {
            //lambda Expression
            return db.Users.Where(x => x.Name == username && x.Password == password).FirstOrDefault();
        }

        public static User FindUser(String email)
        {
            return db.Users.Where(x => x.Email == email).FirstOrDefault();
        }

        public static User FindUserById(int id)
        {
            return db.Users.Where(x => x.UserId == id).FirstOrDefault();
        }

        public static List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public static void UpdatePassword(int id, String password)
        {
            User u = db.Users.Where(x => x.UserId == id).FirstOrDefault();
            u.Password = password;
            db.SaveChanges();
        }

        public static void Read()
        {

        }

        public static void UpdateProfile(int id, String name, String email, String gender)
        {
            User u = db.Users.Where(x => x.UserId == id).FirstOrDefault();
            u.Name = name;
            u.Email = email;
            u.Gender = gender;
            db.SaveChanges();
        }

        public static void Update(int id, int role, String status)
        {
            User u = db.Users.Where(x => x.UserId == id).FirstOrDefault();
            u.RoleId = role;
            u.Status = status;
            db.SaveChanges();
        }

        public static void Delete()
        {

        }
    }
}