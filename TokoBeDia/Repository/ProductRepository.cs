using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Repository
{
    public class ProductRepository
    {
        private static MyDBEntities2 db = DBSingleton.GetInstance();

        public static List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public static Product FindProductByType(int id)
        {
            return db.Products.Where(x => x.ProductTypeId == id).FirstOrDefault();
        }

        public static void Create(Product newProduct)
        {
            db.Products.Add(newProduct);
            db.SaveChanges();
        }

        public static Product FindProductById(int id)
        {
            return db.Products.Where(x => x.ProductId == id).FirstOrDefault();
        }

        public static void Delete(int id)
        {
            Product p = db.Products.Where(product => product.ProductId == id).FirstOrDefault();
            db.Products.Remove(p);
            db.SaveChanges();
        }

        public static void Update(int id, int producttypeid, String name, int price, int stock)
        {
            Product p = db.Products.Where(x => x.ProductId == id).FirstOrDefault();
            p.ProductTypeId = producttypeid;
            p.Name = name;
            p.Price = price;
            p.Stock = stock;
            db.SaveChanges();
        }

    }
}