using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Repository
{
    public class ProductTypeRepository
    {
        private static MyDBEntities2 db = DBSingleton.GetInstance();

        public static List<ProductType> GetAll()
        {
            return db.ProductTypes.ToList();
        }

        public static void Create(ProductType newProductType)
        {
            db.ProductTypes.Add(newProductType);
            db.SaveChanges();
        }

        public static ProductType FindProductTypeById(int id)
        {
            return db.ProductTypes.Where(x => x.ProductTypeId == id).FirstOrDefault();
        }

        public static ProductType FindProductTypeByName(String name)
        {
            return db.ProductTypes.Where(x => x.Name == name).FirstOrDefault();
        }

        public static void Delete(int id)
        {
            ProductType p = db.ProductTypes.Where(product => product.ProductTypeId == id).FirstOrDefault();
            db.ProductTypes.Remove(p);
            db.SaveChanges();
        }

        public static void Update(int producttypeid, String name, String description)
        {
            ProductType p = db.ProductTypes.Where(x => x.ProductTypeId == producttypeid).FirstOrDefault();
            p.ProductTypeId = producttypeid;
            p.Name = name;
            p.Description = description;
            db.SaveChanges();
        }
    }
}