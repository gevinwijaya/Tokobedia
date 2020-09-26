using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Factory
{
    public class ProductFactory
    {
        public static Product CreateProduct(int producttypeid, String name, int price, int stock)
        {
            Product newProduct = new Product()
            {
                ProductTypeId = producttypeid,
                Name = name,
                Price = price,
                Stock = stock,
            };
            return newProduct;
        }
    }
}