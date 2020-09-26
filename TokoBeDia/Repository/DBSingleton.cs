using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Repository
{
    public class DBSingleton
    {
        private static MyDBEntities2 db;

        public static MyDBEntities2 GetInstance()
        {
            if (db == null)
            {
                db = new MyDBEntities2();
            }
            return db;
        }
    }
}