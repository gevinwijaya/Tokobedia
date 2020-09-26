using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.Factory
{
    public class ProductTypeFactory
    {
        public static ProductType CreateProductType(String name, String description)
        {
            ProductType newProductType = new ProductType()
            {
                Name = name,
                Description = description,
            };
            return newProductType;
        }
    }
}